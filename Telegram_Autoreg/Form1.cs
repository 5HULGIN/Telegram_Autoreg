using SimWinInput;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Telegram_Autoreg
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;


        List<string> First_names_list = new List<string>();
        List<string> Second_names_list = new List<string>();
        List<string> avatars = new List<string>();


        public Form1()
        {
            InitializeComponent();
        }

        private void First_names_upload_button_Click(object sender, EventArgs e)
        {
            string filename = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog() { Filter = "Text files(*.txt)|*.txt" };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                filename = openFileDialog1.FileName;
            try
            {
                First_names_list = File.ReadAllLines(filename).ToList();
            }
            catch (Exception) { }

            try
            {
                Autoreg_log.SelectionFont = new Font(Autoreg_log.Font, FontStyle.Bold);
                Autoreg_log.AppendText("[" + DateTime.Now.ToString("MM/dd/yyyy h:mm tt") + "]" + "\n");
                Autoreg_log.Text += "List of First names:\n\n";
                foreach (string name in First_names_list)
                {
                    Autoreg_log.AppendText(name + "\n");
                    Autoreg_log.ScrollToCaret();

                }
            }
            catch (Exception E)
            {

            }
            Autoreg_log.AppendText("\n");

        }
        public void Time_log(string text) {

            Autoreg_log.AppendText("[" + DateTime.Now.ToString("MM/dd/yyyy h:mm tt") + "]" + "\n");
            Autoreg_log.AppendText(text);
            Autoreg_log.ScrollToCaret();

        }

        public void LeftClick(int x, int y, int delay)
        {
            SimMouse.Click(MouseButtons.Left, x, y);
            System.Threading.Thread.Sleep(delay);
        }

        public void SetAvatar()
        {
            var random = new Random();

            LeftClick(25, 50, 1000);
            LeftClick(100, 360, 1000);
            LeftClick(160, 185, 1000);
            IntPtr hWindow = FindWindow(null, "Выберите изображение");
            MoveWindow(hWindow, 0, 0, 600, 600, true);
            LeftClick(160, 185, 500);
            LeftClick(247, 536, 300);
            SendKeys.SendWait("{BS}");
            System.Threading.Thread.Sleep(1000);
            int random_index = random.Next((avatars.Count) - 1);
            SendKeys.SendWait(avatars[random_index]);
            System.Threading.Thread.Sleep(500);
            LeftClick(450, 570, 500);
            System.Threading.Thread.Sleep(1000);
            LeftClick(415, 496, 0);
        }

        private void Second_names_upload_button_Click(object sender, EventArgs e)
        {
            string filename = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog() { Filter = "Text files(*.txt)|*.txt" };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                filename = openFileDialog1.FileName;
            try
            {
                Second_names_list = File.ReadAllLines(filename).ToList();
            }
            catch (Exception) { }

            try
            {
                Autoreg_log.SelectionFont = new Font(Autoreg_log.Font, FontStyle.Bold);
                Autoreg_log.AppendText("[" + DateTime.Now.ToString("MM/dd/yyyy h:mm tt") + "]" + "\n");
                Autoreg_log.Text += "List of Second names:\n\n";
                foreach (string name in Second_names_list)
                {
                    Autoreg_log.AppendText(name + "\n");
                    Autoreg_log.ScrollToCaret();

                }
            }
            catch (Exception E)
            {

            }
            Autoreg_log.AppendText("\n");

        }

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);


        public void Sleep(int delay)
        {
            System.Threading.Thread.Sleep(delay);

        }

        public void sms_activate_RegisterAccount(string NotNumberAtAll, string name, string surname, string key, string id)
        {
            
            char[] NF = NotNumberAtAll.ToCharArray();

            if (File.Exists(Directory.GetCurrentDirectory() + @"\telegram\Telegram.exe")){ } else { MessageBox.Show("Telegram.exe not found"); }
            System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"\telegram\Telegram.exe");
            System.Threading.Thread.Sleep(1000);


            IntPtr hWindow = FindWindow(null, "Telegram");
            MoveWindow(hWindow, 0, 0, 600, 600, true);

            Sleep(2000);
            MoveWindow(hWindow, 0, 0, 600, 600, true);
            Sleep(1000);
            LeftClick(300, 425, 1000);
            LeftClick(200, 310, 1000);
            SendKeys.SendWait("{BS}");
            SendKeys.SendWait("{BS}");
            SendKeys.SendWait("{BS}");
            Sleep(1000);
            SendKeys.SendWait("{+}");
            Sleep(500);
            SendKeys.SendWait("7");
            Time_log("Number is ready");
            Sleep(1000);
            LeftClick(300, 310, 100);
            for(int i= 0;i <= 9;i++)
            {

                SendKeys.SendWait(NF[i].ToString());
                Sleep(500);

            }
            Sleep(1000);
            LeftClick(300, 410, 0);

            using (var client1 = new WebClient())
            {
                string url = @"http://sms-activate.ru/stubs/handler_api.php?api_key=" + key + @"&action=setStatus&status=1&id=" + id + "&forward=0";
                var responseString = client1.DownloadString(url);


                int j = 0;
                while (j != 1)
                {

                    string url1 = @"http://sms-activate.ru/stubs/handler_api.php?api_key=" + key + @"&action=getStatus&id=" + id;
                    var responseString1 = client1.DownloadString(url1); 
                    if(responseString1.Contains("STATUS_OK")) { j = 1; }
                    Sleep(2000);
                }

                if (responseString == "ACCESS_READY")
                {
                    
                    string url1 = @"http://sms-activate.ru/stubs/handler_api.php?api_key=" + key + @"&action=getStatus&id=" + id;
                    var responseString1 = client1.DownloadString(url1);
                    var code = responseString1.Substring(10, 5);
                    SendKeys.SendWait(code);
                    Sleep(2000);
                    LeftClick(280, 250, 2500);
                    SendKeys.SendWait(name);
                    Sleep(750);
                    LeftClick(280, 310, 1500);
                    SendKeys.SendWait(surname);
                    Sleep(1000);
                    LeftClick(300, 400, 0);
                    NotNumberAtAll = "+7" + NotNumberAtAll;
                    Accounts_table.Rows.Add(NotNumberAtAll, name, surname);
                    int n = 1;
                    Time_log(("Account № " + n.ToString() + " registered"));
                    ++n;
                    LeftClick(300, 410, 0);
                    LeftClick(300, 400, 1000);

                    if (avatars.Count != 0)
                    {
                        Sleep(2000);
                        SetAvatar();
                    }
                    System.Threading.Thread.Sleep(2000);

                    try
                    {
                        Process[] telegram = Process.GetProcessesByName("Telegram");
                        telegram[0].Kill();
                        Sleep(2500);
                    }
                    catch { }
                    MoveTelegram();
                    j = 0;

                    using (var client2 = new WebClient()) {
                        string url2 = @"http://sms-activate.ru/stubs/handler_api.php?api_key=" + key + @"&action=setStatus&status=6&id=" + id + "&forward=0";
                        var responseString2 = client2.DownloadString(url2);
                        Time_log(responseString2);
                    }

                }
            }
        }
        int n = 2;
        public void MoveTelegram()
        {
            Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\accounts\" + (n - 1).ToString());
            Sleep(1500);
            new DirectoryInfo((Directory.GetCurrentDirectory() + @"\telegram\tdata")).MoveTo(Directory.GetCurrentDirectory() + @"\accounts\" + (n - 1).ToString() + @"\tdata");
            Sleep(1000);
            new DirectoryInfo((Directory.GetCurrentDirectory() + @"\telegram\log.txt")).MoveTo(Directory.GetCurrentDirectory() + @"\accounts\" + (n - 1).ToString() + @"\log.txt");
            n++;
            Time_log("Account moved successfully");



        }

        public void start()
        {
            var random = new Random();


            if (Second_names_list != null && First_names_list != null && sms_service.Text != null && api_key != null)
            {
                if (sms_service.Text == "sms-activate.ru")
                {
                    string key = api_key.Text;
                    string url = @"http://sms-activate.ru/stubs/handler_api.php?api_key=" + key + @"&action=getNumber&service=tg&forward=0&operator=&ref=0&country=0";
                    using (var client = new WebClient())
                    {
                        var responseString = client.DownloadString(url);
                        if (responseString.Contains("ACCESS_NUMBER"))
                        {
                            string number = responseString.Substring(25, 10);
                            string id = responseString.Substring(14, 9);
                            int name_index = random.Next((First_names_list.Count) - 1);
                            int surname_index = random.Next((Second_names_list.Count) - 1);
                            sms_activate_RegisterAccount(number, First_names_list[name_index], Second_names_list[surname_index], key, id);
                        }

                    }


                }
            }
            else
            {
            }
        }
        public void GetBalance()
        {
            if(api_key.Text!= "api key" && api_key.Text != null)
            {
                string url = @"http://sms-activate.ru/stubs/handler_api.php?api_key=" + api_key.Text + @"&action=getBalance";
                using (var cclient = new WebClient())
                {
                    var Balance = cclient.DownloadString(url);
                    Balance_Text.Text = Balance.Substring(15, (Balance.Length - 15));
                }
            }
            else
            {
                Balance_Text.Text = "Wrong key";
            }
        }
        private void start_button_Click(object sender, EventArgs e)
        {
            //
            if (Count_accounts.Text == null)
            {
                Count_accounts.Text = "1";
            }
            int count = Int32.Parse(Count_accounts.Text);

           for(int nn = 1; nn <= count; nn++)
            {
                GetBalance();
                start();
            }
            n = n / 2;
            MessageBox.Show(n.ToString() + " Accounts registered");

        }

        private void Avatars_upload_button_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {

                    string[] avatars1 = Directory.GetFiles(fbd.SelectedPath);
                    foreach (string av in avatars1)
                    {
                        avatars.Add(av);
                        Time_log("Add avatar " + av);
                    }
                }
            }
        }
    }
}
