namespace Telegram_Autoreg
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Autoreg_log = new System.Windows.Forms.RichTextBox();
            this.Second_names_upload_button = new System.Windows.Forms.Button();
            this.First_names_upload_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Count_accounts = new System.Windows.Forms.TextBox();
            this.Use_Proxy_CheckBox = new System.Windows.Forms.CheckBox();
            this.Avatars_upload_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Balance_Text = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.api_key = new System.Windows.Forms.TextBox();
            this.sms_service = new System.Windows.Forms.ComboBox();
            this.start_button = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Accounts_table = new System.Windows.Forms.DataGridView();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Accounts_table)).BeginInit();
            this.SuspendLayout();
            // 
            // Autoreg_log
            // 
            this.Autoreg_log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Autoreg_log.Location = new System.Drawing.Point(6, 17);
            this.Autoreg_log.Name = "Autoreg_log";
            this.Autoreg_log.ReadOnly = true;
            this.Autoreg_log.Size = new System.Drawing.Size(131, 131);
            this.Autoreg_log.TabIndex = 5;
            this.Autoreg_log.Text = "";
            // 
            // Second_names_upload_button
            // 
            this.Second_names_upload_button.Location = new System.Drawing.Point(6, 48);
            this.Second_names_upload_button.Name = "Second_names_upload_button";
            this.Second_names_upload_button.Size = new System.Drawing.Size(126, 23);
            this.Second_names_upload_button.TabIndex = 4;
            this.Second_names_upload_button.Text = "Second Names upload";
            this.Second_names_upload_button.UseVisualStyleBackColor = true;
            this.Second_names_upload_button.Click += new System.EventHandler(this.Second_names_upload_button_Click);
            // 
            // First_names_upload_button
            // 
            this.First_names_upload_button.Location = new System.Drawing.Point(6, 19);
            this.First_names_upload_button.Name = "First_names_upload_button";
            this.First_names_upload_button.Size = new System.Drawing.Size(126, 23);
            this.First_names_upload_button.TabIndex = 3;
            this.First_names_upload_button.Text = "First Names Upload";
            this.First_names_upload_button.UseVisualStyleBackColor = true;
            this.First_names_upload_button.Click += new System.EventHandler(this.First_names_upload_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Count_accounts);
            this.groupBox1.Controls.Add(this.Use_Proxy_CheckBox);
            this.groupBox1.Controls.Add(this.Avatars_upload_button);
            this.groupBox1.Controls.Add(this.Second_names_upload_button);
            this.groupBox1.Controls.Add(this.First_names_upload_button);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 152);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number of accounts";
            // 
            // Count_accounts
            // 
            this.Count_accounts.Location = new System.Drawing.Point(109, 103);
            this.Count_accounts.Name = "Count_accounts";
            this.Count_accounts.Size = new System.Drawing.Size(28, 20);
            this.Count_accounts.TabIndex = 2;
            this.Count_accounts.Text = "1";
            this.Count_accounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Use_Proxy_CheckBox
            // 
            this.Use_Proxy_CheckBox.AutoSize = true;
            this.Use_Proxy_CheckBox.Enabled = false;
            this.Use_Proxy_CheckBox.Location = new System.Drawing.Point(6, 129);
            this.Use_Proxy_CheckBox.Name = "Use_Proxy_CheckBox";
            this.Use_Proxy_CheckBox.Size = new System.Drawing.Size(74, 17);
            this.Use_Proxy_CheckBox.TabIndex = 6;
            this.Use_Proxy_CheckBox.Text = "Use Proxy";
            this.Use_Proxy_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Avatars_upload_button
            // 
            this.Avatars_upload_button.Enabled = false;
            this.Avatars_upload_button.Location = new System.Drawing.Point(6, 77);
            this.Avatars_upload_button.Name = "Avatars_upload_button";
            this.Avatars_upload_button.Size = new System.Drawing.Size(126, 23);
            this.Avatars_upload_button.TabIndex = 5;
            this.Avatars_upload_button.Text = "Avatars upload";
            this.Avatars_upload_button.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Autoreg_log);
            this.groupBox2.Location = new System.Drawing.Point(12, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(143, 156);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Balance_Text);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.api_key);
            this.groupBox3.Controls.Add(this.sms_service);
            this.groupBox3.Location = new System.Drawing.Point(12, 332);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(143, 98);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SMS services";
            // 
            // Balance_Text
            // 
            this.Balance_Text.AutoSize = true;
            this.Balance_Text.Location = new System.Drawing.Point(61, 75);
            this.Balance_Text.Name = "Balance_Text";
            this.Balance_Text.Size = new System.Drawing.Size(13, 13);
            this.Balance_Text.TabIndex = 9;
            this.Balance_Text.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Balance:";
            // 
            // api_key
            // 
            this.api_key.Location = new System.Drawing.Point(6, 46);
            this.api_key.Name = "api_key";
            this.api_key.Size = new System.Drawing.Size(126, 20);
            this.api_key.TabIndex = 1;
            this.api_key.Text = "api key";
            // 
            // sms_service
            // 
            this.sms_service.FormattingEnabled = true;
            this.sms_service.Items.AddRange(new object[] {
            "sms-activate.ru"});
            this.sms_service.Location = new System.Drawing.Point(6, 19);
            this.sms_service.Name = "sms_service";
            this.sms_service.Size = new System.Drawing.Size(126, 21);
            this.sms_service.TabIndex = 0;
            this.sms_service.Text = "sms-activate.ru";
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(194, 397);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(290, 23);
            this.start_button.TabIndex = 10;
            this.start_button.Text = "START";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Accounts_table);
            this.groupBox4.Location = new System.Drawing.Point(194, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(290, 379);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Accounts";
            // 
            // Accounts_table
            // 
            this.Accounts_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Accounts_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Phone,
            this.F_Name,
            this.S_Name});
            this.Accounts_table.Location = new System.Drawing.Point(6, 15);
            this.Accounts_table.Name = "Accounts_table";
            this.Accounts_table.RowHeadersVisible = false;
            this.Accounts_table.Size = new System.Drawing.Size(284, 357);
            this.Accounts_table.TabIndex = 0;
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phone.HeaderText = "Number";
            this.Phone.Name = "Phone";
            // 
            // F_Name
            // 
            this.F_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.F_Name.HeaderText = "Name";
            this.F_Name.Name = "F_Name";
            // 
            // S_Name
            // 
            this.S_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.S_Name.HeaderText = "Surname";
            this.S_Name.Name = "S_Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(496, 442);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Telegram Autoreg by DOKL57";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Accounts_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Autoreg_log;
        private System.Windows.Forms.Button Second_names_upload_button;
        private System.Windows.Forms.Button First_names_upload_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox sms_service;
        private System.Windows.Forms.TextBox api_key;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.CheckBox Use_Proxy_CheckBox;
        private System.Windows.Forms.Button Avatars_upload_button;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView Accounts_table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Count_accounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_Name;
        private System.Windows.Forms.Label Balance_Text;
        private System.Windows.Forms.Label label2;
    }
}

