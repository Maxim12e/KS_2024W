using System;
using System.Windows.Forms;

namespace KS
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            this.Load += About_Load;
        }

        private void About_Load(object sender, EventArgs e)
        {
            // Делаем TextBox многострочным
            txAbout.Multiline = true;
            txAbout.ReadOnly = true;

            // Устанавливаем текст в текстбоксе
            txAbout.Text = Environment.NewLine +
                            "\tAUTHOR: MAKSYM MASALOV" + Environment.NewLine +
                            "\tGROUP: KIUKIu-23-2" + Environment.NewLine +
                            "\tKHARKIV NATIONAL UNIVERSITY" + Environment.NewLine +
                            "\tOF RADIO AND ELECTRONICS" + Environment.NewLine +
                            "\tYEAR: 2024";



            // Устанавливаем ссылку в линклейбле
            tRepository.Text = "GitHub Repository";
            tRepository.Links.Add(0, tRepository.Text.Length, "https://github.com/Maxim12e/KS_2024W");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Это событие можно оставить пустым, если не нужно обрабатывать изменения текста.
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Открытие ссылки в браузере
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

        private void AboutForm_Load(object sender, EventArgs e)
        {

        }
    }
}
