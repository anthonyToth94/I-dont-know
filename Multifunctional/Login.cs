using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multifunctional
{
    public partial class Login : Form
    {   
        public Login()
        {
            InitializeComponent();
        }
      
        private void button4_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show(); 
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string pass = textBox2.Text;
            // textBox1.Text textBox2.Text label8.Text;
            if (textBox1.Text == "" || textBox2.Text == "") 
            {
                label8.Location = new Point(395, 400);
                label8.Text = "Please fill the form";
            }
            else
            {
                ReaderWriter rw = new ReaderWriter();
                rw.SelectRegister(name, pass, label8, Form.ActiveForm);
            }

        }
    }
}
