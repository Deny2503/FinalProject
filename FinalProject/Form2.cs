using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form2 : Form
    {
        public Font SelectedFont { get; private set; }
        public Color SelectedColor { get; private set; }
        public string EditedText { get; private set; }

        public Form2(Font currentFont, Color currentColor, string text)
        {
            InitializeComponent();

            SelectedFont = currentFont;
            SelectedColor = currentColor;
            EditedText = text;

            if (comboBoxFont != null)
            {
                foreach (FontFamily font in FontFamily.Families)
                {
                    comboBoxFont.Items.Add(font.Name);
                }
                comboBoxFont.SelectedItem = currentFont.FontFamily.Name;
            }

            comboBoxFont.SelectedItem = currentFont.FontFamily.Name;
            numericUpDownFontSize.Value = (decimal)currentFont.Size;
            trackBarRed.Value = currentColor.R;
            trackBarGreen.Value = currentColor.G;
            trackBarBlue.Value = currentColor.B;

            richTextBoxPreview.Font = SelectedFont;
            richTextBoxPreview.ForeColor = SelectedColor;
            richTextBoxPreview.Text = EditedText;


            SelectedFont = currentFont;
            SelectedColor = currentColor;

            UpdatePreview();
        }

        private void trackBarColor_Scroll(object sender, EventArgs e)
        {
            SelectedColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
            UpdatePreview();
        }

        private void comboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFont?.SelectedItem != null)
            {
                SelectedFont = new Font(comboBoxFont.SelectedItem.ToString(), SelectedFont.Size);
                UpdatePreview();
            }
        }

        private void numericUpDownFontSize_ValueChanged(object sender, EventArgs e)
        {
            SelectedFont = new Font(SelectedFont.FontFamily, (float)numericUpDownFontSize.Value);
            UpdatePreview();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void richTextBoxPreview_TextChanged(object sender, EventArgs e)
        {
            EditedText = richTextBoxPreview.Text;
        }

        private void UpdatePreview()
        {
            richTextBoxPreview.Font = SelectedFont;
            richTextBoxPreview.ForeColor = SelectedColor;
        }
    }
}
