using System;
using System.Windows.Forms;

namespace Domashka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Обработчик для pictureBox1 (клик по изображению)
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Клик по картинке 1!");
        }

        // Обработчик для изменения вкладки в tabControl1
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"Выбрана вкладка: {tabControl1.SelectedTab.Text}");
        }

        // Обработчик для кнопки "Вычеслить" на первой вкладке
        private void buttonCalculateLinear_Click(object sender, EventArgs e)
        {
            try
            {
                // Получение значений из текстовых полей
                double x = double.Parse(textBoxXLinear.Text);
                double y = double.Parse(textBoxYLinear.Text);
                double z = double.Parse(textBoxZLinear.Text);

                // Пример простого вычисления (вы можете заменить на свои формулы)
                double result = x + y + z;
                textBoxLinearResult.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка! Введите корректные числовые значения.");
            }
        }

        // Обработчик для кнопки "Вычеслить" на второй вкладке
        private void buttonCalculateBranch_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(textBoxXBranch.Text);
                double y = double.Parse(textBoxYBranch.Text);
                double result = 0;

                // Выполнение выбранной функции из comboBox
                switch (comboBoxFunction.SelectedItem.ToString())
                {
                    case "cos(x)":
                        result = Math.Cos(x);
                        break;
                    case "x^2":
                        result = Math.Pow(x, 2);
                        break;
                    case "e^x":
                        result = Math.Exp(x);
                        break;
                    default:
                        MessageBox.Show("Пожалуйста, выберите функцию.");
                        return;
                }

                textBoxBranchResult.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка! Введите корректные числовые значения.");
            }
        }

        // Обработчик для изменения выбранного элемента в comboBox
        private void comboBoxFunction_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"Вы выбрали функцию: {comboBoxFunction.SelectedItem}");
        }
    }
}


