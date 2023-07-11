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
    public partial class Form1 : Form
    {

        // list to hold all of the todos
       static List<String> names = new List<string>();

        // BindingSource to connect list items in textbox2 to the listbox in form1
        BindingSource todosBindingSource = new BindingSource();


        internal void receiveData(string newtodo)
        {
            names.Add(newtodo); // newtodo base on the parameter in this method

            MessageBox.Show("you have " + names.Count + " todos left in the list.");
        }


        public Form1()
        {
            InitializeComponent();

            // adding todos in the list of todos

            //names.Add("first todo");
            //names.Add("second todo");
            //names.Add("third todo");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com");
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            // let the dataSource be comming from names
            todosBindingSource.DataSource = names;

            // item that should be in listbox should come from todoBindingSource
            listBox1.DataSource = todosBindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Check = new Form2();
            Check.Show();
            this.Hide();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            // actions occur when this form regains focus. when it is displayed in front

            todosBindingSource.ResetBindings(false);
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // this code is responsible for the sorting of the todos

            if (comboBox1.SelectedItem == "A - Z")
            {
                names.Sort();
             
            }
            else
            {
                names.Sort();
                names.Reverse();
            }
            todosBindingSource.ResetBindings(false);
        }


        private void listBox1_Click(object sender, EventArgs e) // when clicked on an item in the listbox
        {

            int i = listBox1.SelectedIndex;
         
            if (i >= 0)
            {
                DialogResult result = MessageBox.Show("would you like to delete todo " + names[i] + " ", "comfirm", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    names.RemoveAt(i);
                    todosBindingSource.ResetBindings(false);

                    MessageBox.Show("you have " + names.Count + " todos left in the list."); // display todos left
                }
            }

        }
    }
}
