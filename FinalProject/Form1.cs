using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnSave, "Сохранить заметку");
            toolTip1.SetToolTip(btnLoad, "Загрузить заметку");
            toolTip1.SetToolTip(btnDelete, "Удалить заметку");
            toolTip1.SetToolTip(btnAddImage, "Добавить изображение");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxNotes.SelectedIndex != -1)
            {
                listBoxNotes.Items.RemoveAt(listBoxNotes.SelectedIndex);
                richTextBox1.Clear();
            }
        }

        private void listBoxNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxNotes.SelectedItem != null)
            {
                richTextBox1.Text = listBoxNotes.SelectedItem.ToString();
            }
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                listBoxNotes.Items.Add(richTextBox1.Text);
            }
        }

        private void btnSetReminder_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            timer1.Interval = (int)numericUpDown1.Value * 1000 / 10;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Напоминание: " + richTextBox1.Text, "Напоминание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Изображения|*.jpg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void comboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFont.SelectedItem != null)
            {
                richTextBox1.Font = new Font(comboBoxFont.SelectedItem.ToString(), richTextBox1.Font.Size);
            }
        }

        private void numericUpDownFontSize_ValueChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, (float)numericUpDownFontSize.Value);
        }

        private void trackBarTransparency_Scroll(object sender, EventArgs e)
        {
            this.Opacity = trackBarTransparency.Value / 100.0;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Простой менеджер заметок на WinForms", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                Clipboard.SetText(richTextBox1.SelectedText);
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.SelectedText != "")
            {
                Clipboard.SetText(richTextBox1.SelectedText);
                richTextBox1.SelectedText = "";
            }
        }
    }
}
