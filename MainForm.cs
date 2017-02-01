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
        public static string GetFilePath(string path)
        {
            return System.IO.Path.GetDirectoryName(path);
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            try
            {
                List<Image> images = WIAScanner.Scan((string)lbDevices.SelectedItem);
                foreach (Image image in images)
                {
                    if (Properties.Settings.Default.FileExtension == 0)
                    {
                        image.Save(GetFilePath(Properties.Settings.Default.SavePath) + DateTime.Now.ToString("yyyy-MM-dd HHmmss") + ".jpeg", ImageFormat.Jpeg);
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

            if (lbDevices.Items.Count == 0)
            {
                MessageBox.Show("You do not have any WIA devices.");
            }
            else
            {
                lbDevices.SelectedIndex = 0;
            }
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            SettingsForm setForm = new SettingsForm();
            setForm.Show();
        }
    }
}

