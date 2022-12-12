using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practicum6_Task3_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x_size, y_size, n;

            try
            {
                x_size = (int)numericUpDownX.Value;
                if (x_size <= 0) throw new Exception("Размерность массива не может быть равна или меньше нуля!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int[,] arr = new int[x_size, x_size];
            string[] strs = textBox1.Text.Split(' ');

            try
            {
                int iter = 0;
                for (int i = 0; i < x_size; i++)
                {
                    for (int j = 0; j < x_size; j++)
                    {
                        arr[i, j] = int.Parse(strs[iter]);
                        iter++;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ожидается ввод целых чисел элементов массива и числа для проверки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double sum = .0;
            double count = .0;
            for (int i = 1; i < x_size; i++)
            {
                for (int j = 0; j < x_size; j++)
                {
                    if (i + j >= x_size)
                    {
                        sum += arr[i, j];
                        count++;
                    }
                }
            }

            richTextBox1.Text = "Исходный массив:\n";

            for (int i = 0; i < x_size; i++)
            {
                for (int j = 0; j < x_size; j++)
                {
                    richTextBox1.Text += $"[{arr[i, j]}]";
                }
                richTextBox1.Text += "\n";
            }
            richTextBox1.Text += $"Средее арифметическое элементов под побочной диагональю равно {sum / count}";
        }
    }
}
