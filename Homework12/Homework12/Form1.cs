using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Homework12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name=textBox1.Text;
            String lastName = textBox2.Text;
            String email = textBox3.Text;
            String allInfo=name+"*"+lastName+"*"+email;
            using(StreamWriter wr=new StreamWriter("Info.txt",true))
            {
                wr.WriteLine(allInfo);
            }
        }
    }
}
