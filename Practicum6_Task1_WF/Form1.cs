using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicum6_Task1_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] strs = textBox2.Text.Split(',');
            int size = strs.Length;
            int checkNumber = (int)numericUpDown2.Value;
            int[] arr = new int[size];

            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(strs[i]);
                }
            }
            catch
            {
                MessageBox.Show("Ожидается ввод целых чисел элементов массива и числа для проверки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < checkNumber) arr[i] *= 2;
            }

            richTextBox1.Text = $"Все элементы массива, которые меньше числа {checkNumber} увеличены в два раза: ";

            for (int i = 0; i < arr.Length; i++)
            {
                richTextBox1.Text += $"[{arr[i]}] ";
            }
            

        }
    }
}

