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
    public partial class Scrissors : Form
    {
        Random random = new Random();
        public Scrissors()
        {
            InitializeComponent();
            ReaderWriter rw = new ReaderWriter();
            rw.Check(label12, label10, label11);
          
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Games g = new Games();
            g.Show();
            this.Hide();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Scrissor me = new Scrissor();
            me.PlayerValue = 0;
            me.Name = label12.Text;
            label3.Text = me.Name;

            Scrissor enemy = new Scrissor(random);
            enemy.Name = "Enemy";
            me.Winner(enemy, label8, label9, label3, label4, label7, label6, label5);
            timer1.Start();
            button4.Enabled = false;
            label2.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel1.Enabled = false;
            panel2.Enabled = false;
            panel3.Enabled = false;
            label13.Visible = true;
            timer2.Start();
            ChoosedBackground(me, enemy);
            ReaderWriter rw2 = new ReaderWriter();
            rw2.LoseOrWin(me);
            if(me.Win == 1)
            {
                label14.Text = "100";
                label16.Text = "win:";
            }
            
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Scrissor me = new Scrissor();
            me.PlayerValue = 1;
            me.Name = label12.Text;
            label3.Text = me.Name;

            Scrissor enemy = new Scrissor(random);
            enemy.Name = "Enemy";
            me.Winner(enemy, label8, label9, label3, label4, label7,label6, label5);
            timer1.Start();
            button4.Enabled = false;
            label2.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel1.Enabled = false;
            panel2.Enabled = false;
            panel3.Enabled = false;
            label13.Visible = true;
            timer2.Start();
            ChoosedBackground(me, enemy);
            ReaderWriter rw2 = new ReaderWriter();
            rw2.LoseOrWin(me);
            if (me.Win == 1)
            {
                label14.Text = "100";
                label16.Text = "win:";
            }
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Scrissor me = new Scrissor();
            me.PlayerValue = 2;
            me.Name = label12.Text;
            label3.Text = me.Name;

            Scrissor enemy = new Scrissor(random);
            enemy.Name = "Enemy";
            me.Winner(enemy, label8, label9, label3, label4, label7, label6, label5);
            timer1.Start();
            button4.Enabled = false;
            label2.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel1.Enabled = false;
            panel2.Enabled = false;
            panel3.Enabled = false;
            label13.Visible = true;
            timer2.Start();
            ChoosedBackground(me, enemy);
            ReaderWriter rw2 = new ReaderWriter();
            rw2.LoseOrWin(me);
            if (me.Win == 1)
            {
                label14.Text = "100";
                label16.Text = "win:";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                timer1.Stop();
                button4.Enabled = true;

                label8.Visible = true;
                label9.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label7.Visible = true;
                panel4.Visible = true;
                panel5.Visible = true;
                panel1.Enabled = true;
                    panel2.Enabled = true;
                    panel3.Enabled = true;
            button1.Visible = true;
            label15.Visible = true;
            label17.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;

            label16.Visible = true;
            label14.Visible = true;
        }
        int i = 5;
        private void timer2_Tick(object sender, EventArgs e)
        {
            i--;
            label13.Text = i.ToString();
            if(label13.Text == "0")
            {
                label13.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReaderWriter rw = new ReaderWriter();
            if (rw.CheckBalance() >= 50)
            {
                rw.ScrissorsBalance();
                Scrissors sc = new Scrissors();
                sc.Show();
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
        private void ChoosedBackground(Scrissor en, Scrissor enemy)
        {
            //mine
            if(en.PlayerValue == 0)
            {
                panel4.BackgroundImage = Image.FromFile(@"C:\Users\Anti\source\repos\Multifunctional\stone.png");
            }
            else if(en.PlayerValue == 1)
            {
                panel4.BackgroundImage = Image.FromFile(@"C:\Users\Anti\source\repos\Multifunctional\papir.png");
            }
            else
            {
                panel4.BackgroundImage = Image.FromFile(@"C:\Users\Anti\source\repos\Multifunctional\logo.png");
            }
            //enemy
            if (enemy.PlayerValue == 0)
            {
                panel5.BackgroundImage = Image.FromFile(@"C:\Users\Anti\source\repos\Multifunctional\stone.png");
            }
            else if (enemy.PlayerValue == 1)
            {
                panel5.BackgroundImage = Image.FromFile(@"C:\Users\Anti\source\repos\Multifunctional\papir.png");
            }
            else
            {
                panel5.BackgroundImage = Image.FromFile(@"C:\Users\Anti\source\repos\Multifunctional\logo.png");
            }
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.Location = new Point(201, 240);
            panel1.Size = new Size(129, 108);     
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.Location = new Point(206, 243);
            panel1.Size = new Size(105, 96);
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.Location = new Point(433, 237);
            panel2.Size = new Size(161, 111);
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.Location = new Point(438, 240);
            panel2.Size = new Size(142, 99);
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            panel3.Location = new Point(689, 237);
            panel3.Size = new Size(167, 111);
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.Location = new Point(694, 240);
            panel3.Size = new Size(148, 99);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
