namespace MobilePhone.WindowsFormsApp
{
    partial class L3_MessageFormatting
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
            this.richTextBox_MessageOutBox = new System.Windows.Forms.RichTextBox();
            this.comboBox_FormattingOptions = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // richTextBox_MessageOutBox
            // 
            this.richTextBox_MessageOutBox.Location = new System.Drawing.Point(25, 70);
            this.richTextBox_MessageOutBox.Name = "richTextBox_MessageOutBox";
            this.richTextBox_MessageOutBox.Size = new System.Drawing.Size(700, 500);
            this.richTextBox_MessageOutBox.TabIndex = 0;
            this.richTextBox_MessageOutBox.Text = "";
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
            this.comboBox_FormattingOptions.Location = new System.Drawing.Point(25, 20);
            this.comboBox_FormattingOptions.Name = "comboBox_FormattingOptions";
            this.comboBox_FormattingOptions.Size = new System.Drawing.Size(400, 32);
            this.comboBox_FormattingOptions.TabIndex = 2;
            this.comboBox_FormattingOptions.Text = "None";
            // 
            // L3_MessageFormatting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 591);
            this.Controls.Add(this.comboBox_FormattingOptions);
            this.Controls.Add(this.richTextBox_MessageOutBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "L3_MessageFormatting";
            this.Text = "L3_MessageFormatting";
            this.Load += new System.EventHandler(this.L3_MessageFormatting_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_MessageOutBox;
        private System.Windows.Forms.ComboBox comboBox_FormattingOptions;
    }
}