using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue
{
    public partial class Form1 : Form
    {
        Queue<string> queue;


        public Form1()
        {
            queue = new Queue<string>();

            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {

            queue.Enqueue(textBox1.Text);
            label3.Text = (queue.Count()).ToString();
            textBox2.Text += ((textBox1.Text).ToString() + ", ");
        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (queue.Count == 0)
            {
                MessageBox.Show(" В очереди не осталось элементов");
            }
            else
            {
                
                queue.Dequeue();
                label3.Text = (queue.Count()).ToString();

                textBox2.Text = "";

                foreach (string item in queue)
                    textBox2.Text += item + ", ";

            }

          /*  char[] qArr;

            string qText = (textBox2.Text).ToString();

            int comma = qText.IndexOf(',')+1;

            qArr = qText.ToCharArray();

            char[] newqArr = new char[100];

            int q = 0;

            int s = qText.Length - comma;

            for ( int i = comma ;  i < s; i++)
            {

                newqArr[q] = qArr[i];
                q++;
            }

            qText = newqArr.ToString();

            textBox2.Text = ((qText).ToString());
          */


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            queue.Clear();
            textBox2.Text = "";
            label3.Text = (queue.Count()).ToString();
        }
    }
}
