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
    public partial class tictac : Form
    {
        public int xORo = 0;
        public int turns = 0;
        Random random = new Random();

        public tictac()
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

         
          

            //if(Winner() == true)
            //{
            //    if(button.Text == "X")
            //    {
            //        label2.Visible = true;
            //        label2.Text = "WINNER";
            //        button1.Enabled = button2.Enabled = button3.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = false;
            //        button11.Visible = true;
            //        label17.Visible = true;
            //        label15.Visible = true;
            //        ReaderWriter rw = new ReaderWriter();
            //        rw.WinTicTac();
            //    }
            //    else
            //    {
            //        label2.Visible = true;
            //        label2.Text = "lOOSER";
            //        button1.Enabled = button2.Enabled = button3.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = false;
            //        button11.Visible = true;
            //    }
            //}
        
        private bool Draw()
        {
            if(turns == 9)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        private void Winner()
        {
            //horizontal
            if((button1.Text == button2.Text) && (button2.Text == button3.Text) && (button1.Text !="" || button2.Text != "" || button3.Text != "") && (button1.Text == "X"))
            {
                label2.Visible = true;
                label2.Text = "WINNER";
                button1.Enabled = button2.Enabled = button3.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = false;
                button11.Visible = true;
                label17.Visible = true;
                label15.Visible = true;
                ReaderWriter rw = new ReaderWriter();
                rw.WinTicTac();
            }
            else if((button5.Text == button6.Text) && (button6.Text == button7.Text) && (button5.Text != "" || button6.Text != "" || button7.Text != "") && (button5.Text == "X"))
            {
                label2.Visible = true;
                label2.Text = "WINNER";
                button1.Enabled = button2.Enabled = button3.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = false;
                button11.Visible = true;
                label17.Visible = true;
                label15.Visible = true;
                ReaderWriter rw = new ReaderWriter();
                rw.WinTicTac();
            }
            else if ((button8.Text == button9.Text) && (button9.Text == button10.Text) && (button8.Text != "" || button9.Text != "" || button10.Text != "") && (button8.Text == "X"))
            {
                label2.Visible = true;
                label2.Text = "WINNER";
                button1.Enabled = button2.Enabled = button3.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = false;
                button11.Visible = true;
                label17.Visible = true;
                label15.Visible = true;
                ReaderWriter rw = new ReaderWriter();
                rw.WinTicTac();
            }//vertical
            else if((button1.Text == button5.Text) && (button5.Text == button8.Text) && (button1.Text != "" || button5.Text != "" || button8.Text != "") && (button1.Text == "X"))
            {
                label2.Visible = true;
                label2.Text = "WINNER";
                button1.Enabled = button2.Enabled = button3.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = false;
                button11.Visible = true;
                label17.Visible = true;
                label15.Visible = true;
                ReaderWriter rw = new ReaderWriter();
                rw.WinTicTac();
            }
            else if ((button2.Text == button6.Text) && (button6.Text == button9.Text) && (button2.Text != "" || button6.Text != "" || button9.Text != "") && (button2.Text == "X"))
            {
                label2.Visible = true;
                label2.Text = "WINNER";
                button1.Enabled = button2.Enabled = button3.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = false;
                button11.Visible = true;
                label17.Visible = true;
                label15.Visible = true;
                ReaderWriter rw = new ReaderWriter();
                rw.WinTicTac();
            }
            else if ((button3.Text == button7.Text) && (button7.Text == button10.Text) && (button3.Text != "" || button7.Text != "" || button10.Text != "") && (button3.Text == "X"))
            {
                label2.Visible = true;
                label2.Text = "WINNER";
                button1.Enabled = button2.Enabled = button3.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = false;
                button11.Visible = true;
                label17.Visible = true;
                label15.Visible = true;
                ReaderWriter rw = new ReaderWriter();
                rw.WinTicTac();
            }//cross
            else if ((button1.Text == button6.Text) && (button6.Text == button10.Text) && (button1.Text != "" || button6.Text != "" || button10.Text != "") && (button1.Text == "X"))
            {
                label2.Visible = true;
                label2.Text = "WINNER";
                button1.Enabled = button2.Enabled = button3.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = false;
                button11.Visible = true;
                label17.Visible = true;
                label15.Visible = true;
                ReaderWriter rw = new ReaderWriter();
                rw.WinTicTac();
            }
            else if ((button8.Text == button6.Text) && (button6.Text == button3.Text) && (button8.Text != "" || button6.Text != "" || button3.Text != "") && (button8.Text == "X"))
            {
                label2.Visible = true;
                label2.Text = "WINNER";
                button1.Enabled = button2.Enabled = button3.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = false;
                button11.Visible = true;
                label17.Visible = true;
                label15.Visible = true;
                ReaderWriter rw = new ReaderWriter();
                rw.WinTicTac();
            }
            //Enemy
            else if ((button1.Text == button2.Text) && (button2.Text == button3.Text) && (button1.Text != "" || button2.Text != "" || button3.Text != "") && (button1.Text == "O"))
            {
                label2.Visible = true;
                label2.Text = "lOOSER";
                button1.Enabled = button2.Enabled = button3.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = false;
                button11.Visible = true;
            }
            else if ((button5.Text == button6.Text) && (button6.Text == button7.Text) && (button5.Text != "" || button6.Text != "" || button7.Text != "") && (button5.Text == "O"))
            {
                label2.Visible = true;
                label2.Text = "lOOSER";
                button1.Enabled = button2.Enabled = button3.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = false;
                button11.Visible = true;
            }
            else if ((button8.Text == button9.Text) && (button9.Text == button10.Text) && (button8.Text != "" || button9.Text != "" || button10.Text != "") && (button8.Text == "O"))
            {
                label2.Visible = true;
                label2.Text = "lOOSER";
                button1.Enabled = button2.Enabled = button3.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = false;
                button11.Visible = true;
            }//vertical
            else if ((button1.Text == button5.Text) && (button5.Text == button8.Text) && (button1.Text != "" || button5.Text != "" || button8.Text != "") && (button1.Text == "O"))
            {
                label2.Visible = true;
                label2.Text = "lOOSER";
                button1.Enabled = button2.Enabled = button3.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = false;
                button11.Visible = true;
            }
            else if ((button2.Text == button6.Text) && (button6.Text == button9.Text) && (button2.Text != "" || button6.Text != "" || button9.Text != "") && (button2.Text == "O"))
            {
                label2.Visible = true;
                label2.Text = "lOOSER";
                button1.Enabled = button2.Enabled = button3.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = false;
                button11.Visible = true;
            }
            else if ((button3.Text == button7.Text) && (button7.Text == button10.Text) && (button3.Text != "" || button7.Text != "" || button10.Text != "") && (button3.Text == "O"))
            {
                label2.Visible = true;
                label2.Text = "lOOSER";
                button1.Enabled = button2.Enabled = button3.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = false;
                button11.Visible = true;
            }//cross
            else if ((button1.Text == button6.Text) && (button6.Text == button10.Text) && (button1.Text != "" || button6.Text != "" || button10.Text != "") && (button1.Text == "O"))
            {
                label2.Visible = true;
                label2.Text = "lOOSER";
                button1.Enabled = button2.Enabled = button3.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = false;
                button11.Visible = true;
            }
            else if ((button8.Text == button6.Text) && (button6.Text == button3.Text) && (button8.Text != "" || button6.Text != "" || button3.Text != "") && (button8.Text == "O"))
            {
                label2.Visible = true;
                label2.Text = "lOOSER";
                button1.Enabled = button2.Enabled = button3.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = false;
                button11.Visible = true;
            }
            else
            {
               
            }



        }
      
        private void button11_Click(object sender, EventArgs e)
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

       private void PcChoose(int count)
        {
            while (count == 0)
            {
                byte pcNumber = (byte)random.Next(1, 10);
                switch (pcNumber)
                {
                    case 1: if (button1.Text == "") { button1.Text = button2.Text = "O"; xORo++; turns++; count++; } else { count = 0; } break;
                    case 2: if (button2.Text == "") { button2.Text = button2.Text = "O"; xORo++; turns++; count++; } else { count = 0; } break;
                    case 3: if (button3.Text == "") { button3.Text = button3.Text = "O"; xORo++; turns++; count++; } else { count = 0; } break;
                    case 4: if (button5.Text == "") { button5.Text = button5.Text = "O"; xORo++; turns++; count++; } else { count = 0; } break;
                    case 5: if (button6.Text == "") { button6.Text = button6.Text = "O"; xORo++; turns++; count++; } else { count = 0; } break;
                    case 6: if (button7.Text == "") { button7.Text = button7.Text = "O"; xORo++; turns++; count++; } else { count = 0; } break;
                    case 7: if (button8.Text == "") { button8.Text = button8.Text = "O"; xORo++; turns++; count++; } else { count = 0; } break;
                    case 8: if (button9.Text == "") { button9.Text = button9.Text = "O"; xORo++; turns++; count++; } else { count = 0; } break;
                    case 9: if (button10.Text == "") { button10.Text = button10.Text = "O"; xORo++; turns++; count++; } else { count = 0; } break;
                }
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (button1.Text == "")
            {
                button1.Text = "X";
                xORo++;
                turns++;
                PcChoose(count);
            }
            if (Draw() == true)
            {
                label2.Text = "Draw";
                label2.Visible = true;
                button11.Visible = true;
            };
            Winner();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (button2.Text == "")
            {
                button2.Text = "X";
                xORo++;
                turns++;
                PcChoose(count);
            }
            if (Draw() == true)
            {
                label2.Text = "Draw";
                label2.Visible = true;
                button11.Visible = true;
            };
            Winner();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (button3.Text == "")
            {
                button3.Text = "X";
                xORo++;
                turns++;
                PcChoose(count);
            }
            if (Draw() == true)
            {
                label2.Text = "Draw";
                label2.Visible = true;
                button11.Visible = true;
            };
            Winner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (button5.Text == "")
            {
                button5.Text = "X";
                xORo++;
                turns++;
                PcChoose(count);
            }
            if (Draw() == true)
            {
                label2.Text = "Draw";
                label2.Visible = true;
                button11.Visible = true;
            };
            Winner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (button6.Text == "")
            {
                button6.Text = "X";
                xORo++;
                turns++;
                PcChoose(count);
            }
            if (Draw() == true)
            {
                label2.Text = "Draw";
                label2.Visible = true;
                button11.Visible = true;
            };
            Winner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (button7.Text == "")
            {
                button7.Text = "X";
                xORo++;
                turns++;
                PcChoose(count);
            }
            if (Draw() == true)
            {
                label2.Text = "Draw";
                label2.Visible = true;
                button11.Visible = true;
            };
            Winner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (button8.Text == "")
            {
                button8.Text = "X";
                xORo++;
                turns++;
                PcChoose(count);
            }
            if (Draw() == true)
            {
                label2.Text = "Draw";
                label2.Visible = true;
                button11.Visible = true;
            };
            Winner();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (button9.Text == "")
            {
                button9.Text = "X";
                xORo++;
                turns++;
                PcChoose(count);
            }
            if (Draw() == true)
            {
                label2.Text = "Draw";
                label2.Visible = true;
                button11.Visible = true;
            };
            Winner();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (button10.Text == "")
            {
                button10.Text = "X";
                xORo++;
                turns++;
                PcChoose(count);
            }
            if (Draw() == true)
            {
                label2.Text = "Draw";
                label2.Visible = true;
                button11.Visible = true;
            };
            Winner();
        }
    }
}
