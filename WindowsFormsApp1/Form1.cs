using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var newstudent_window = new Studen_window();
            newstudent_window.Show();
            this.Hide();
        }

        private void teacher_button_Click(object sender, EventArgs e)
        {

            var newsteacher_window = new Teacher_window();
            newsteacher_window.Show();
            this.Hide();
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            groupBox1.Location = new Point(10, 10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Time.Start();
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            Time.Start();
        }
    }
}
