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
    public partial class Studen_window : Form
    {
        public Studen_window()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            var newsmenu_window = new Form1();
            newsmenu_window.Show();
            this.Close();
            back_button.Location = new Point(1000, 1000) ;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            groupBox1.Location = new Point(10, 10);
        }
    }
}
