namespace KS
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            bFormatDisk = new Button();
            bDefragmentation = new Button();
            bTesting = new Button();
            button4 = new Button();
            panel1 = new Panel();
            tGithub = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // bFormatDisk
            // 
            bFormatDisk.BackColor = Color.NavajoWhite;
            bFormatDisk.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            bFormatDisk.FlatAppearance.BorderSize = 3;
            bFormatDisk.FlatAppearance.MouseDownBackColor = Color.LightGray;
            bFormatDisk.FlatAppearance.MouseOverBackColor = Color.Silver;
            bFormatDisk.FlatStyle = FlatStyle.Flat;
            bFormatDisk.Font = new Font("Bahnschrift", 10F, FontStyle.Bold);
            bFormatDisk.ForeColor = Color.FromArgb(64, 64, 64);
            bFormatDisk.Location = new Point(26, 23);
            bFormatDisk.Name = "bFormatDisk";
            bFormatDisk.Size = new Size(177, 41);
            bFormatDisk.TabIndex = 0;
            bFormatDisk.Text = "FORMAT DISK";
            bFormatDisk.UseVisualStyleBackColor = false;
            bFormatDisk.Click += button1_Click;
            // 
            // bDefragmentation
            // 
            bDefragmentation.BackColor = Color.NavajoWhite;
            bDefragmentation.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            bDefragmentation.FlatAppearance.BorderSize = 3;
            bDefragmentation.FlatAppearance.MouseDownBackColor = Color.LightGray;
            bDefragmentation.FlatAppearance.MouseOverBackColor = Color.Silver;
            bDefragmentation.FlatStyle = FlatStyle.Flat;
            bDefragmentation.Font = new Font("Bahnschrift", 10F, FontStyle.Bold);
            bDefragmentation.ForeColor = Color.FromArgb(64, 64, 64);
            bDefragmentation.Location = new Point(26, 71);
            bDefragmentation.Name = "bDefragmentation";
            bDefragmentation.Size = new Size(177, 41);
            bDefragmentation.TabIndex = 1;
            bDefragmentation.Text = "DEFRAGMENTATION";
            bDefragmentation.UseVisualStyleBackColor = false;
            bDefragmentation.Click += button2_Click;
            // 
            // bTesting
            // 
            bTesting.BackColor = Color.NavajoWhite;
            bTesting.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            bTesting.FlatAppearance.BorderSize = 3;
            bTesting.FlatAppearance.MouseDownBackColor = Color.LightGray;
            bTesting.FlatAppearance.MouseOverBackColor = Color.Silver;
            bTesting.FlatStyle = FlatStyle.Flat;
            bTesting.Font = new Font("Bahnschrift", 10F, FontStyle.Bold);
            bTesting.ForeColor = Color.FromArgb(64, 64, 64);
            bTesting.Location = new Point(26, 118);
            bTesting.Name = "bTesting";
            bTesting.RightToLeft = RightToLeft.No;
            bTesting.Size = new Size(177, 41);
            bTesting.TabIndex = 2;
            bTesting.Text = "TESTING";
            bTesting.UseVisualStyleBackColor = false;
            bTesting.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.NavajoWhite;
            button4.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button4.FlatAppearance.BorderSize = 3;
            button4.FlatAppearance.MouseDownBackColor = Color.LightGray;
            button4.FlatAppearance.MouseOverBackColor = Color.Silver;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Bahnschrift", 10F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(64, 64, 64);
            button4.Location = new Point(26, 165);
            button4.Name = "button4";
            button4.Size = new Size(177, 41);
            button4.TabIndex = 3;
            button4.Text = "ABOUT";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(bFormatDisk);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(bDefragmentation);
            panel1.Controls.Add(bTesting);
            panel1.Location = new Point(304, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(226, 393);
            panel1.TabIndex = 4;
            // 
            // tGithub
            // 
            tGithub.ActiveLinkColor = Color.IndianRed;
            tGithub.AutoSize = true;
            tGithub.BackColor = Color.FromArgb(64, 64, 64);
            tGithub.LinkColor = Color.NavajoWhite;
            tGithub.Location = new Point(23, 346);
            tGithub.Name = "tGithub";
            tGithub.Padding = new Padding(3, 3, 3, 6);
            tGithub.Size = new Size(63, 26);
            tGithub.TabIndex = 5;
            tGithub.TabStop = true;
            tGithub.Text = "GITHUB";
            tGithub.VisitedLinkColor = Color.Orchid;
            tGithub.LinkClicked += tRepository_LinkClicked;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(530, 392);
            Controls.Add(tGithub);
            Controls.Add(panel1);
            Font = new Font("Bahnschrift", 10F, FontStyle.Bold);
            ForeColor = Color.FromArgb(64, 64, 64);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(546, 431);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimumSize = new Size(546, 431);
            Name = "MainForm";
            Padding = new Padding(20);
            Text = "DISK SOFTWARE";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bFormatDisk;
        private Button bDefragmentation;
        private Button bTesting;
        private Button button4;
        private Panel panel1;
        private LinkLabel tGithub;
    }
}
