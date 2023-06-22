namespace Editor.App
{
    partial class SplashScreen
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
            panel1 = new Panel();
            NameLabel = new Label();
            LoadingLabel = new Label();
            VersionLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = ImageList.splash_screen;
            panel1.Controls.Add(VersionLabel);
            panel1.Controls.Add(LoadingLabel);
            panel1.Controls.Add(NameLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(602, 252);
            panel1.TabIndex = 0;
            // 
            // NameLabel
            // 
            NameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            NameLabel.BackColor = Color.Transparent;
            NameLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.ForeColor = Color.White;
            NameLabel.Location = new Point(12, 9);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(578, 172);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Mickey Editor";
            NameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LoadingLabel
            // 
            LoadingLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LoadingLabel.BackColor = Color.Transparent;
            LoadingLabel.ForeColor = Color.White;
            LoadingLabel.Location = new Point(264, 200);
            LoadingLabel.Name = "LoadingLabel";
            LoadingLabel.Size = new Size(326, 43);
            LoadingLabel.TabIndex = 1;
            LoadingLabel.Text = "Loading...";
            LoadingLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // VersionLabel
            // 
            VersionLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            VersionLabel.BackColor = Color.Transparent;
            VersionLabel.ForeColor = Color.White;
            VersionLabel.Location = new Point(12, 200);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(246, 43);
            VersionLabel.TabIndex = 2;
            VersionLabel.Text = "Version: 0.1.0";
            VersionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 252);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mickey Engine";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label NameLabel;
        private Label LoadingLabel;
        private Label VersionLabel;
    }
}