namespace MobilePhone.WindowsFormsApp
{
    partial class L4_MessageFiltering
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
            this.listView_Messages = new System.Windows.Forms.ListView();
            this.comboBox_FormattingOptions = new System.Windows.Forms.ComboBox();
            this.comboBox_Users = new System.Windows.Forms.ComboBox();
            this.textBox_MessageText = new System.Windows.Forms.TextBox();
            this.dateTimePicker_FromDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_BeforeDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_Users_OR = new System.Windows.Forms.RadioButton();
            this.radioButton_Users_AND = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton__MessageText_OR = new System.Windows.Forms.RadioButton();
            this.radioButton__MessageText_AND = new System.Windows.Forms.RadioButton();
            this.label_Users = new System.Windows.Forms.Label();
            this.label__MessageText = new System.Windows.Forms.Label();
            this.label_FromDate = new System.Windows.Forms.Label();
            this.label_BeforeDate = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button_StartReceivingMessages = new System.Windows.Forms.Button();
            this.button_RemoveSelectedMessage = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_Messages
            // 
            this.listView_Messages.Location = new System.Drawing.Point(21, 356);
            this.listView_Messages.Margin = new System.Windows.Forms.Padding(6);
            this.listView_Messages.Name = "listView_Messages";
            this.listView_Messages.Size = new System.Drawing.Size(740, 400);
            this.listView_Messages.TabIndex = 0;
            this.listView_Messages.UseCompatibleStateImageBehavior = false;
            // 
            // comboBox_FormattingOptions
            // 
            this.comboBox_FormattingOptions.FormattingEnabled = true;
            this.comboBox_FormattingOptions.Items.AddRange(new object[] {
            "None",
            "Start with DateTime",
            "End with DateTime",
            "Custom",
            "Lowercase",
            "Uppercase"});
            this.comboBox_FormattingOptions.Location = new System.Drawing.Point(21, 309);
            this.comboBox_FormattingOptions.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_FormattingOptions.Name = "comboBox_FormattingOptions";
            this.comboBox_FormattingOptions.Size = new System.Drawing.Size(740, 32);
            this.comboBox_FormattingOptions.TabIndex = 3;
            this.comboBox_FormattingOptions.Text = "None";
            this.comboBox_FormattingOptions.SelectedIndexChanged += new System.EventHandler(this.comboBox_FormattingOptions_SelectedIndexChanged);
            // 
            // comboBox_Users
            // 
            this.comboBox_Users.FormattingEnabled = true;
            this.comboBox_Users.Location = new System.Drawing.Point(326, 15);
            this.comboBox_Users.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_Users.Name = "comboBox_Users";
            this.comboBox_Users.Size = new System.Drawing.Size(259, 32);
            this.comboBox_Users.TabIndex = 4;
            this.comboBox_Users.SelectedIndexChanged += new System.EventHandler(this.comboBox_Users_SelectedIndexChanged);
            // 
            // textBox_MessageText
            // 
            this.textBox_MessageText.Location = new System.Drawing.Point(326, 115);
            this.textBox_MessageText.Name = "textBox_MessageText";
            this.textBox_MessageText.Size = new System.Drawing.Size(259, 29);
            this.textBox_MessageText.TabIndex = 5;
            this.textBox_MessageText.TextChanged += new System.EventHandler(this.textBox_MessageText_TextChanged);
            // 
            // dateTimePicker_FromDate
            // 
            this.dateTimePicker_FromDate.Location = new System.Drawing.Point(326, 208);
            this.dateTimePicker_FromDate.Name = "dateTimePicker_FromDate";
            this.dateTimePicker_FromDate.Size = new System.Drawing.Size(259, 29);
            this.dateTimePicker_FromDate.TabIndex = 6;
            this.dateTimePicker_FromDate.ValueChanged += new System.EventHandler(this.dateTimePicker_FromDate_ValueChanged);
            // 
            // dateTimePicker_BeforeDate
            // 
            this.dateTimePicker_BeforeDate.Location = new System.Drawing.Point(326, 259);
            this.dateTimePicker_BeforeDate.Name = "dateTimePicker_BeforeDate";
            this.dateTimePicker_BeforeDate.Size = new System.Drawing.Size(259, 29);
            this.dateTimePicker_BeforeDate.TabIndex = 7;
            this.dateTimePicker_BeforeDate.Value = new System.DateTime(2019, 8, 19, 14, 42, 46, 0);
            this.dateTimePicker_BeforeDate.ValueChanged += new System.EventHandler(this.dateTimePicker_BeforeDate_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.radioButton_Users_OR);
            this.panel1.Controls.Add(this.radioButton_Users_AND);
            this.panel1.Location = new System.Drawing.Point(331, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 32);
            this.panel1.TabIndex = 8;
            // 
            // radioButton_Users_OR
            // 
            this.radioButton_Users_OR.AutoSize = true;
            this.radioButton_Users_OR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Users_OR.Location = new System.Drawing.Point(6, 6);
            this.radioButton_Users_OR.Name = "radioButton_Users_OR";
            this.radioButton_Users_OR.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton_Users_OR.Size = new System.Drawing.Size(46, 20);
            this.radioButton_Users_OR.TabIndex = 1;
            this.radioButton_Users_OR.Text = "OR";
            this.radioButton_Users_OR.UseVisualStyleBackColor = true;
            this.radioButton_Users_OR.CheckedChanged += new System.EventHandler(this.radioButton_Users_OR_CheckedChanged);
            // 
            // radioButton_Users_AND
            // 
            this.radioButton_Users_AND.AutoSize = true;
            this.radioButton_Users_AND.Checked = true;
            this.radioButton_Users_AND.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Users_AND.Location = new System.Drawing.Point(61, 6);
            this.radioButton_Users_AND.Name = "radioButton_Users_AND";
            this.radioButton_Users_AND.Size = new System.Drawing.Size(55, 20);
            this.radioButton_Users_AND.TabIndex = 0;
            this.radioButton_Users_AND.TabStop = true;
            this.radioButton_Users_AND.Text = "AND";
            this.radioButton_Users_AND.UseVisualStyleBackColor = true;
            this.radioButton_Users_AND.CheckedChanged += new System.EventHandler(this.radioButton_Users_AND_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.radioButton__MessageText_OR);
            this.panel2.Controls.Add(this.radioButton__MessageText_AND);
            this.panel2.Location = new System.Drawing.Point(331, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(118, 32);
            this.panel2.TabIndex = 9;
            // 
            // radioButton__MessageText_OR
            // 
            this.radioButton__MessageText_OR.AutoSize = true;
            this.radioButton__MessageText_OR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton__MessageText_OR.Location = new System.Drawing.Point(4, 6);
            this.radioButton__MessageText_OR.Name = "radioButton__MessageText_OR";
            this.radioButton__MessageText_OR.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton__MessageText_OR.Size = new System.Drawing.Size(46, 20);
            this.radioButton__MessageText_OR.TabIndex = 3;
            this.radioButton__MessageText_OR.Text = "OR";
            this.radioButton__MessageText_OR.UseVisualStyleBackColor = true;
            this.radioButton__MessageText_OR.CheckedChanged += new System.EventHandler(this.radioButton__MessageText_OR_CheckedChanged);
            // 
            // radioButton__MessageText_AND
            // 
            this.radioButton__MessageText_AND.AutoSize = true;
            this.radioButton__MessageText_AND.Checked = true;
            this.radioButton__MessageText_AND.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton__MessageText_AND.Location = new System.Drawing.Point(59, 6);
            this.radioButton__MessageText_AND.Name = "radioButton__MessageText_AND";
            this.radioButton__MessageText_AND.Size = new System.Drawing.Size(55, 20);
            this.radioButton__MessageText_AND.TabIndex = 2;
            this.radioButton__MessageText_AND.TabStop = true;
            this.radioButton__MessageText_AND.Text = "AND";
            this.radioButton__MessageText_AND.UseVisualStyleBackColor = true;
            this.radioButton__MessageText_AND.CheckedChanged += new System.EventHandler(this.radioButton__MessageText_AND_CheckedChanged);
            // 
            // label_Users
            // 
            this.label_Users.AutoSize = true;
            this.label_Users.Location = new System.Drawing.Point(259, 19);
            this.label_Users.Name = "label_Users";
            this.label_Users.Size = new System.Drawing.Size(58, 24);
            this.label_Users.TabIndex = 10;
            this.label_Users.Text = "Users";
            // 
            // label__MessageText
            // 
            this.label__MessageText.AutoSize = true;
            this.label__MessageText.Location = new System.Drawing.Point(196, 117);
            this.label__MessageText.Name = "label__MessageText";
            this.label__MessageText.Size = new System.Drawing.Size(121, 24);
            this.label__MessageText.TabIndex = 11;
            this.label__MessageText.Text = "Message text";
            // 
            // label_FromDate
            // 
            this.label_FromDate.AutoSize = true;
            this.label_FromDate.Location = new System.Drawing.Point(221, 210);
            this.label_FromDate.Name = "label_FromDate";
            this.label_FromDate.Size = new System.Drawing.Size(96, 24);
            this.label_FromDate.TabIndex = 12;
            this.label_FromDate.Text = "From date";
            // 
            // label_BeforeDate
            // 
            this.label_BeforeDate.AutoSize = true;
            this.label_BeforeDate.Location = new System.Drawing.Point(211, 261);
            this.label_BeforeDate.Name = "label_BeforeDate";
            this.label_BeforeDate.Size = new System.Drawing.Size(106, 24);
            this.label_BeforeDate.TabIndex = 13;
            this.label_BeforeDate.Text = "Before date";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(185, 198);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(410, 102);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(185, 107);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(410, 44);
            this.panel4.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Location = new System.Drawing.Point(185, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(410, 43);
            this.panel5.TabIndex = 16;
            // 
            // button_StartReceivingMessages
            // 
            this.button_StartReceivingMessages.Location = new System.Drawing.Point(21, 765);
            this.button_StartReceivingMessages.Name = "button_StartReceivingMessages";
            this.button_StartReceivingMessages.Size = new System.Drawing.Size(290, 35);
            this.button_StartReceivingMessages.TabIndex = 17;
            this.button_StartReceivingMessages.Text = "Start receiving messages";
            this.button_StartReceivingMessages.UseVisualStyleBackColor = true;
            this.button_StartReceivingMessages.Click += new System.EventHandler(this.button_StartReceivingMessages_Click);
            // 
            // button_RemoveSelectedMessage
            // 
            this.button_RemoveSelectedMessage.Location = new System.Drawing.Point(471, 765);
            this.button_RemoveSelectedMessage.Name = "button_RemoveSelectedMessage";
            this.button_RemoveSelectedMessage.Size = new System.Drawing.Size(290, 35);
            this.button_RemoveSelectedMessage.TabIndex = 18;
            this.button_RemoveSelectedMessage.Text = "Remove selected message";
            this.button_RemoveSelectedMessage.UseVisualStyleBackColor = true;
            this.button_RemoveSelectedMessage.Click += new System.EventHandler(this.button_RemoveSelectedMessage_Click);
            // 
            // L4_MessageFiltering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 806);
            this.Controls.Add(this.button_RemoveSelectedMessage);
            this.Controls.Add(this.button_StartReceivingMessages);
            this.Controls.Add(this.label_BeforeDate);
            this.Controls.Add(this.label_FromDate);
            this.Controls.Add(this.label__MessageText);
            this.Controls.Add(this.label_Users);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker_BeforeDate);
            this.Controls.Add(this.dateTimePicker_FromDate);
            this.Controls.Add(this.textBox_MessageText);
            this.Controls.Add(this.comboBox_Users);
            this.Controls.Add(this.comboBox_FormattingOptions);
            this.Controls.Add(this.listView_Messages);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 845);
            this.MinimumSize = new System.Drawing.Size(800, 845);
            this.Name = "L4_MessageFiltering";
            this.Text = "L4_MessageFiltering";
            this.Load += new System.EventHandler(this.L4_MessageFiltering_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Messages;
        private System.Windows.Forms.ComboBox comboBox_FormattingOptions;
        private System.Windows.Forms.ComboBox comboBox_Users;
        private System.Windows.Forms.TextBox textBox_MessageText;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FromDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BeforeDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_Users_OR;
        private System.Windows.Forms.RadioButton radioButton_Users_AND;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton__MessageText_OR;
        private System.Windows.Forms.RadioButton radioButton__MessageText_AND;
        private System.Windows.Forms.Label label_Users;
        private System.Windows.Forms.Label label__MessageText;
        private System.Windows.Forms.Label label_FromDate;
        private System.Windows.Forms.Label label_BeforeDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button_StartReceivingMessages;
        private System.Windows.Forms.Button button_RemoveSelectedMessage;
    }
}