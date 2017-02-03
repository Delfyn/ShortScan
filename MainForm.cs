using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace WIATest
{
    public partial class MainForm : Form
    {
        public string GetFirstShortcut(int id)
        {
            switch (id)
            {
                case 0:
                    return "Ctrl";
                case 1:
                    return "Alt";
                case 2:
                    return "Shift";
                case 3:
                    return "Fn";
                default:
                    return "Unknown ";

            }
        }
        public static string GetFilePath(string path)
        {
            return System.IO.Path.GetDirectoryName(path);
        }

        private void TrayIcon(bool process)
        {
            
            if (process)
            {


                this.WindowState = FormWindowState.Minimized;

                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                notifyIcon1.Icon = Properties.Resources.icon;
                notifyIcon1.BalloonTipText = "I'am here!";
                notifyIcon1.ShowBalloonTip(500);

                this.Hide();
           
            }

            else if (FormWindowState.Normal == this.WindowState || !process)
            {
                notifyIcon1.Visible = false;
                this.ShowInTaskbar = true;
            }
        }
        public MainForm()
        {
            InitializeComponent();
            TrayIcon(Properties.Settings.Default.RunAsProcess);
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            try
            {
                List<Image> images = WIAScanner.Scan((string)lbDevices.SelectedItem);
                foreach (Image image in images)
                {
                    switch (Properties.Settings.Default.FileExtension)
                    {
                        case 0:
                            image.Save(GetFilePath(Properties.Settings.Default.SavePath) + DateTime.Now.ToString("yyyy-MM-dd HHmmss") + ".jpeg", ImageFormat.Jpeg);
                            break;
                        case 1:
                            image.Save(GetFilePath(Properties.Settings.Default.SavePath) + DateTime.Now.ToString("yyyy-MM-dd HHmmss") + ".bmp", ImageFormat.Bmp);
                            break;
                        case 2:
                            image.Save(GetFilePath(Properties.Settings.Default.SavePath) + DateTime.Now.ToString("yyyy-MM-dd HHmmss") + ".png", ImageFormat.Png);
                            break;
                        case 3:
                            image.Save(GetFilePath(Properties.Settings.Default.SavePath) + DateTime.Now.ToString("yyyy-MM-dd HHmmss") + ".gif", ImageFormat.Gif);
                            break;
                    }
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            List<string> devices = WIAScanner.GetDevices();

            foreach (string device in devices)
            {
                lbDevices.Items.Add(device);
            }

            if (lbDevices.Items.Count == 0 && Properties.Settings.Default.Debug)
            {
                MessageBox.Show("You do not have any WIA devices.");
            }
            else
            {
                lbDevices.SelectedIndex = -1;
            }
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            SettingsForm setForm = new SettingsForm();
            setForm.Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(GetFirstShortcut(Properties.Settings.Default.FirstKey)+ " + " + Properties.Settings.Default.SecondKey.ToString(), ":)");
        }
    }
}

