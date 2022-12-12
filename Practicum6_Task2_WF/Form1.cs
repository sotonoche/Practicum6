using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicum6_Task2_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetRes_Click(object sender, EventArgs e)
        {
            string[] arr_str = textBoxArea.Text.Split(' ');
            int size = arr_str.Length;
            double[] arr = new double[size];

            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = double.Parse(arr_str[i]);
                }
            }
            catch
            {
                MessageBox.Show("Ожидается ввод чисел!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int max_index = 0;
            double max = arr[0];
            foreach (double num in arr)
            {
                if (num > max) max = num;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == max) max_index = i;
            }

            double temp = arr[max_index];
            arr[max_index] = arr[0];
            arr[0] = temp;

            richTextBoxRes.Text = $"Массив с измененным первым и максимальным элементами: \n";

            for (int i = 0; i < arr.Length; i++)
            {
                richTextBoxRes.Text += $"[{arr[i]}] ";
            }
        }
    }
}
