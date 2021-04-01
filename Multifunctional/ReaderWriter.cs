using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multifunctional
{

    class ReaderWriter
    {

        List<Account> lista = new List<Account>();
        bool succesfull = false;
        string page = "";
        public static string onlineNow;
        public static double moneyMine;
        public static double passNow;
        //public void MoneyReader(ref double myMoney, System.Windows.Forms.Label label2, System.Windows.Forms.Label label5)
        //{
        //    FileStream fs = new FileStream(@"C:\Users\Anti\source\repos\Multifunctional\register.txt", FileMode.Open);
        //    StreamReader sr = new StreamReader(fs);
        //    string page = "";

        //    try
        //    {
        //        while (!sr.EndOfStream)
        //        {
        //            page = sr.ReadLine();
        //            string[] array = page.Split(':');


        //        }
        //    }
        //    catch(Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        sr.Close();
        //        fs.Close();
        //        label2.Text = myMoney.ToString() + " ft";
        //    }

        //}

        public void MoneyWriter(double amount)
        {
            //FileStream fs = new FileStream(@"C:\Users\Anti\source\repos\Multifunctional\register.txt", FileMode.Open);
            FileStream fs = new FileStream(@"C:\antiJatek\register.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string page = "";
            try
            {
                while (!sr.EndOfStream)
                {
                    page = sr.ReadLine();
                    string[] array = page.Split(':');
                    Account ac = new Account();
                    ac.Name = array[0];
                    ac.Password = array[1];
                    ac.Money = Convert.ToDouble(array[2]);
                    lista.Add(ac);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                sr.Close();
                fs.Close();
            }

            //FileStream fs2 = new FileStream(@"C:\Users\Anti\source\repos\Multifunctional\register.txt", FileMode.Create);
            FileStream fs2 = new FileStream(@"C:\antiJatek\register.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs2, Encoding.UTF8);
            try
            {
                for (int i = 0; i < lista.Count; i++)
                {

                    if (lista[i].Name == onlineNow)
                    {
                        sw.WriteLine($"{lista[i].Name}:{lista[i].Password}:{lista[i].Money = lista[i].Money + amount}");
                        moneyMine = lista[i].Money;
                    }
                    else
                    {
                        sw.WriteLine($"{lista[i].Name}:{lista[i].Password}:{lista[i].Money}");
                    }

                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                sw.Flush();
                sw.Close();
                fs2.Close();
            }

        }
        public void Register(string name, string password)
        {
            //FileStream fs = new FileStream(@"C:\Users\Anti\source\repos\Multifunctional\register.txt", FileMode.Append);
            FileStream fs = new FileStream(@"C:\antiJatek\register.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

            try
            {
                sw.WriteLine($"{name}:{password}:0");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                sw.Flush();
                sw.Close();
                fs.Close();
            }

        }
        public void SelectRegister(string name, string password, System.Windows.Forms.Label label, System.Windows.Forms.Form l)
        {
            try
            {
                //FileStream fs = new FileStream(@"C:\Users\Anti\source\repos\Multifunctional\register.txt", FileMode.Open);
                FileStream fs = new FileStream(@"C:\antiJatek\register.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string page = "";

                try
                {
                    while (!sr.EndOfStream)
                    {
                        page = sr.ReadLine();
                        string[] array = page.Split(':');
                        Account ac = new Account();
                        ac.Name = array[0];
                        ac.Password = array[1];
                        ac.Money = Convert.ToDouble(array[2]);
                        lista.Add(ac);
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                finally
                {
                    sr.Close();
                    fs.Close();
                }

                for (int i = 0; i < lista.Count; i++)
                {

                    if (lista[i].Name == name && lista[i].Password == password)
                    {
                        succesfull = true;
                        onlineNow = name;
                        moneyMine = lista[i].Money;
                        passNow = Convert.ToDouble(lista[i].Password);
                        break;
                    }
                    else
                    {
                        succesfull = false;
                    }

                }

                if (succesfull)
                {
                    label.Location = new Point(455, 400);
                    label.Text = "Successfull";
                    Menu m = new Menu();
                    m.Show();
                    l.Hide();
                }
                else
                {
                    label.Text = "Wrong name or password";
                }
            }
            catch (Exception)
            {
                label.Text = "Create User before login";
            }
        }

        public void Check(System.Windows.Forms.Label label1, System.Windows.Forms.Label label2, System.Windows.Forms.Label label3)
        {
            if (onlineNow == "" || onlineNow == null)
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
            }
            else
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label1.Text = onlineNow;
                label2.Text = moneyMine.ToString() + " ft";
            }

        }
        public void CheckButton(System.Windows.Forms.Button button, System.Windows.Forms.Button button2, System.Windows.Forms.Button button3)
        {
            if (onlineNow == "" || onlineNow == null)
            {
                button.BackColor = Color.LightGray;
                button.Enabled = false;

                button2.BackColor = Color.LightGray;
                button2.Enabled = false;

                button3.BackColor = Color.FromArgb(128, 64, 64);
                button3.Enabled = true;
            }
            else
            {
                button.BackColor = Color.Peru;
                button.Enabled = true;

                button2.BackColor = Color.SandyBrown;
                button2.Enabled = true;

                button3.BackColor = Color.LightGray;
                button3.Enabled = false;
            }

        }
        public void atm(string nameAcc, string passAcc, double amount, System.Windows.Forms.TextBox tb, System.Windows.Forms.TextBox tb2, System.Windows.Forms.TextBox tb3, System.Windows.Forms.Label label8)
        {
            try
            {
                nameAcc = tb.Text; //Acc name
                passAcc = tb2.Text; //Pass
                amount = Convert.ToDouble(tb3.Text); //Amount
                if (nameAcc != onlineNow)
                {
                    label8.Location = new Point(365, 412);
                    label8.Text = "Wrong account name";
                }
                else
                {
                    if (passAcc != passNow.ToString())
                    {
                        label8.Location = new Point(415, 412);
                        label8.Text = "Wrong password";
                    }
                    else
                    {
                        if (amount < 1)
                        {
                            label8.Location = new Point(415, 412);
                            label8.Text = "How much do you want to deposit?";
                        }
                        else
                        {
                            ReaderWriter rw = new ReaderWriter();
                            rw.MoneyWriter(amount);
                            label8.Location = new Point(436, 413);
                            label8.Text = "Success";
                            //rw.MoneyReader(ref myMoney, label2, label9);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        public void ScrissorsBalance()
        {
            //FileStream fs = new FileStream(@"C:\Users\Anti\source\repos\Multifunctional\register.txt", FileMode.Open);
            FileStream fs = new FileStream(@"C:\antiJatek\register.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string paper = "";
            try
            {
                while (!sr.EndOfStream)
                {
                    paper = sr.ReadLine();
                    string[] array = paper.Split(':');
                    Account ac = new Account();
                    ac.Name = array[0];
                    ac.Password = array[1];
                    ac.Money = Convert.ToDouble(array[2]);
                    lista.Add(ac);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                sr.Close();
                fs.Close();
            }

            //FileStream fs2 = new FileStream(@"C:\Users\Anti\source\repos\Multifunctional\register.txt", FileMode.Create);
            FileStream fs2 = new FileStream(@"C:\antiJatek\register.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs2, Encoding.UTF8);
            double price = 50;

            try
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].Name == onlineNow)
                    {
                        if (lista[i].Money >= price)
                        {
                            sw.WriteLine($"{lista[i].Name}:{lista[i].Password}:{lista[i].Money = lista[i].Money - price}");
                            moneyMine = lista[i].Money;
                        }
                    }
                    else
                    {
                        sw.WriteLine($"{lista[i].Name}:{lista[i].Password}:{lista[i].Money}");
                    }

                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {

                sw.Flush();
                sw.Close();
                fs2.Close();
            }

        }
        public double CheckBalance()
        {
            return moneyMine;
        }
        public void LoseOrWin(Scrissor s)
        {

            //s.Win; 0 semmi 1 win 2 lose
            if (s.Win == 1)//iam the winner
            {
                //FileStream fs = new FileStream(@"C:\Users\Anti\source\repos\Multifunctional\register.txt", FileMode.Open);
                FileStream fs = new FileStream(@"C:\antiJatek\register.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string page = "";

                try
                {
                    while (!sr.EndOfStream)
                    {
                        page = sr.ReadLine();
                        string[] array = page.Split(':');
                        Account ac = new Account();
                        ac.Name = array[0];
                        ac.Password = array[1];
                        ac.Money = Convert.ToDouble(array[2]);
                        lista.Add(ac);
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                finally
                {
                    sr.Close();
                    fs.Close();
                }

                //FileStream fs2 = new FileStream(@"C:\Users\Anti\source\repos\Multifunctional\register.txt", FileMode.Create);
                FileStream fs2 = new FileStream(@"C:\antiJatek\register.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs2, Encoding.UTF8);
                try
                {
                    for (int i = 0; i < lista.Count; i++)
                    {

                        if (lista[i].Name == onlineNow)
                        {
                            sw.WriteLine($"{lista[i].Name}:{lista[i].Password}:{lista[i].Money = lista[i].Money + 100}");
                            moneyMine = lista[i].Money;
                        }
                        else
                        {
                            sw.WriteLine($"{lista[i].Name}:{lista[i].Password}:{lista[i].Money}");
                        }

                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                finally
                {
                    sw.Flush();
                    sw.Close();
                    fs2.Close();
                }
            }
            else if (s.Win == 0)
            {
                //FileStream fs = new FileStream(@"C:\Users\Anti\source\repos\Multifunctional\register.txt", FileMode.Open);
                FileStream fs = new FileStream(@"C:\antiJatek\register.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string page = "";

                try
                {
                    while (!sr.EndOfStream)
                    {
                        page = sr.ReadLine();
                        string[] array = page.Split(':');
                        Account ac = new Account();
                        ac.Name = array[0];
                        ac.Password = array[1];
                        ac.Money = Convert.ToDouble(array[2]);
                        lista.Add(ac);
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                finally
                {
                    sr.Close();
                    fs.Close();
                }

                //FileStream fs2 = new FileStream(@"C:\Users\Anti\source\repos\Multifunctional\register.txt", FileMode.Create);
                FileStream fs2 = new FileStream(@"C:\antiJatek\register.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs2, Encoding.UTF8);
                try
                {
                    for (int i = 0; i < lista.Count; i++)
                    {

                        if (lista[i].Name == onlineNow)
                        {
                            sw.WriteLine($"{lista[i].Name}:{lista[i].Password}:{lista[i].Money = lista[i].Money + 50}");
                            moneyMine = lista[i].Money;
                        }
                        else
                        {
                            sw.WriteLine($"{lista[i].Name}:{lista[i].Password}:{lista[i].Money}");
                        }

                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                finally
                {
                    sw.Flush();
                    sw.Close();
                    fs2.Close();
                }
            }
            else
            {
                //Nothing happened
            }

        }
        public void TictacBalance()
        {
            //FileStream fs = new FileStream(@"C:\Users\Anti\source\repos\Multifunctional\register.txt", FileMode.Open);
            FileStream fs = new FileStream(@"C:\antiJatek\register.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string paper = "";
            try
            {
                while (!sr.EndOfStream)
                {
                    paper = sr.ReadLine();
                    string[] array = paper.Split(':');
                    Account ac = new Account();
                    ac.Name = array[0];
                    ac.Password = array[1];
                    ac.Money = Convert.ToDouble(array[2]);
                    lista.Add(ac);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                sr.Close();
                fs.Close();
            }

            //FileStream fs2 = new FileStream(@"C:\Users\Anti\source\repos\Multifunctional\register.txt", FileMode.Create);
            FileStream fs2 = new FileStream(@"C:\antiJatek\register.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs2, Encoding.UTF8);
            double price = 100;

            try
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].Name == onlineNow)
                    {
                        if (lista[i].Money >= price)
                        {
                            sw.WriteLine($"{lista[i].Name}:{lista[i].Password}:{lista[i].Money = lista[i].Money - price}");
                            moneyMine = lista[i].Money;
                        }
                    }
                    else
                    {
                        sw.WriteLine($"{lista[i].Name}:{lista[i].Password}:{lista[i].Money}");
                    }

                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {

                sw.Flush();
                sw.Close();
                fs2.Close();
            }

        }
        public void WinTicTac()
        {
            //FileStream fs = new FileStream(@"C:\Users\Anti\source\repos\Multifunctional\register.txt", FileMode.Open);
            FileStream fs = new FileStream(@"C:\antiJatek\register.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string page = "";

            try
            {
                while (!sr.EndOfStream)
                {
                    page = sr.ReadLine();
                    string[] array = page.Split(':');
                    Account ac = new Account();
                    ac.Name = array[0];
                    ac.Password = array[1];
                    ac.Money = Convert.ToDouble(array[2]);
                    lista.Add(ac);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                sr.Close();
                fs.Close();
            }

            //FileStream fs2 = new FileStream(@"C:\Users\Anti\source\repos\Multifunctional\register.txt", FileMode.Create);
            FileStream fs2 = new FileStream(@"C:\antiJatek\register.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs2, Encoding.UTF8);
            try
            {
                for (int i = 0; i < lista.Count; i++)
                {

                    if (lista[i].Name == onlineNow)
                    {
                        sw.WriteLine($"{lista[i].Name}:{lista[i].Password}:{lista[i].Money = lista[i].Money + 200}");
                        moneyMine = lista[i].Money;
                    }
                    else
                    {
                        sw.WriteLine($"{lista[i].Name}:{lista[i].Password}:{lista[i].Money}");
                    }

                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                sw.Flush();
                sw.Close();
                fs2.Close();
            }


        }
    }
}