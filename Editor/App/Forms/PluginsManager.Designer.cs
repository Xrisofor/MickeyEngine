namespace Editor.App.Forms
{
    partial class PluginsManager
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginsManager));
            listView1 = new ListView();
            imageList1 = new System.Windows.Forms.ImageList(components);
            InstalledPluginsButton = new Button();
            AllPluginsButton = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Activation = ItemActivation.TwoClick;
            listView1.BackColor = Color.FromArgb(33, 37, 41);
            listView1.BorderStyle = BorderStyle.FixedSingle;
            listView1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.ForeColor = Color.White;
            listView1.LargeImageList = imageList1;
            listView1.Location = new Point(12, 47);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(476, 391);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "plugin.png");
            // 
            // InstalledPluginsButton
            // 
            InstalledPluginsButton.BackColor = Color.FromArgb(33, 37, 41);
            InstalledPluginsButton.FlatStyle = FlatStyle.Flat;
            InstalledPluginsButton.ForeColor = Color.White;
            InstalledPluginsButton.Location = new Point(12, 12);
            InstalledPluginsButton.Name = "InstalledPluginsButton";
            InstalledPluginsButton.Size = new Size(235, 29);
            InstalledPluginsButton.TabIndex = 2;
            InstalledPluginsButton.Text = "Installed Plugins";
            InstalledPluginsButton.UseVisualStyleBackColor = false;
            // 
            // AllPluginsButton
            // 
            AllPluginsButton.BackColor = Color.FromArgb(33, 37, 41);
            AllPluginsButton.FlatStyle = FlatStyle.Flat;
            AllPluginsButton.ForeColor = Color.White;
            AllPluginsButton.Location = new Point(253, 12);
            AllPluginsButton.Name = "AllPluginsButton";
            AllPluginsButton.Size = new Size(235, 29);
            AllPluginsButton.TabIndex = 3;
            AllPluginsButton.Text = "All Plugins";
            AllPluginsButton.UseVisualStyleBackColor = false;
            AllPluginsButton.Click += AllPluginsButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 37, 41);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 449);
            panel1.Name = "panel1";
            panel1.Size = new Size(476, 65);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(476, 65);
            label1.TabIndex = 0;
            label1.Text = "Name: None\r\nDeveloper: None\r\nVersion: None";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PluginsManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 58, 64);
            ClientSize = new Size(500, 526);
            Controls.Add(panel1);
            Controls.Add(listView1);
            Controls.Add(AllPluginsButton);
            Controls.Add(InstalledPluginsButton);
            ForeColor = Color.White;
            Name = "PluginsManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Plugins Manager";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button InstalledPluginsButton;
        private Button AllPluginsButton;
        private System.Windows.Forms.ImageList imageList1;
        private Panel panel1;
        private Label label1;
    }
}