using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WIATest
{
    public partial class SettingsForm : Form
    {

        public SettingsForm()
        {
            InitializeComponent();

            save_TextBox.Text = Properties.Settings.Default.SavePath;
            numericUpDown1.Value = Properties.Settings.Default.SelectScanner;
            loadAfterBoot_radioButton.Checked = Properties.Settings.Default.StartAfterBoot;
            runInBackground_radioButton.Checked = Properties.Settings.Default.RunAsProcess;
            firstKey_combox.SelectedIndex = Properties.Settings.Default.FirstKey;
            secondKey_textbox.Text = Properties.Settings.Default.SecondKey;

        }

        private void savePath_button_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPEG|*.jpg|BMP|*.bmp|PNG|*.png|gif|*.gif|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.ShowDialog();

            save_TextBox.Text = saveFileDialog1.FileName;
        }

        private void saveSettings_button_Click(object sender, EventArgs e)
        {


            Properties.Settings.Default.SavePath = save_TextBox.Text;
            Properties.Settings.Default.SelectScanner = Convert.ToInt32(numericUpDown1.Value);
            Properties.Settings.Default.StartAfterBoot = loadAfterBoot_radioButton.Checked;
            Properties.Settings.Default.RunAsProcess = runInBackground_radioButton.Checked;
            Properties.Settings.Default.FirstKey = firstKey_combox.SelectedIndex;
            Properties.Settings.Default.SecondKey = secondKey_textbox.Text;
            Properties.Settings.Default.FileExtension = saveFileDialog1.FilterIndex;
            Properties.Settings.Default.Save();
            this.Close();
        }
        void SettingsForm_SettingsSaving(object sender, CancelEventArgs e)
        {
          //  this.Close();
        }
    }
}
