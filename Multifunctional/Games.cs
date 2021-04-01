using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multifunctional
{
    public partial class Games : Form
    {
        public Games()
        {
            InitializeComponent();
            ReaderWriter rw = new ReaderWriter();
            rw.Check(label6, label10, label1);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            
           ReaderWriter rw = new ReaderWriter();
           if(rw.CheckBalance() >= 50)
            {
                rw.ScrissorsBalance();
                Scrissors sc = new Scrissors();
                sc.Show();
                this.Hide();
            }
            else
            {
                DialogResult save = MessageBox.Show("You dont have enought money.\nPlease go to the ATM and top up your money.\nDo you want to go now?","Balance problem",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (save == DialogResult.Yes)
                {
                    Atm atm = new Atm();
                    atm.Show();
                    this.Hide();
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.Location = new Point(101, 167);
            panel1.Size = new Size(230, 169);
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {

            panel1.Location = new Point(115, 177);
            panel1.Size = new Size(209, 152);
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.Location = new Point(393, 166);
            panel2.Size = new Size(233, 174);
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.Location = new Point(405, 177);
            panel2.Size = new Size(209, 152);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            ReaderWriter rw = new ReaderWriter();
            if (rw.CheckBalance() >= 100)
            {
                rw.TictacBalance();
                tictac tc = new tictac();
                tc.Show();
                this.Hide();
            }
            else
            {
                DialogResult save = MessageBox.Show("You dont have enought money.\nPlease go to the ATM and top up your money.\nDo you want to go now?", "Balance problem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (save == DialogResult.Yes)
                {
                    Atm atm = new Atm();
                    atm.Show();
                    this.Hide();
                }
            }
        }
    }
}
