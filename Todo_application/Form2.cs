using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo_application
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 show = new Form1();
            show.Show();
            this.Hide();

            show.receiveData(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Check = new Form1();
            Check.Show();
            this.Hide();
        }
    }
}
