namespace KS
{
    partial class FormatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormatForm));
            comboBox1 = new ComboBox();
            button1 = new Button();
            comboBox2 = new ComboBox();
            pFormating = new Panel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            pFormating.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Silver;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.Font = new Font("Bahnschrift", 10F, FontStyle.Bold);
            comboBox1.ForeColor = Color.FromArgb(64, 64, 64);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(197, 13);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(206, 24);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatAppearance.MouseDownBackColor = Color.Silver;
            button1.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift", 10F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(64, 64, 64);
            button1.Location = new Point(12, 154);
            button1.Name = "button1";
            button1.Size = new Size(415, 39);
            button1.TabIndex = 1;
            button1.Text = "START FORMATING DISK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.Silver;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.System;
            comboBox2.Font = new Font("Bahnschrift", 10F, FontStyle.Bold);
            comboBox2.ForeColor = Color.FromArgb(64, 64, 64);
            comboBox2.Location = new Point(197, 59);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(206, 24);
            comboBox2.TabIndex = 0;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // pFormating
            // 
            pFormating.BackColor = Color.FromArgb(64, 64, 64);
            pFormating.Controls.Add(label2);
            pFormating.Controls.Add(label1);
            pFormating.Controls.Add(comboBox1);
            pFormating.Controls.Add(comboBox2);
            pFormating.Location = new Point(12, 48);
            pFormating.Name = "pFormating";
            pFormating.Size = new Size(415, 99);
            pFormating.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Font = new Font("Bahnschrift", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(13, 60);
            label2.MaximumSize = new Size(170, 0);
            label2.MinimumSize = new Size(170, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(3);
            label2.Size = new Size(170, 23);
            label2.TabIndex = 6;
            label2.Text = "FILE SYSTEM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Bahnschrift", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(13, 14);
            label1.MaximumSize = new Size(170, 0);
            label1.MinimumSize = new Size(170, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(3);
            label1.Size = new Size(170, 23);
            label1.TabIndex = 5;
            label1.Text = "DISK FOR FORMATTING";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.IndianRed;
            label3.Font = new Font("Bahnschrift", 10F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 10);
            label3.MaximumSize = new Size(415, 0);
            label3.MinimumSize = new Size(415, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(3, 11, 3, 11);
            label3.Size = new Size(415, 39);
            label3.TabIndex = 7;
            label3.Text = "THIS ACTION CAN REMOVE ALL YOUR DATA!!!";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormatForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(439, 207);
            Controls.Add(label3);
            Controls.Add(pFormating);
            Controls.Add(button1);
            Font = new Font("Bahnschrift", 10F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormatForm";
            Text = "FORMATTING";
            pFormating.ResumeLayout(false);
            pFormating.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private ComboBox comboBox2;
        private Panel pFormating;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}