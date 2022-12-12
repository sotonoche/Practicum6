using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicum6_Task1_2arr_WF
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
                y_size = (int)numericUpDownY.Value;
                n = (int)numericUpDown1.Value;
                if (x_size <= 0 || y_size <= 0) throw new Exception("Размерность массива не может быть равна или меньше нуля!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            int[,] arr = new int[x_size, y_size];
            string[] strs = textBox1.Text.Split(',');

            try
            {
                int iter = 0;
                for (int i = 0; i < x_size; i++)
                {
                    for (int j = 0; j < y_size; j++)
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

            for (int i = 0; i < x_size; i++)
            {
                for (int j = 0; j < y_size; j++)
                {
                    if (arr[i, j] < n) arr[i, j] *= 2;
                }
            }

            richTextBox1.Text = $"Все элементы массива, которые меньше числа {n} увеличены в два раза: \n";

            for (int i = 0; i < x_size; i++)
            {
                for (int j = 0; j < y_size; j++)
                {
                    richTextBox1.Text += $"[{arr[i, j]}]";
                }
                richTextBox1.Text += "\n";
            }
        }
    }
}
