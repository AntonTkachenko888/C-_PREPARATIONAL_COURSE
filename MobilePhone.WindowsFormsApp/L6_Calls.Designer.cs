namespace MobilePhone.WindowsFormsApp
{
    partial class L6_Calls
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
            this.listView_Calls = new System.Windows.Forms.ListView();
            this.textBox_ContactName = new System.Windows.Forms.TextBox();
            this.textBox_ContactLastName = new System.Windows.Forms.TextBox();
            this.richTextBox_ContactNumbers = new System.Windows.Forms.RichTextBox();
            this.label_ContactName = new System.Windows.Forms.Label();
            this.label_ContactLastName = new System.Windows.Forms.Label();
            this.label_ContactNumbers = new System.Windows.Forms.Label();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_Add_Contact = new System.Windows.Forms.Button();
            this.button_RemoveContact = new System.Windows.Forms.Button();
            this.button_AddNumberToContact = new System.Windows.Forms.Button();
            this.label_CurrentCallNumber = new System.Windows.Forms.Label();
            this.textBox_CurrentCallNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView_Calls
            // 
            this.listView_Calls.Location = new System.Drawing.Point(12, 325);
            this.listView_Calls.Name = "listView_Calls";
            this.listView_Calls.Size = new System.Drawing.Size(560, 425);
            this.listView_Calls.TabIndex = 0;
            this.listView_Calls.UseCompatibleStateImageBehavior = false;
            // 
            // textBox_ContactName
            // 
            this.textBox_ContactName.Location = new System.Drawing.Point(185, 41);
            this.textBox_ContactName.Name = "textBox_ContactName";
            this.textBox_ContactName.Size = new System.Drawing.Size(195, 29);
            this.textBox_ContactName.TabIndex = 1;
            // 
            // textBox_ContactLastName
            // 
            this.textBox_ContactLastName.Location = new System.Drawing.Point(185, 76);
            this.textBox_ContactLastName.Name = "textBox_ContactLastName";
            this.textBox_ContactLastName.Size = new System.Drawing.Size(195, 29);
            this.textBox_ContactLastName.TabIndex = 2;
            // 
            // richTextBox_ContactNumbers
            // 
            this.richTextBox_ContactNumbers.Enabled = false;
            this.richTextBox_ContactNumbers.Location = new System.Drawing.Point(391, 40);
            this.richTextBox_ContactNumbers.Name = "richTextBox_ContactNumbers";
            this.richTextBox_ContactNumbers.Size = new System.Drawing.Size(181, 143);
            this.richTextBox_ContactNumbers.TabIndex = 3;
            this.richTextBox_ContactNumbers.Text = "";
            // 
            // label_ContactName
            // 
            this.label_ContactName.AutoSize = true;
            this.label_ContactName.Location = new System.Drawing.Point(57, 43);
            this.label_ContactName.Name = "label_ContactName";
            this.label_ContactName.Size = new System.Drawing.Size(126, 24);
            this.label_ContactName.TabIndex = 4;
            this.label_ContactName.Text = "Contact name";
            // 
            // label_ContactLastName
            // 
            this.label_ContactLastName.AutoSize = true;
            this.label_ContactLastName.Location = new System.Drawing.Point(25, 78);
            this.label_ContactLastName.Name = "label_ContactLastName";
            this.label_ContactLastName.Size = new System.Drawing.Size(158, 24);
            this.label_ContactLastName.TabIndex = 5;
            this.label_ContactLastName.Text = "Contact last name";
            // 
            // label_ContactNumbers
            // 
            this.label_ContactNumbers.AutoSize = true;
            this.label_ContactNumbers.Location = new System.Drawing.Point(405, 13);
            this.label_ContactNumbers.Name = "label_ContactNumbers";
            this.label_ContactNumbers.Size = new System.Drawing.Size(153, 24);
            this.label_ContactNumbers.TabIndex = 6;
            this.label_ContactNumbers.Text = "Contact numbers";
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(12, 281);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(75, 34);
            this.button_Back.TabIndex = 7;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = true;
            // 
            // button_Add_Contact
            // 
            this.button_Add_Contact.Location = new System.Drawing.Point(11, 189);
            this.button_Add_Contact.Name = "button_Add_Contact";
            this.button_Add_Contact.Size = new System.Drawing.Size(278, 34);
            this.button_Add_Contact.TabIndex = 8;
            this.button_Add_Contact.Text = "Add contact";
            this.button_Add_Contact.UseVisualStyleBackColor = true;
            // 
            // button_RemoveContact
            // 
            this.button_RemoveContact.Location = new System.Drawing.Point(294, 189);
            this.button_RemoveContact.Name = "button_RemoveContact";
            this.button_RemoveContact.Size = new System.Drawing.Size(278, 34);
            this.button_RemoveContact.TabIndex = 9;
            this.button_RemoveContact.Text = "Remove contact";
            this.button_RemoveContact.UseVisualStyleBackColor = true;
            // 
            // button_AddNumberToContact
            // 
            this.button_AddNumberToContact.Location = new System.Drawing.Point(11, 149);
            this.button_AddNumberToContact.Name = "button_AddNumberToContact";
            this.button_AddNumberToContact.Size = new System.Drawing.Size(369, 34);
            this.button_AddNumberToContact.TabIndex = 10;
            this.button_AddNumberToContact.Text = "Add number to contact";
            this.button_AddNumberToContact.UseVisualStyleBackColor = true;
            // 
            // label_CurrentCallNumber
            // 
            this.label_CurrentCallNumber.AutoSize = true;
            this.label_CurrentCallNumber.Location = new System.Drawing.Point(7, 113);
            this.label_CurrentCallNumber.Name = "label_CurrentCallNumber";
            this.label_CurrentCallNumber.Size = new System.Drawing.Size(176, 24);
            this.label_CurrentCallNumber.TabIndex = 12;
            this.label_CurrentCallNumber.Text = "Current call number";
            // 
            // textBox_CurrentCallNumber
            // 
            this.textBox_CurrentCallNumber.Enabled = false;
            this.textBox_CurrentCallNumber.Location = new System.Drawing.Point(185, 111);
            this.textBox_CurrentCallNumber.Name = "textBox_CurrentCallNumber";
            this.textBox_CurrentCallNumber.Size = new System.Drawing.Size(195, 29);
            this.textBox_CurrentCallNumber.TabIndex = 11;
            // 
            // L6_Calls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.label_CurrentCallNumber);
            this.Controls.Add(this.textBox_CurrentCallNumber);
            this.Controls.Add(this.button_AddNumberToContact);
            this.Controls.Add(this.button_RemoveContact);
            this.Controls.Add(this.button_Add_Contact);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.label_ContactNumbers);
            this.Controls.Add(this.label_ContactLastName);
            this.Controls.Add(this.label_ContactName);
            this.Controls.Add(this.richTextBox_ContactNumbers);
            this.Controls.Add(this.textBox_ContactLastName);
            this.Controls.Add(this.textBox_ContactName);
            this.Controls.Add(this.listView_Calls);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "L6_Calls";
            this.Text = "L6_Calls";
            this.Load += new System.EventHandler(this.L6_Calls_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Calls;
        private System.Windows.Forms.TextBox textBox_ContactName;
        private System.Windows.Forms.TextBox textBox_ContactLastName;
        private System.Windows.Forms.RichTextBox richTextBox_ContactNumbers;
        private System.Windows.Forms.Label label_ContactName;
        private System.Windows.Forms.Label label_ContactLastName;
        private System.Windows.Forms.Label label_ContactNumbers;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_Add_Contact;
        private System.Windows.Forms.Button button_RemoveContact;
        private System.Windows.Forms.Button button_AddNumberToContact;
        private System.Windows.Forms.Label label_CurrentCallNumber;
        private System.Windows.Forms.TextBox textBox_CurrentCallNumber;
    }
}