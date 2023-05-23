namespace Launcher.Forms
{
    partial class Engine
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Test" }, "icons8-services-500.png", Color.Empty, Color.Empty, new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Engine));
            label1 = new Label();
            AddVersionButton = new Button();
            listView1 = new ListView();
            imageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(212, 38);
            label1.TabIndex = 0;
            label1.Text = "Engine Versions";
            // 
            // AddVersionButton
            // 
            AddVersionButton.FlatAppearance.BorderSize = 0;
            AddVersionButton.FlatStyle = FlatStyle.Flat;
            AddVersionButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddVersionButton.Location = new Point(727, 12);
            AddVersionButton.Name = "AddVersionButton";
            AddVersionButton.Size = new Size(143, 38);
            AddVersionButton.TabIndex = 2;
            AddVersionButton.Text = "Add Version";
            AddVersionButton.UseVisualStyleBackColor = true;
            AddVersionButton.Click += AddVersionButton_Click;
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(31, 31, 31);
            listView1.BorderStyle = BorderStyle.FixedSingle;
            listView1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.ForeColor = Color.White;
            listView1.GroupImageList = imageList1;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.LargeImageList = imageList1;
            listView1.Location = new Point(12, 69);
            listView1.Name = "listView1";
            listView1.Size = new Size(858, 580);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-services-500.png");
            // 
            // Engine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(882, 661);
            Controls.Add(listView1);
            Controls.Add(AddVersionButton);
            Controls.Add(label1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Engine";
            Text = "Engine";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button AddVersionButton;
        private ListView listView1;
        private ImageList imageList1;
    }
}