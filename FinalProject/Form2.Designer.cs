namespace FinalProject
{
    partial class Form2
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
            numericUpDownFontSize = new NumericUpDown();
            comboBoxFont = new ComboBox();
            trackBarRed = new TrackBar();
            trackBarGreen = new TrackBar();
            trackBarBlue = new TrackBar();
            btnApply = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            richTextBoxPreview = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFontSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownFontSize
            // 
            numericUpDownFontSize.Location = new Point(13, 46);
            numericUpDownFontSize.Maximum = new decimal(new int[] { 48, 0, 0, 0 });
            numericUpDownFontSize.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            numericUpDownFontSize.Name = "numericUpDownFontSize";
            numericUpDownFontSize.Size = new Size(150, 27);
            numericUpDownFontSize.TabIndex = 12;
            numericUpDownFontSize.Value = new decimal(new int[] { 8, 0, 0, 0 });
            numericUpDownFontSize.ValueChanged += numericUpDownFontSize_ValueChanged;
            // 
            // comboBoxFont
            // 
            comboBoxFont.DisplayMember = "5";
            comboBoxFont.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFont.FormattingEnabled = true;
            comboBoxFont.Location = new Point(12, 12);
            comboBoxFont.Name = "comboBoxFont";
            comboBoxFont.Size = new Size(151, 28);
            comboBoxFont.TabIndex = 11;
            comboBoxFont.SelectedIndexChanged += comboBoxFont_SelectedIndexChanged;
            // 
            // trackBarRed
            // 
            trackBarRed.Location = new Point(12, 79);
            trackBarRed.Maximum = 255;
            trackBarRed.Name = "trackBarRed";
            trackBarRed.Size = new Size(384, 56);
            trackBarRed.TabIndex = 13;
            trackBarRed.Value = 1;
            trackBarRed.Scroll += trackBarColor_Scroll;
            // 
            // trackBarGreen
            // 
            trackBarGreen.Location = new Point(13, 141);
            trackBarGreen.Maximum = 255;
            trackBarGreen.Name = "trackBarGreen";
            trackBarGreen.Size = new Size(383, 56);
            trackBarGreen.TabIndex = 14;
            trackBarGreen.Value = 1;
            trackBarGreen.Scroll += trackBarColor_Scroll;
            // 
            // trackBarBlue
            // 
            trackBarBlue.Location = new Point(13, 203);
            trackBarBlue.Maximum = 255;
            trackBarBlue.Name = "trackBarBlue";
            trackBarBlue.Size = new Size(383, 56);
            trackBarBlue.TabIndex = 15;
            trackBarBlue.Value = 1;
            trackBarBlue.Scroll += trackBarColor_Scroll;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(169, 12);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(94, 29);
            btnApply.TabIndex = 16;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(169, 44);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(402, 99);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 18;
            label1.Text = "R";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(402, 213);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 19;
            label2.Text = "B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(402, 153);
            label3.Name = "label3";
            label3.Size = new Size(19, 20);
            label3.TabIndex = 20;
            label3.Text = "G";
            // 
            // richTextBoxPreview
            // 
            richTextBoxPreview.Location = new Point(445, 13);
            richTextBoxPreview.Name = "richTextBoxPreview";
            richTextBoxPreview.Size = new Size(226, 220);
            richTextBoxPreview.TabIndex = 21;
            richTextBoxPreview.Text = "";
            richTextBoxPreview.TextChanged += richTextBoxPreview_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBoxPreview);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnApply);
            Controls.Add(trackBarBlue);
            Controls.Add(trackBarGreen);
            Controls.Add(trackBarRed);
            Controls.Add(numericUpDownFontSize);
            Controls.Add(comboBoxFont);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)numericUpDownFontSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownFontSize;
        private ComboBox comboBoxFont;
        private TrackBar trackBarRed;
        private TrackBar trackBarGreen;
        private TrackBar trackBarBlue;
        private Button btnApply;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private RichTextBox richTextBoxPreview;
    }
}