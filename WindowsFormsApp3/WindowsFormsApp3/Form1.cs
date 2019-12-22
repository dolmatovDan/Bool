using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        public void showNumbers(int[] numbers)
        {
            string name = "label";
            for (int i = 0; i < numbers.Length; i++)
            {
                Control ctn = this.Controls[name + (i + 1)];
                if (ctn != null)
                {
                    ctn.Text = numbers[i].ToString();
                }
            }

        }
        public int[] getNumbers()
        {
            string name = "label";
            int[] numbers = new int[4];

            for (int i = 0; i < numbers.Length; i++)
            {
                Control ctn = this.Controls[name + (i + 1)];
                if (ctn != null)
                {
                    numbers[i] = Convert.ToInt32(ctn.Text);
                }
            }
            return numbers;
        }
        public static int[] name(int[] arr)
        {
            Random random = new Random();
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = random.Next(0, 251);
                Console.WriteLine(arr[i]);
            }
            name(arr);
            Console.WriteLine("Правильный порядок");


            Console.ReadLine();
            return array;
        }
        public static int[] sort(int[] array)
        {
            string s = "";
            for (int z = 0; z < array.Length; z++)
            {
                for (int a = 0; a < array.Length - 1; a++)
                {
                    int b = array[a];
                    if (array[a] > array[a + 1])
                    {
                        int d = array[a];
                        array[a] = array[a + 1];
                        array[a + 1] = d;
                    }
                }
            }
            
            return array;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int[] numbs = new int[4];
            Random rnd = new Random();
            for (int b = 0; b < 4; b++)
            {
                numbs[b] = rnd.Next(0, 251);
            }
            this.showNumbers(numbs);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            showNumbers(sort(getNumbers()));
        }
    }
}

