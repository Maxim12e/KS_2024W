using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Windows.Forms;

namespace KS
{
    public partial class FormatForm : Form
    {
        public FormatForm()
        {
            InitializeComponent();
            LoadDrivesIntoComboBox();
            LoadFileSystemsIntoComboBox();
            this.Text = "Formatting disk";
        }

        private bool IsAdministrator()
        {
            using (var identity = WindowsIdentity.GetCurrent())
            {
                var principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (!IsAdministrator())
            {
                MessageBox.Show("Please run the program with administrator privileges.", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close(); // Завершення програми
            }
        }

        // Завантаження списку дисків у comboBox1
        private void LoadDrivesIntoComboBox()
        {
            comboBox1.Items.Clear();
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (var drive in drives)
            {
                if (drive.IsReady) // Тільки готові диски
                {
                    comboBox1.Items.Add($"{drive.Name} ({drive.VolumeLabel})");
                }
                else
                {
                    comboBox1.Items.Add(drive.Name);
                }
            }
        }

        // Завантаження типів файлових систем у comboBox2
        private void LoadFileSystemsIntoComboBox()
        {
            comboBox2.Items.Clear();
            comboBox2.Items.Add("NTFS");
            comboBox2.Items.Add("FAT32");
            comboBox2.Items.Add("exFAT");
            comboBox2.SelectedIndex = 0; // NTFS за замовчуванням
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedDrive = comboBox1.SelectedItem.ToString();
                //MessageBox.Show($"You chose: {selectedDrive}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a disk to format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select a file system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string selectedDrive = comboBox1.SelectedItem.ToString();
                string driveName = selectedDrive.Split(' ')[0]; // Отримання імені диска (наприклад, "C:\")
                string fileSystem = comboBox2.SelectedItem.ToString(); // Отримання вибраної файлової системи

                DialogResult dialogResult = MessageBox.Show(
                    $"Are you sure you want to format the disk {driveName} in the file system {fileSystem}?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    FormatDrive(driveName, fileSystem);
                    MessageBox.Show($"Disk {driveName} successfully formatted in file system {fileSystem}.", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Disk formatting error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDrive(string driveName, string fileSystem)
        {
            string volume = driveName.TrimEnd('\\'); // Видалення завершаючого слеша

            if (!IsAdministrator())
            {
                MessageBox.Show("The program must be run with administrator rights.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (fileSystem == "FAT32" && !CheckFAT32Compatibility(volume))
            {
                MessageBox.Show("The partition is too large to be formatted in FAT32 (maximum 32 GB).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string script = $"select volume {volume}\nformat fs={fileSystem} quick\nexit";
            string tempScriptFile = Path.GetTempFileName();
            File.WriteAllText(tempScriptFile, script);

            ProcessStartInfo psi = new ProcessStartInfo("diskpart.exe")
            {
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                CreateNoWindow = true,
                Arguments = $"/s {tempScriptFile}"
            };

            using (var process = Process.Start(psi))
            {
                process?.WaitForExit();
            }

            File.Delete(tempScriptFile); // Видалення тимчасового файлу
        }

        private bool CheckFAT32Compatibility(string driveName)
        {
            DriveInfo drive = DriveInfo.GetDrives().FirstOrDefault(d => d.Name.TrimEnd('\\') == driveName);
            if (drive != null && drive.IsReady)
            {
                long maxSize = 32L * 1024 * 1024 * 1024; // 32 ГБ у байтах
                return drive.TotalSize <= maxSize;
            }
            return false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
