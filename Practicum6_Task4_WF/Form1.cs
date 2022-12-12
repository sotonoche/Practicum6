using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicum6_Task4_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size;
            string[] str_arr = textBoxArray.Text.Split(' ');
            string[] str_vector = textBoxVector.Text.Split(' ');
            //задаем размерность
            try
            {
                size = (int)numericUpDownSize.Value;
                if (size <= 0) throw new Exception("Размерность массива не может быть равна или меньше нуля!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //создаем ступенчатый массив
            int[][] arr = new int[size][];
            int iter = 0;
            for (int i = 0; i < size; ++i)//заполнение ступенчатого массива
            {
                arr[i] = new int[size];
                    try
                    {
                        for (int j = 0; j < size; ++j)
                        {
                            arr[i][j] = int.Parse(str_arr[iter]);
                            iter++;
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Введите корректное значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
            }
            //создаем массив вектора
            int[] vector = new int[size];//объявляем вектор
                try
                {
                    for (int i = 0; i < size; i++)
                    {
                        vector[i] = int.Parse(str_vector[i]);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Введите корректное значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            
            richTextBoxArea.Text = "Вывод исходного массива\n";
            richTextBoxArea.Text += "-------------------------------------------------\n";
            for (int i = 0; i < arr.Length; ++i, Console.WriteLine())//вывод ступенчатого массива
            {
                for (int j = 0; j < arr[i].Length; ++j)
                {
                    richTextBoxArea.Text += $"{arr[i][j]} ";
                }
                richTextBoxArea.Text += "\n";
            }


            richTextBoxArea.Text += "\nВывод массива вектора\n";
            richTextBoxArea.Text += "-------------------------------------------------\n";
            for (int i = 0; i < vector.Length; ++i)//вывод вектора
            {
                richTextBoxArea.Text += $"{vector[i]}\n";
            }


            //умножение массива на вектор
            int[] arr_out = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr_out[i] = 0;
                for (int j = 0; j < size; j++)
                {
                    arr_out[i] += arr[i][j] * vector[j];
                }

            }

            richTextBoxArea.Text += "\nВывод исходного массива\n";
            richTextBoxArea.Text += "-------------------------------------------------\n";
            for (int i = 0; i < size; ++i)//вывод результата умножения
            {
                richTextBoxArea.Text += $"{arr_out[i]}\n";
            }
        }
    }
}
