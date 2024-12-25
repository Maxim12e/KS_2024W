namespace KS
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            txAbout = new TextBox();
            tRepository = new LinkLabel();
            SuspendLayout();
            // 
            // txAbout
            // 
            txAbout.BackColor = Color.FromArgb(64, 64, 64);
            txAbout.BorderStyle = BorderStyle.None;
            txAbout.CharacterCasing = CharacterCasing.Upper;
            txAbout.Font = new Font("Bahnschrift", 10F, FontStyle.Bold);
            txAbout.ForeColor = Color.LightGray;
            txAbout.ImeMode = ImeMode.Disable;
            txAbout.Location = new Point(12, 15);
            txAbout.MinimumSize = new Size(309, 103);
            txAbout.Multiline = true;
            txAbout.Name = "txAbout";
            txAbout.ReadOnly = true;
            txAbout.Size = new Size(309, 120);
            txAbout.TabIndex = 0;
            txAbout.TextChanged += textBox1_TextChanged;
            // 
            // tRepository
            // 
            tRepository.ActiveLinkColor = Color.IndianRed;
            tRepository.AutoSize = true;
            tRepository.BackColor = Color.FromArgb(64, 64, 64);
            tRepository.LinkColor = Color.NavajoWhite;
            tRepository.Location = new Point(12, 147);
            tRepository.Name = "tRepository";
            tRepository.Padding = new Padding(3, 3, 3, 6);
            tRepository.Size = new Size(77, 26);
            tRepository.TabIndex = 1;
            tRepository.TabStop = true;
            tRepository.Text = "linkLabel1";
            tRepository.VisitedLinkColor = Color.Orchid;
            tRepository.LinkClicked += linkLabel1_LinkClicked;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(333, 186);
            Controls.Add(tRepository);
            Controls.Add(txAbout);
            Font = new Font("Bahnschrift", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(252, 201);
            Name = "AboutForm";
            ShowInTaskbar = false;
            Text = "ABOUT PROGRAM";
            TopMost = true;
            Load += AboutForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txAbout;
        private LinkLabel tRepository;
    }
}