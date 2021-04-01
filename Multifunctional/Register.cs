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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double money = 0;
            //radioButton1 ferf / radioButton2 no textbox1, textbox2
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label8.Location = new Point(395, 400);
                label8.Text = "Please fill the form";
            }
            else
            {
                label8.Location = new Point(450, 400);
                label8.Text = "Successful";
                ReaderWriter rw = new ReaderWriter();
                rw.Register(textBox1.Text, textBox2.Text);
                textBox1.Text = textBox2.Text = "";
            }
        }
    }
}
