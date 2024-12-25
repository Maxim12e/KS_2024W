using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace KS
{
    public partial class TestForm : Form
    {
        private int testFileSizeMB = 128; // Розмір тестового файлу за замовчуванням (128 МБ)

        public TestForm()
        {
            InitializeComponent();
            LoadDrivesIntoComboBox();
            LoadTestOptionsIntoComboBox();
            LoadTestSizesIntoComboBox();
            this.Text = "Testing";
        }

        // Завантаження списку дисків у comboBox1
        private void LoadDrivesIntoComboBox()
        {
            comboBox1.Items.Clear();
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (var drive in drives)
            {
                if (drive.IsReady) // Додати лише доступні диски
                {
                    comboBox1.Items.Add($"{drive.Name} ({drive.VolumeLabel})");
                }
                else
                {
                    comboBox1.Items.Add($"{drive.Name} (Inaccessible)");
                }
            }

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0; // Встановити перший елемент як вибраний
            }
        }

        // Завантаження варіантів тестів у comboBox2
        private void LoadTestOptionsIntoComboBox()
        {
            comboBox2.Items.Clear();
            comboBox2.Items.Add("Check availability");
            comboBox2.Items.Add("Write speed test");
            comboBox2.Items.Add("Reading speed test");
            comboBox2.Items.Add("SMART-check");
            comboBox2.SelectedIndex = 0; // Встановити перший елемент як вибраний
        }

        // Завантаження доступних розмірів файлів для тестів у comboBox3
        private void LoadTestSizesIntoComboBox()
        {
            comboBox3.Items.Clear();
            comboBox3.Items.Add("64 MB");
            comboBox3.Items.Add("128 MB");
            comboBox3.Items.Add("256 MB");
            comboBox3.SelectedIndex = 1; // За замовчуванням 128 МБ
        }

        // Обробка вибору розміру тестового файлу
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSize = comboBox3.SelectedItem.ToString();
            switch (selectedSize)
            {
                case "64 MB":
                    testFileSizeMB = 64;
                    break;
                case "128 MB":
                    testFileSizeMB = 128;
                    break;
                case "256 MB":
                    testFileSizeMB = 256;
                    break;
                default:
                    testFileSizeMB = 128;
                    break;
            }
        }

        // Обробка вибору диска
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedDrive = comboBox1.SelectedItem.ToString();
                //MessageBox.Show($"You have selected a disk: {selectedDrive}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Запуск вибраного тесту
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a disk..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select a test type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedDrive = comboBox1.SelectedItem.ToString().Split(' ')[0]; // Витягуємо букву диска, наприклад "C:\\"
            string selectedTest = comboBox2.SelectedItem.ToString(); // Витягуємо вибраний тип тесту

            // Виконання тесту
            PerformTest(selectedDrive, selectedTest);
        }

        // Метод для виконання обраного тесту
        private void PerformTest(string driveLetter, string testType)
        {
            try
            {
                switch (testType)
                {
                    case "Check availability":
                        if (IsDriveAccessible(driveLetter))
                        {
                            MessageBox.Show($"Disk {driveLetter} is available.", "Test result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Disk {driveLetter} is inaccessible.", "Test result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

                    case "Write speed test":
                        double writeSpeed = TestWriteSpeed(driveLetter);
                        MessageBox.Show($"Disc writing speed {driveLetter}: {writeSpeed:F2} MB/s", "Test result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "Reading speed test":
                        double readSpeed = TestReadSpeed(driveLetter);
                        MessageBox.Show($"Disk read speed {driveLetter}: {readSpeed:F2} MB/s", "Test result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "SMART-check":
                        string smartStatus = PerformSmartCheck(driveLetter);
                        MessageBox.Show($"SMART status for the disk {driveLetter}: {smartStatus}", "Test result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    default:
                        MessageBox.Show("The selected test is not implemented..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Test execution error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Перевірка доступності диска
        private bool IsDriveAccessible(string driveLetter)
        {
            try
            {
                string testPath = Path.Combine(driveLetter, "test_access.tmp");
                File.WriteAllText(testPath, "Test recording");
                File.Delete(testPath);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Тест швидкості запису на диск
        private double TestWriteSpeed(string driveLetter)
        {
            string testFilePath = Path.Combine(driveLetter, "write_test.tmp");
            byte[] data = new byte[1024 * 1024 * testFileSizeMB]; // Вибраний розмір файлу
            new Random().NextBytes(data);

            Stopwatch stopwatch = Stopwatch.StartNew();
            File.WriteAllBytes(testFilePath, data);
            stopwatch.Stop();

            File.Delete(testFilePath);

            double elapsedSeconds = stopwatch.Elapsed.TotalSeconds;
            return data.Length / (1024.0 * 1024.0) / elapsedSeconds; // Швидкість у МБ/с
        }

        // Тест швидкості читання з диска
        private double TestReadSpeed(string driveLetter)
        {
            string testFilePath = Path.Combine(driveLetter, "read_test.tmp");
            byte[] data = new byte[1024 * 1024 * testFileSizeMB]; // Вибраний розмір файлу
            new Random().NextBytes(data);

            File.WriteAllBytes(testFilePath, data); // Створюємо файл для тесту

            Stopwatch stopwatch = Stopwatch.StartNew();
            byte[] readData = File.ReadAllBytes(testFilePath);
            stopwatch.Stop();

            File.Delete(testFilePath);

            double elapsedSeconds = stopwatch.Elapsed.TotalSeconds;
            return readData.Length / (1024.0 * 1024.0) / elapsedSeconds; // Швидкість у МБ/с
        }

        // SMART-перевірка
        private string PerformSmartCheck(string driveLetter)
        {
            try
            {
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = "wmic",
                    Arguments = $"diskdrive get status",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(processInfo))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();

                    if (output.Contains("OK"))
                    {
                        return "Good condition";
                    }
                    else
                    {
                        return "Possible problems";
                    }
                }
            }
            catch
            {
                return "SMART check failed";
            }
        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }
    }
}
