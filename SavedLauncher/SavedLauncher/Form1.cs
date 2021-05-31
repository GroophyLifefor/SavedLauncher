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
using System.Diagnostics;

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
        public static string server = "none";
        public static bool logopen = false;
        //349; 330
        //580; 330
        //weidth
        private void Form1_Load(object sender, EventArgs e)
        {
            logadd("SavedLauncher Opened");
            Directory.CreateDirectory("SaveDatas");
            selectlist.SelectedIndex = selectlist.FindStringExact("RealGT,127.0.0.1");
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
            }
            logadd("SavedLauncher Open load done");
        }

        private void newadd_Click(object sender, EventArgs e)
        {
            newaddname.Visible = true;
            newaddip.Visible = true;
            addnow.Visible = true;
            logadd("new data button clicked");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            logadd("SavedLauncher Closing");
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
                logadd("connecting to " + ip);
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
            try
            {
                servername();
                File.Delete(@"C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Growtopia\\save.dat");
                //File.Move(Environment.CurrentDirectory + "\\SaveDatas\\" + server, @"C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Growtopia\\save.dat");
                File.Copy(Environment.CurrentDirectory + "\\SaveDatas\\" + server, @"C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Growtopia\\save.dat");
                logadd("Save dat secured");
                MessageBox.Show("Save dat changed");

                try
                {
                    try
                    {
                        var process = Process.GetProcessesByName("Growtopia")[0];
                        process.Kill();
                        logadd("Growtopia closed");
                    }
                    catch
                    {

                    }
                    var path = @"C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Growtopia\\Growtopia.exe";
                    Process.Start(path);
                    logadd("Growtopia reopened");
                }
                catch
                {

                }
            }
            catch
            {
                try
                {
                    File.Delete(@"C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Growtopia\\save.dat");
                    try
                    {
                        var process = Process.GetProcessesByName("Growtopia")[0];
                        process.Kill();
                        logadd("Growtopia closed");
                    }
                    catch (Exception eps)
                    {

                    }
                    var path = @"C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Growtopia\\Growtopia.exe";
                    Process.Start(path);
                    logadd("growtopia reopened");
                    MessageBox.Show("sorry for deleted save.dat I only save ur account informations");
                    //I save ur acconts to private servers ;D
                }
                catch
                {

                }
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
            logadd("Restart Done");
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
            logadd("Unconnected");
        }

        private void addnow_Click(object sender, EventArgs e)
        {
            string names=newaddname.Text;
            string ips = newaddip.Text;
            logadd("Try to add new data");
            if (names.Contains(";") || names.Contains(","))
            {
                MessageBox.Show("you can't use ; and , for name");
                logadd("Add data failed: you can't use ; and , for name");
                return;
            }
            string nips = ips.Replace(".", string.Empty);
            try
            {
                int.Parse(nips);
                
            }
            catch (Exception)
            {
                MessageBox.Show("Somethings gone wrong by ip please rewrite with like 123.123.123.123");
                logadd("add data failed: Somethings gone wrong by ip please rewrite with like 123.123.123.123");
                return;
            }
            string now;
            StreamReader saved = new StreamReader("saved.txt");
            now = saved.ReadToEnd();
            saved.Close();

            StreamWriter ns = new StreamWriter("saved.txt");
            ns.Write(now + ";" + newaddname.Text + "," + newaddip.Text);
            ns.Close();
            logadd("new data added");
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
            logadd("Data removed");
            Application.Restart();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //C:\Users\muratgtvb\AppData\Local\Growtopia
            servername();
            try
            {
                File.Move(@"C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Growtopia\\save.dat", Environment.CurrentDirectory + "\\SaveDatas\\" + server);
                MessageBox.Show("Succesful but I mean you don't forget the save save.dat / if you try join realgt with anyone name, pass game save ur save.dat");
            }
            catch (Exception error)
            {
                MessageBox.Show("error: "+error.Message);
            }
            logadd("Save.dat Saved for fast and secured login");
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void servername()
        {
            string chooseds = selectlist.SelectedItem.ToString();
            string[] changer = chooseds.Split(',');

            foreach (string word in changer)
            {
                server = word;
                logadd("Server name found");
                return;
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Groophy-Lifefor/SavedLauncher");
        }

        private void logshow_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            Point hal1 = new Point(349, 330);
            Point hal2 = new Point(580, 330);
            
            if (logopen == false)
            {
                this.Size = new Size(hal2);
                logopen = true;
                logadd("log box opened");
            }
            else if (logopen == true)
            {
                this.Size = new Size(hal1);
                logopen = false;
                logadd("log box closed");
            }
        }

        private void logadd(string input)
        {
            logbox.Text = input + Environment.NewLine + logbox.Text;
            return;
        }


    }
    
}
