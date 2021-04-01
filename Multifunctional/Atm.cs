using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multifunctional
{
    public partial class Atm : Form
    {
        ReaderWriter rw = new ReaderWriter();
        double myMoney = 0;
        public Atm()
        {
            InitializeComponent();
            rw.Check(label9, label2, label3);
            //rw.MoneyReader(ref myMoney, label2, label9);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult lement = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (lement == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                //stay here..
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nameAcc = "";
            string passAcc = "";
            double amount = 0;

            if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "")
            {
                label8.Text = "Please fill the form to complete the deposit";
            }
            else
            {
                rw.atm(nameAcc, passAcc, amount, textBox1, textBox2, textBox4, label8);
                textBox1.Text = textBox2.Text = textBox4.Text = "";
                rw.Check(label9, label2, label3);
            }      
        }

    }
}
