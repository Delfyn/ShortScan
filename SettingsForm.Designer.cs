namespace WIATest
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveSettings_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.save_TextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.savePath_button = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.runInBackground_radioButton = new System.Windows.Forms.CheckBox();
            this.loadAfterBoot_radioButton = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.firstKey_combox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.secondKey_textbox = new System.Windows.Forms.TextBox();
            this.debug_radioButton = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveSettings_button
            // 
            this.saveSettings_button.Location = new System.Drawing.Point(12, 306);
            this.saveSettings_button.Name = "saveSettings_button";
            this.saveSettings_button.Size = new System.Drawing.Size(309, 29);
            this.saveSettings_button.TabIndex = 0;
            this.saveSettings_button.Text = "Save";
            this.saveSettings_button.UseVisualStyleBackColor = true;
            this.saveSettings_button.Click += new System.EventHandler(this.saveSettings_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Save path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Default scanner (0 default)";
            // 
            // save_TextBox
            // 
            this.save_TextBox.Location = new System.Drawing.Point(12, 29);
            this.save_TextBox.Name = "save_TextBox";
            this.save_TextBox.Size = new System.Drawing.Size(227, 22);
            this.save_TextBox.TabIndex = 5;
            // 
            // savePath_button
            // 
            this.savePath_button.Location = new System.Drawing.Point(246, 29);
            this.savePath_button.Name = "savePath_button";
            this.savePath_button.Size = new System.Drawing.Size(75, 23);
            this.savePath_button.TabIndex = 6;
            this.savePath_button.Text = "Browse";
            this.savePath_button.UseVisualStyleBackColor = true;
            this.savePath_button.Click += new System.EventHandler(this.savePath_button_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 150);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(309, 22);
            this.numericUpDown1.TabIndex = 8;
            // 
            // runInBackground_radioButton
            // 
            this.runInBackground_radioButton.AutoSize = true;
            this.runInBackground_radioButton.Location = new System.Drawing.Point(12, 188);
            this.runInBackground_radioButton.Name = "runInBackground_radioButton";
            this.runInBackground_radioButton.Size = new System.Drawing.Size(150, 21);
            this.runInBackground_radioButton.TabIndex = 9;
            this.runInBackground_radioButton.Text = "Run in background";
            this.runInBackground_radioButton.UseVisualStyleBackColor = true;
            // 
            // loadAfterBoot_radioButton
            // 
            this.loadAfterBoot_radioButton.AutoSize = true;
            this.loadAfterBoot_radioButton.Location = new System.Drawing.Point(12, 215);
            this.loadAfterBoot_radioButton.Name = "loadAfterBoot_radioButton";
            this.loadAfterBoot_radioButton.Size = new System.Drawing.Size(121, 21);
            this.loadAfterBoot_radioButton.TabIndex = 10;
            this.loadAfterBoot_radioButton.Text = "Run after boot";
            this.loadAfterBoot_radioButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Shortcut";
            // 
            // firstKey_combox
            // 
            this.firstKey_combox.FormattingEnabled = true;
            this.firstKey_combox.Items.AddRange(new object[] {
            "Ctrl",
            "Alt",
            "Shift",
            "Fn"});
            this.firstKey_combox.Location = new System.Drawing.Point(12, 269);
            this.firstKey_combox.Name = "firstKey_combox";
            this.firstKey_combox.Size = new System.Drawing.Size(121, 24);
            this.firstKey_combox.TabIndex = 12;
            this.firstKey_combox.Text = "First key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "+";
            // 
            // secondKey_textbox
            // 
            this.secondKey_textbox.Location = new System.Drawing.Point(209, 269);
            this.secondKey_textbox.Name = "secondKey_textbox";
            this.secondKey_textbox.Size = new System.Drawing.Size(112, 22);
            this.secondKey_textbox.TabIndex = 15;
            // 
            // debug_radioButton
            // 
            this.debug_radioButton.AutoSize = true;
            this.debug_radioButton.Location = new System.Drawing.Point(223, 188);
            this.debug_radioButton.Name = "debug_radioButton";
            this.debug_radioButton.Size = new System.Drawing.Size(72, 21);
            this.debug_radioButton.TabIndex = 16;
            this.debug_radioButton.Text = "Debug";
            this.debug_radioButton.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(333, 378);
            this.ControlBox = false;
            this.Controls.Add(this.debug_radioButton);
            this.Controls.Add(this.secondKey_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.firstKey_combox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loadAfterBoot_radioButton);
            this.Controls.Add(this.runInBackground_radioButton);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.savePath_button);
            this.Controls.Add(this.save_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveSettings_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveSettings_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox save_TextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button savePath_button;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox runInBackground_radioButton;
        private System.Windows.Forms.CheckBox loadAfterBoot_radioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox firstKey_combox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox secondKey_textbox;
        private System.Windows.Forms.CheckBox debug_radioButton;
    }
}