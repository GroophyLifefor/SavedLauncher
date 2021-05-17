using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SavedLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string save;
        public static string ip="127.0.0.1";
        //https://www.c-sharpcorner.com/article/working-with-json-in-C-Sharp/
        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"C:\Windows\System32\Drivers\etc\hosts");
            string hts = sr.ReadToEnd();
            sr.Close();
            if (hts.Contains("growtopia1.com") == true)
            {
                stat.Text = "Status: on a private, " +Environment.NewLine+ hts;
            }
            else if (hts.Contains("growtopia1.com") == false)
            {
                stat.Text = "Status: RealGT";
            }
            label1.Text = Environment.NewLine + hts;
            try
            {
                StreamReader saved = new StreamReader("saved.txt");
                save = saved.ReadToEnd();
                saved.Close();
            }
            catch
            {
                StreamWriter make = new StreamWriter("saved.txt");
                make.Write(" ");
                make.Close();
                MessageBox.Show("error fixed open again");
                Application.Exit();
            }

            string[] words = save.Split(';');

            foreach (string word in words)
            {
                selectlist.Items.Add(word);
                richTextBox1.Text += word + Environment.NewLine;
            }
            
        }

        private void newadd_Click(object sender, EventArgs e)
        {
            newaddname.Visible = true;
            newaddip.Visible = true;
            addnow.Visible = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void con_Click(object sender, EventArgs e)
        {
            string chooseds = selectlist.SelectedItem.ToString();
            if (selectlist.SelectedItem != null)
            {
                if (chooseds == "RealGT")
                {
                    StreamWriter sw = new StreamWriter(@"C:\Windows\System32\Drivers\etc\hosts");
                    sw.Write("#realgt mode by Groophy");
                    sw.Close();
                }
                
                
                string[] changer = chooseds.Split(',');
                
                foreach (string word in changer)
                {
                    if (changer.Length == 2)
                    {
                        ip = word;
                        
                    }
                }

                StreamWriter sws = new StreamWriter(@"C:\Windows\System32\Drivers\etc\hosts");
                sws.Write(ip+ " growtopia1.com" + Environment.NewLine +ip+ " growtopia2.com");
                sws.Close();
                
            }
            StreamReader sr = new StreamReader(@"C:\Windows\System32\Drivers\etc\hosts");
            string hts = sr.ReadToEnd();
            sr.Close();
            if (hts.Contains("growtopia1.com") == true)
            {
                stat.Text = "Status: on a private, " + Environment.NewLine + hts;
            }
            else if (hts.Contains("growtopia1.com") == false)
            {
                stat.Text = "Status: RealGT";
            }
            label1.Text = Environment.NewLine + hts;
            try
            {
                StreamReader saved = new StreamReader("saved.txt");
                save = saved.ReadToEnd();
                saved.Close();
            }
            catch
            {
                StreamWriter make = new StreamWriter("saved.txt");
                make.Write(" ");
                make.Close();
                MessageBox.Show("error fixed open again");
                Application.Exit();
            }
        }

        private void res_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"C:\Windows\System32\Drivers\etc\hosts");
            string hts = sr.ReadToEnd();
            sr.Close();
            if (hts.Contains("growtopia1.com") == true)
            {
                stat.Text = "Status: on a private, " + Environment.NewLine + hts;
            }
            else if (hts.Contains("growtopia1.com") == false)
            {
                stat.Text = "Status: RealGT";
            }
            label1.Text = Environment.NewLine + hts;
            try
            {
                StreamReader saved = new StreamReader("saved.txt");
                save = saved.ReadToEnd();
                saved.Close();
            }
            catch
            {
                StreamWriter make = new StreamWriter("saved.txt");
                make.Write(" ");
                make.Close();
                MessageBox.Show("error fixed open again");
                Application.Exit();
            }
        }

        private void uncon_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"C:\Windows\System32\Drivers\etc\hosts");
            sw.Write("#realgt mode by Groophy");
            sw.Close();
            StreamReader sr = new StreamReader(@"C:\Windows\System32\Drivers\etc\hosts");
            string hts = sr.ReadToEnd();
            sr.Close();
            if (hts.Contains("growtopia1.com") == true)
            {
                stat.Text = "Status: on a private, " + Environment.NewLine + hts;
            }
            else if (hts.Contains("growtopia1.com") == false)
            {
                stat.Text = "Status: RealGT";
            }
            label1.Text = Environment.NewLine + hts;
        }

        private void addnow_Click(object sender, EventArgs e)
        {
            string names=newaddname.Text;
            string ips = newaddip.Text;
            if (names.Contains(";") || names.Contains(","))
            {
                MessageBox.Show("you can't use ; and , for name");
                return;
            }
            string nips = ips.Replace(".", string.Empty);
            if (!System.Text.RegularExpressions.Regex.IsMatch(nips, "[^0-9]"))
            {
                MessageBox.Show("Somethings gone wrong by ip please rewrite with like 123.123.123.123");
                return;
            }

            string now;
            StreamReader saved = new StreamReader("saved.txt");
            now = saved.ReadToEnd();
            saved.Close();

            StreamWriter ns = new StreamWriter("saved.txt");
            ns.Write(now + ";" + newaddname.Text + "," + newaddip.Text);
            ns.Close();

            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string now;
            StreamReader saved = new StreamReader("saved.txt");
            now = saved.ReadToEnd();
            saved.Close();

            now = now.Replace(";"+selectlist.SelectedItem.ToString(), string.Empty);
            

            StreamWriter ns = new StreamWriter("saved.txt");
            ns.Write(now);
            ns.Close();
            Application.Restart();
        }


    }
}
