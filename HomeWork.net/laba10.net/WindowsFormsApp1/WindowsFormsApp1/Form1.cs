using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeListBox();
        }

        private void InitializeListBox()
        {
            // Додаємо декілька елементів до списку при його ініціалізації
            listBox1.Items.Add("Елемент 1");
            listBox1.Items.Add("Елемент 2");
            listBox1.Items.Add("Елемент 3");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Виводимо вибраний рядок зі списку в TextBox
            textBox2.Text = listBox1.SelectedItem.ToString();

            // Виводимо кількість рядків у списку
            MessageBox.Show($"Кількість рядків у списку: {listBox1.Items.Count}");

            // Виводимо тип виділеного елементу
            MessageBox.Show($"Тип виділеного елементу: {listBox1.SelectedItem.GetType()}");

            // Виводимо номер рядка, який розшукується (індекс + 1, бо нумерація з 0)
            MessageBox.Show($"Номер рядка: {listBox1.SelectedIndex + 1}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Вставляємо рядок з TextBox в список під заданим індексом
            int index = (int)numericUpDown1.Value;
            listBox1.Items.Insert(index, textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Видаляємо заданий рядок зі списку
            string itemToRemove = textBox2.Text;
            listBox1.Items.Remove(itemToRemove);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Видаляємо рядок із списку за заданим індексом
            int indexToRemove = (int)numericUpDown1.Value;
            if (indexToRemove >= 0 && indexToRemove < listBox1.Items.Count)
            {
                listBox1.Items.RemoveAt(indexToRemove);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Очищаємо весь список
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Перевіряємо наявність заданого рядка у списку
            string itemToCheck = textBox2.Text;
            bool exists = listBox1.Items.Contains(itemToCheck);
            MessageBox.Show(exists ? "Рядок знайдено в списку!" : "Рядок не знайдено в списку.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Отримуємо нове значення numericUpDown1
            int newIndex = (int)numericUpDown1.Value;

            // Виконуємо дії в залежності від нового значення
            // Наприклад, можна відобразити це значення у MessageBox
            MessageBox.Show($"Нове значення: {newIndex}");
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Отримуємо текст, який введено в textBox2
            string newText = textBox2.Text;

            // Тут ви можете виконати будь-які дії з новим текстом, які вам потрібно
        }


    }
}
