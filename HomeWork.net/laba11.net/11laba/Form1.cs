using System;
using System.Windows.Forms;

namespace _11laba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.AddRange(new string[] { "https://www.example.com", "https://www.example.org", "https://www.example.net" });

            textBox1.Text = "https://www.example.com";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSite = comboBox1.SelectedItem.ToString();
            webBrowser1.Navigate(selectedSite);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(webBrowser1.Url.AbsoluteUri))
            {
                webBrowser1.ShowSaveAsDialog();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

    }
}
