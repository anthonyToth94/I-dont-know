using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multifunctional
{
    class Scrissor
    {
        private string name;
        private bool stone = false;
        private bool paper = false;
        private bool scrissors = false;
        private int playerValue;
        private byte win;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public byte Win
        {
            get { return win; }
        }
        public bool Stone
        {
            get { return stone; }
        }

        public bool Paper
        {
            get { return paper; }
        }
        public bool Scrissors
        {
            get { return scrissors; }
        }
        public int PlayerValue
        {
            get { return this.playerValue; }

            set { 
                playerValue = value;
                    switch (playerValue)
                    {
                      case 0: this.stone = true; break;
                      case 1: this.paper = true; break;
                      case 2: this.scrissors = true; break;
                    }
                }     
        }
        public Scrissor()
        {
           
        }
        public Scrissor(Random random)
        {
            random = new Random();
            this.playerValue = random.Next(0, 3);
            switch (playerValue)
            {
                case 0: this.stone = true; break;
                case 1: this.paper = true; break;
                case 2: this.scrissors = true; break;
            }
        } 
        public void Winner(Scrissor s2, System.Windows.Forms.Label label, System.Windows.Forms.Label label1, System.Windows.Forms.Label label3, System.Windows.Forms.Label label4, System.Windows.Forms.Label label7, System.Windows.Forms.Label label6, System.Windows.Forms.Label label5)
        {
            //( 0 ) Stone < Paper enemy
            if(this.Stone == true && s2.Paper == true)
            {
                label.Text = s2.Name;
                label6.Text = "1";
                win = 2;
            }
            // Stone > Scrissors en
            else if(this.Stone == true && s2.Scrissors == true)
            {
                label.Text = this.Name;
                label5.Text = "1";
                win = 1;
            }
            // Stone == Stone x
            else if(this.Stone == true && s2.Stone == true)
            {
                label.Text = "Draw";
                label5.Text = "0";
                label6.Text = "0";
                win = 0;

            }

            //( 1 ) Paper < Scrissors enemy
            else if(this.Paper == true && s2.Scrissors == true)
            {
                label.Text = s2.Name;
                label6.Text = "1";
                win = 2;
            }
            // Paper > Stone en
            else if (this.Paper == true && s2.Stone == true)
            {
                label.Text = this.Name;
                label5.Text = "1";
                win = 1;
            }
            // Paper == Paper x
            else if(this.Paper == true && s2.Paper == true)
            {
                label.Text = "Draw";
                label5.Text = "0";
                label6.Text = "0";
                win = 0;
            }

            //( 2 ) Scrissors < Stone enemy
            else if (this.Scrissors == true && s2.Stone == true)
            {
                label.Text = s2.Name;
                label6.Text = "1";
                win = 2;
            }
            // Scrissors > Paper en
            else if (this.Scrissors == true && s2.Paper == true)
            {
                label.Text = this.Name;
                label5.Text = "1";
                win = 1;
            }
            // Scrissors == Scrissors x
            else 
            {
                label.Text = "Draw";
                label5.Text = "0";
                label6.Text = "0";
                win = 0;
            }       
          
        }
   
    }
}
