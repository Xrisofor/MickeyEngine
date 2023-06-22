namespace Editor.App.Forms
{
    partial class SpriteManager
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
            ObjectsListView = new ListView();
            SpritesList = new System.Windows.Forms.ImageList(components);
            AddImgButton = new Button();
            RemoveImgButton = new Button();
            ReloadImgButton = new Button();
            textBox1 = new TextBox();
            SelectImageFile = new OpenFileDialog();
            OtherList = new System.Windows.Forms.ImageList(components);
            SelectAudioFile = new OpenFileDialog();
            SelectFontFile = new OpenFileDialog();
            SuspendLayout();
            // 
            // ObjectsListView
            // 
            ObjectsListView.Activation = ItemActivation.TwoClick;
            ObjectsListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ObjectsListView.BackColor = Color.FromArgb(33, 37, 41);
            ObjectsListView.BorderStyle = BorderStyle.FixedSingle;
            ObjectsListView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ObjectsListView.ForeColor = Color.White;
            ObjectsListView.LargeImageList = SpritesList;
            ObjectsListView.Location = new Point(12, 40);
            ObjectsListView.MultiSelect = false;
            ObjectsListView.Name = "ObjectsListView";
            ObjectsListView.Size = new Size(965, 635);
            ObjectsListView.TabIndex = 0;
            ObjectsListView.UseCompatibleStateImageBehavior = false;
            ObjectsListView.ItemActivate += listView1_ItemActivate;
            ObjectsListView.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // SpritesList
            // 
            SpritesList.ColorDepth = ColorDepth.Depth32Bit;
            SpritesList.ImageSize = new Size(185, 185);
            SpritesList.TransparentColor = Color.Transparent;
            // 
            // AddImgButton
            // 
            AddImgButton.BackColor = Color.FromArgb(33, 37, 41);
            AddImgButton.FlatStyle = FlatStyle.Flat;
            AddImgButton.ForeColor = Color.White;
            AddImgButton.Location = new Point(12, 5);
            AddImgButton.Name = "AddImgButton";
            AddImgButton.Size = new Size(155, 29);
            AddImgButton.TabIndex = 1;
            AddImgButton.Text = "Add";
            AddImgButton.UseVisualStyleBackColor = false;
            AddImgButton.Click += AddImgButton_Click;
            // 
            // RemoveImgButton
            // 
            RemoveImgButton.BackColor = Color.FromArgb(33, 37, 41);
            RemoveImgButton.FlatStyle = FlatStyle.Flat;
            RemoveImgButton.ForeColor = Color.White;
            RemoveImgButton.Location = new Point(173, 5);
            RemoveImgButton.Name = "RemoveImgButton";
            RemoveImgButton.Size = new Size(155, 29);
            RemoveImgButton.TabIndex = 2;
            RemoveImgButton.Text = "Remove";
            RemoveImgButton.UseVisualStyleBackColor = false;
            RemoveImgButton.Click += RemoveImgButton_Click;
            // 
            // ReloadImgButton
            // 
            ReloadImgButton.BackColor = Color.FromArgb(33, 37, 41);
            ReloadImgButton.FlatStyle = FlatStyle.Flat;
            ReloadImgButton.ForeColor = Color.White;
            ReloadImgButton.Location = new Point(334, 5);
            ReloadImgButton.Name = "ReloadImgButton";
            ReloadImgButton.Size = new Size(155, 29);
            ReloadImgButton.TabIndex = 3;
            ReloadImgButton.Text = "Reload";
            ReloadImgButton.UseVisualStyleBackColor = false;
            ReloadImgButton.Click += ReloadImgButton_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.BackColor = Color.FromArgb(33, 37, 41);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(495, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(482, 27);
            textBox1.TabIndex = 4;
            // 
            // SelectImageFile
            // 
            SelectImageFile.Filter = "Images|*.png;*.jpg;*.gif";
            // 
            // OtherList
            // 
            OtherList.ColorDepth = ColorDepth.Depth32Bit;
            OtherList.ImageSize = new Size(185, 185);
            OtherList.TransparentColor = Color.Transparent;
            // 
            // SelectAudioFile
            // 
            SelectAudioFile.Filter = "Audio|*.wav; *.ogg";
            // 
            // SelectFontFile
            // 
            SelectFontFile.Filter = "Font|*.ttf";
            // 
            // SpriteManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 58, 64);
            ClientSize = new Size(989, 687);
            Controls.Add(textBox1);
            Controls.Add(ReloadImgButton);
            Controls.Add(RemoveImgButton);
            Controls.Add(AddImgButton);
            Controls.Add(ObjectsListView);
            ForeColor = Color.White;
            Name = "SpriteManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sprite Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView ObjectsListView;
        private Button AddImgButton;
        private Button RemoveImgButton;
        private Button ReloadImgButton;
        private TextBox textBox1;
        private OpenFileDialog SelectImageFile;
        public System.Windows.Forms.ImageList SpritesList;
        private System.Windows.Forms.ImageList OtherList;
        private OpenFileDialog SelectAudioFile;
        private OpenFileDialog SelectFontFile;
    }
}