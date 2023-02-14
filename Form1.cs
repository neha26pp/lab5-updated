using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5_updated
{
    public partial class Form1 : Form
    {
        Factory factory;
        //private ListBox modulesListBox;

        public Form1()
        {
            InitializeComponent();
           

            string filePath = "C:/Users/NEHA/PENN STATE/spring2023/sweng421 - software architecture/labs/lab5-updated/modules.txt";
            //Create an object of FileInfo for specified path  
            factory = new Factory(filePath, listBox1);
                      


        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        //when user double clicks on the listbox fields, the factory will create the appropriate object

        private void listBox1_DoubleClick_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                //call factory's method that will create the specific module based on selection 
                factory.createModule(listBox1.SelectedItem.ToString());
                label1.Text = "Computed Result = " + Math.Round(Module.getCurrentvalue(), 3).ToString();


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
