using System;
using System.Windows.Forms;
using System.Management;

namespace KS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Вывод информации о дисках при запуске
            DisplayDiskInfo();

            // Устанавливаем ссылку в линклейбле
            tGithub.Text = "GitHub Repository";
            tGithub.Links.Add(0, tGithub.Text.Length, "https://github.com/Maxim12e/KS_2024W");
        }

        private void DisplayDiskInfo()
        {
            try
            {
                // Создаем Label для отображения информации
                Label diskInfoLabel = new Label
                {
                    AutoSize = false,
                    Dock = DockStyle.Top,
                    Height = 300,
                    TextAlign = System.Drawing.ContentAlignment.TopLeft
                };

                // Получение данных о дисках через WMI
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
                string diskInfoText = "";

                foreach (ManagementObject disk in searcher.Get())
                {
                    // Сбор данных о каждом диске
                    string model = disk["Model"]?.ToString() ?? "Unknown Model";
                    string interfaceType = disk["InterfaceType"]?.ToString() ?? "Unknown Interface";
                    string mediaType = disk["MediaType"]?.ToString(); // SSD или HDD
                    string size = disk["Size"] != null
                        ? (Convert.ToInt64(disk["Size"]) / (1024 * 1024 * 1024)).ToString() + " GB"
                        : "Unknown Size";

                    // Определяем RPM и SATA версию
                    string rpm = GetRPM(model);
                    string sataVersion = GetSATAVersion(model);

                    // Определяем тип носителя
                    string type = mediaType ?? (model.ToUpper().Contains("SSD") ? "SSD" : "HDD");

                    // Формируем текст для вывода
                    diskInfoText += $"Type: {type}\n";
                    diskInfoText += $"Model: {model}\n";
                    diskInfoText += $"Interface: {interfaceType}\n";
                    diskInfoText += $"Size: {size}\n";
                    diskInfoText += $"SATA Version: {sataVersion}\n";
                }

                // Устанавливаем текст в Label
                diskInfoLabel.Text = diskInfoText;

                // Добавляем Label на форму
                this.Controls.Add(diskInfoLabel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving disk data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetRPM(string model)
        {
            // Определяем RPM на основе модели
            if (model.Contains("5400")) return "5400 RPM";
            if (model.Contains("7200")) return "7200 RPM";
            if (model.Contains("10000")) return "10000 RPM";
            if (model.Contains("15000")) return "15000 RPM";

            // Возвращаем значение по умолчанию
            return "Unknown RPM";
        }

        private string GetSATAVersion(string model)
        {
            // Определяем версию SATA на основе модели
            if (model.Contains("VBOX")) return "SATA II"; // Пример для VirtualBox
            if (model.Contains("SSD")) return "SATA III";
            if (model.Contains("HDD") && model.Contains("5400")) return "SATA II";

            return "Unknown SATA Version";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormatForm form = new FormatForm();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DefragForm form = new DefragForm();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TestForm form = new TestForm();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tRepository_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string target = e.Link.LinkData as string;
            if (!string.IsNullOrEmpty(target))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = target,
                    UseShellExecute = true
                });
            }
        }
    }
}
