using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace laba12
{
    public partial class Form1 : Form
    {
        private string currentFilePath = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void новийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearDocument();
        }

        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDocument();
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }

        private void зберегтиЯкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }

        private void ClearDocument()
        {
            textBox1.Clear();
            currentFilePath = "";
        }

        private void OpenDocument()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = openFileDialog.FileName;
                textBox1.Text = File.ReadAllText(currentFilePath);
            }
        }

        private void SaveDocument()
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, textBox1.Text);
                    currentFilePath = saveFileDialog.FileName;
                }
            }
            else
            {
                File.WriteAllText(currentFilePath, textBox1.Text);
            }
        }

        private void ExitApplication()
        {
            if (!string.IsNullOrEmpty(textBox1.Text) &&
                MessageBox.Show("Зберегти зміни перед виходом?", "Збереження", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SaveDocument();
            }
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClearDocument();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenDocument();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
