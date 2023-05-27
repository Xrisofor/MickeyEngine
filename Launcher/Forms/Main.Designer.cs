namespace Launcher
{
    partial class Main
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
            panel1 = new Panel();
            EngineButton = new Button();
            ProjectsButton = new Button();
            NewsButton = new Button();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 31, 31);
            panel1.Controls.Add(EngineButton);
            panel1.Controls.Add(ProjectsButton);
            panel1.Controls.Add(NewsButton);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 661);
            panel1.TabIndex = 0;
            // 
            // EngineButton
            // 
            EngineButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EngineButton.FlatStyle = FlatStyle.Flat;
            EngineButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            EngineButton.Location = new Point(12, 157);
            EngineButton.Name = "EngineButton";
            EngineButton.Size = new Size(223, 39);
            EngineButton.TabIndex = 3;
            EngineButton.Text = "Engine";
            EngineButton.UseVisualStyleBackColor = true;
            EngineButton.Click += EngineButton_Click;
            // 
            // ProjectsButton
            // 
            ProjectsButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ProjectsButton.FlatStyle = FlatStyle.Flat;
            ProjectsButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ProjectsButton.Location = new Point(12, 112);
            ProjectsButton.Name = "ProjectsButton";
            ProjectsButton.Size = new Size(223, 39);
            ProjectsButton.TabIndex = 2;
            ProjectsButton.Text = "Projects";
            ProjectsButton.UseVisualStyleBackColor = true;
            ProjectsButton.Click += ProjectsButton_Click;
            // 
            // NewsButton
            // 
            NewsButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NewsButton.FlatStyle = FlatStyle.Flat;
            NewsButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            NewsButton.Location = new Point(12, 67);
            NewsButton.Name = "NewsButton";
            NewsButton.Size = new Size(223, 39);
            NewsButton.TabIndex = 1;
            NewsButton.Text = "News";
            NewsButton.UseVisualStyleBackColor = true;
            NewsButton.Click += NewsButton_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(248, 64);
            label1.TabIndex = 0;
            label1.Text = "Mickey Engine";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(882, 661);
            label2.TabIndex = 1;
            label2.Text = "We couldn't find your projects, create a new project or add them manually";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(248, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(882, 661);
            panel2.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(1130, 661);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.White;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mickey Engine";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button NewsButton;
        private Button EngineButton;
        private Button ProjectsButton;
        private Panel panel2;
    }
}