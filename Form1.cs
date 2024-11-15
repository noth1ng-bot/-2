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

        // ���������� ��� pictureBox1 (���� �� �����������)
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� �� �������� 1!");
        }

        // ���������� ��� ��������� ������� � tabControl1
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"������� �������: {tabControl1.SelectedTab.Text}");
        }

        // ���������� ��� ������ "���������" �� ������ �������
        private void buttonCalculateLinear_Click(object sender, EventArgs e)
        {
            try
            {
                // ��������� �������� �� ��������� �����
                double x = double.Parse(textBoxXLinear.Text);
                double y = double.Parse(textBoxYLinear.Text);
                double z = double.Parse(textBoxZLinear.Text);

                // ������ �������� ���������� (�� ������ �������� �� ���� �������)
                double result = x + y + z;
                textBoxLinearResult.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("������! ������� ���������� �������� ��������.");
            }
        }

        // ���������� ��� ������ "���������" �� ������ �������
        private void buttonCalculateBranch_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(textBoxXBranch.Text);
                double y = double.Parse(textBoxYBranch.Text);
                double result = 0;

                // ���������� ��������� ������� �� comboBox
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
                        MessageBox.Show("����������, �������� �������.");
                        return;
                }

                textBoxBranchResult.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("������! ������� ���������� �������� ��������.");
            }
        }

        // ���������� ��� ��������� ���������� �������� � comboBox
        private void comboBoxFunction_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"�� ������� �������: {comboBoxFunction.SelectedItem}");
        }
    }
}


