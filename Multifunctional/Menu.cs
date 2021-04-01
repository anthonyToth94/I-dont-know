using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multifunctional
{
    public partial class Menu : Form
    {
        //string nevem = "";
        //double myMoney = 0;
        ReaderWriter rw = new ReaderWriter();
        
        public Menu()
        {
            InitializeComponent();
            //Starting data load to here
            //rw.SelectMenu(label1, label2, label3);
            // rw.MoneyReader(ref myMoney, label2, label3);
            rw.Check(label3,label2,label1); 
            rw.CheckButton(button2,button1,button3);  
        }

        private void button4_Click(object sender, EventArgs e)
        {
           DialogResult lement = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(lement == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                //stay here..
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
              Atm atm = new Atm();
              atm.Show();
              this.Hide();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Games g = new Games();
            g.Show();
            this.Hide();
        }

    }
}
