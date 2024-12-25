namespace KS
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            TestingForm = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            pTestPanel = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pTestPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TestingForm
            // 
            TestingForm.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            TestingForm.FlatAppearance.BorderSize = 3;
            TestingForm.FlatAppearance.MouseDownBackColor = Color.Silver;
            TestingForm.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            TestingForm.FlatStyle = FlatStyle.Flat;
            TestingForm.Font = new Font("Bahnschrift", 10F, FontStyle.Bold);
            TestingForm.ForeColor = Color.FromArgb(64, 64, 64);
            TestingForm.Location = new Point(12, 149);
            TestingForm.Name = "TestingForm";
            TestingForm.Size = new Size(415, 37);
            TestingForm.TabIndex = 0;
            TestingForm.Text = "START TESTING DISK";
            TestingForm.UseVisualStyleBackColor = true;
            TestingForm.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Silver;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.ForeColor = Color.FromArgb(64, 64, 64);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(197, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(206, 24);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.Silver;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.System;
            comboBox2.ForeColor = Color.FromArgb(64, 64, 64);
            comboBox2.Location = new Point(197, 14);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(206, 24);
            comboBox2.TabIndex = 0;
            // 
            // comboBox3
            // 
            comboBox3.BackColor = Color.Silver;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FlatStyle = FlatStyle.System;
            comboBox3.ForeColor = Color.FromArgb(64, 64, 64);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(197, 95);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(206, 24);
            comboBox3.TabIndex = 2;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // pTestPanel
            // 
            pTestPanel.BackColor = Color.FromArgb(64, 64, 64);
            pTestPanel.Controls.Add(label3);
            pTestPanel.Controls.Add(label2);
            pTestPanel.Controls.Add(label1);
            pTestPanel.Controls.Add(comboBox2);
            pTestPanel.Controls.Add(comboBox3);
            pTestPanel.Controls.Add(comboBox1);
            pTestPanel.Location = new Point(12, 12);
            pTestPanel.Name = "pTestPanel";
            pTestPanel.Size = new Size(415, 131);
            pTestPanel.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Silver;
            label3.Font = new Font("Bahnschrift", 10F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(17, 95);
            label3.MaximumSize = new Size(165, 0);
            label3.MinimumSize = new Size(165, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(10, 3, 3, 3);
            label3.Size = new Size(165, 23);
            label3.TabIndex = 5;
            label3.Text = "FEIGHT, MB";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Font = new Font("Bahnschrift", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(17, 54);
            label2.MaximumSize = new Size(165, 0);
            label2.MinimumSize = new Size(165, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(10, 3, 3, 3);
            label2.Size = new Size(165, 23);
            label2.TabIndex = 4;
            label2.Text = "DISK FOR TEST";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Bahnschrift", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(17, 14);
            label1.MaximumSize = new Size(165, 0);
            label1.MinimumSize = new Size(165, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 3, 3, 3);
            label1.Size = new Size(165, 23);
            label1.TabIndex = 3;
            label1.Text = "TESTING TYPE";
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(439, 198);
            Controls.Add(pTestPanel);
            Controls.Add(TestingForm);
            Font = new Font("Bahnschrift", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "TestForm";
            Text = "TESTING";
            Load += TestForm_Load;
            pTestPanel.ResumeLayout(false);
            pTestPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button TestingForm;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Panel pTestPanel;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}