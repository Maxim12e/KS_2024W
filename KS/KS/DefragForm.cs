using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace KS
{
    public partial class DefragForm : Form
    {
        public DefragForm()
        {
            InitializeComponent();
            LoadDrivesIntoComboBox();
            this.Text = "Defragmentation";
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
                    comboBox1.Items.Add($"{drive.Name} (Inaccessible)");
                }
            }

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0; // Встановити перший елемент вибраним
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedDrive = comboBox1.SelectedItem.ToString();
                //MessageBox.Show($"You have selected a disk: {selectedDrive}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a disk.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedDrive = comboBox1.SelectedItem.ToString().Split(' ')[0]; // Витягти букву диска, наприклад, "C:\"

            try
            {
                DefragmentDrive(selectedDrive);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during defragmentation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DefragmentDrive(string driveLetter)
        {
            // Перевірка наявності адміністративних привілеїв
            if (!IsAdministrator())
            {
                MessageBox.Show("The program must be run with administrator rights.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProcessStartInfo processInfo = new ProcessStartInfo
            {
                FileName = "defrag.exe", // Утиліта Windows для дефрагментації
                Arguments = $"{driveLetter} /U /V", // Виконання дефрагментації
                UseShellExecute = false,
                CreateNoWindow = true
            };

            try
            {
                using (Process process = Process.Start(processInfo))
                {
                    process?.WaitForExit();

                    if (process != null && process.ExitCode == 0)
                    {
                        MessageBox.Show($"Disk Defragmentation {driveLetter} successfully completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Error while defragmenting disk {driveLetter}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Defragmentation failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Перевірка, чи запущено додаток з правами адміністратора
        private bool IsAdministrator()
        {
            using (var identity = System.Security.Principal.WindowsIdentity.GetCurrent())
            {
                var principal = new System.Security.Principal.WindowsPrincipal(identity);
                return principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator);
            }
        }

        private void DefragForm_Load(object sender, EventArgs e)
        {

        }
    }
}
