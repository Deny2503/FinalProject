namespace FinalProject
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            toolTip1 = new ToolTip(components);
            numericUpDown1 = new NumericUpDown();
            btnSave = new Button();
            btnDelete = new Button();
            btnSetReminder = new Button();
            btnAddNote = new Button();
            btnLoad = new Button();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            richTextBox1 = new RichTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            listBoxNotes = new ListBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            trackBarTransparency = new TrackBar();
            progressBar1 = new ProgressBar();
            btnAddImage = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            btnOpenEditor = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarTransparency).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(297, 211);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 7;
            toolTip1.SetToolTip(numericUpDown1, "Время через которое напомнить");
            // 
            // btnSave
            // 
            btnSave.Location = new Point(177, 40);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(177, 110);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSetReminder
            // 
            btnSetReminder.Location = new Point(177, 209);
            btnSetReminder.Name = "btnSetReminder";
            btnSetReminder.Size = new Size(114, 29);
            btnSetReminder.TabIndex = 2;
            btnSetReminder.Text = "Set Reminder";
            btnSetReminder.UseVisualStyleBackColor = true;
            btnSetReminder.Click += btnSetReminder_Click;
            // 
            // btnAddNote
            // 
            btnAddNote.Location = new Point(177, 145);
            btnAddNote.Name = "btnAddNote";
            btnAddNote.Size = new Size(94, 29);
            btnAddNote.TabIndex = 4;
            btnAddNote.Text = "Add Note";
            btnAddNote.UseVisualStyleBackColor = true;
            btnAddNote.Click += btnAddNote_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(177, 75);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            richTextBox1.ContextMenuStrip = contextMenuStrip1;
            richTextBox1.Location = new Point(12, 40);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(159, 198);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { copyToolStripMenuItem, pasteToolStripMenuItem, cutToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(113, 76);
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(112, 24);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(112, 24);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(112, 24);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // listBoxNotes
            // 
            listBoxNotes.FormattingEnabled = true;
            listBoxNotes.Location = new Point(297, 40);
            listBoxNotes.Name = "listBoxNotes";
            listBoxNotes.Size = new Size(408, 164);
            listBoxNotes.TabIndex = 6;
            listBoxNotes.SelectedIndexChanged += listBoxNotes_SelectedIndexChanged;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 244);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(279, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // trackBarTransparency
            // 
            trackBarTransparency.Location = new Point(297, 244);
            trackBarTransparency.Maximum = 100;
            trackBarTransparency.Name = "trackBarTransparency";
            trackBarTransparency.Size = new Size(149, 56);
            trackBarTransparency.TabIndex = 11;
            trackBarTransparency.TickFrequency = 10;
            trackBarTransparency.Scroll += trackBarTransparency_Scroll;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(453, 209);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(252, 29);
            progressBar1.TabIndex = 12;
            // 
            // btnAddImage
            // 
            btnAddImage.Location = new Point(12, 383);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Size = new Size(94, 29);
            btnAddImage.TabIndex = 13;
            btnAddImage.Text = "Add Image";
            btnAddImage.UseVisualStyleBackColor = true;
            btnAddImage.Click += btnAddImage_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, infoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(116, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(49, 24);
            infoToolStripMenuItem.Text = "Info";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(194, 26);
            aboutToolStripMenuItem.Text = "About Program";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // btnOpenEditor
            // 
            btnOpenEditor.Location = new Point(177, 180);
            btnOpenEditor.Name = "btnOpenEditor";
            btnOpenEditor.Size = new Size(114, 29);
            btnOpenEditor.TabIndex = 15;
            btnOpenEditor.Text = "Open Editor";
            btnOpenEditor.UseVisualStyleBackColor = true;
            btnOpenEditor.Click += btnOpenEditor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOpenEditor);
            Controls.Add(btnAddImage);
            Controls.Add(progressBar1);
            Controls.Add(trackBarTransparency);
            Controls.Add(pictureBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(listBoxNotes);
            Controls.Add(richTextBox1);
            Controls.Add(btnAddNote);
            Controls.Add(btnLoad);
            Controls.Add(btnSetReminder);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarTransparency).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip toolTip1;
        private Button btnSave;
        private Button btnDelete;
        private Button btnSetReminder;
        private Button btnAddNote;
        private Button btnLoad;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private RichTextBox richTextBox1;
        private ListBox listBoxNotes;
        private System.Windows.Forms.Timer timer1;
        private NumericUpDown numericUpDown1;
        private PictureBox pictureBox1;
        private TrackBar trackBarTransparency;
        private ProgressBar progressBar1;
        private Button btnAddImage;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private Button btnOpenEditor;
    }
}
