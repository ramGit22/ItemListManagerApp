using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListManagerApp
{
    public partial class Form1 : Form
    {

        //list of names

        static List<String> names = new List<string>();
        BindingSource nameBindingSoure = new BindingSource();


        public Form1()      

        {
            InitializeComponent();
  
        }

        internal void receiveData(string newName)
        {
            names.Add(newName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //form 1 opens form 2 when Add button is clicked.
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nameBindingSoure.DataSource = names;
            listBox1.DataSource = nameBindingSoure;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            nameBindingSoure.ResetBindings(false);
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
         int i = listBox1.SelectedIndex;
            if (i>=0)
            {
                names.RemoveAt(i);
                nameBindingSoure.ResetBindings(false);
            }
    
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBox1.SelectedItem =="a->z")
            {
                names.Sort();
            }
            else
            {
                names.Sort();
                names.Reverse();
            }
            nameBindingSoure.ResetBindings(false);
        }
    }
}
