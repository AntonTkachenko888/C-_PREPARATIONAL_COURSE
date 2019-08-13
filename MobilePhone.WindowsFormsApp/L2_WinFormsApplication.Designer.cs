namespace MobilePhone.WindowsFormsApp
{
    partial class L2_WinFormsApplication
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
            this.panelPlayback = new System.Windows.Forms.Panel();
            this.button_ApplyPlayback = new System.Windows.Forms.Button();
            this.label_SelectPlaybackComponent = new System.Windows.Forms.Label();
            this.radioButton_PhoneSpeaker = new System.Windows.Forms.RadioButton();
            this.radioButton_UnofficialiPhoneHeadset = new System.Windows.Forms.RadioButton();
            this.radioButton_SamsungHeadset = new System.Windows.Forms.RadioButton();
            this.radioButton_iPhoneHeadset = new System.Windows.Forms.RadioButton();
            this.panelCharge = new System.Windows.Forms.Panel();
            this.button_ApplyCharger = new System.Windows.Forms.Button();
            this.label_SelectChargerComponent = new System.Windows.Forms.Label();
            this.radioButton_UsualCharge = new System.Windows.Forms.RadioButton();
            this.radioButton_FastCharge = new System.Windows.Forms.RadioButton();
            this.richTextBoxOutWindow = new System.Windows.Forms.RichTextBox();
            this.button_Clean = new System.Windows.Forms.Button();
            this.labelCurentPhone = new System.Windows.Forms.Label();
            this.panelPlayback.SuspendLayout();
            this.panelCharge.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPlayback
            // 
            this.panelPlayback.BackColor = System.Drawing.SystemColors.Control;
            this.panelPlayback.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPlayback.Controls.Add(this.button_ApplyPlayback);
            this.panelPlayback.Controls.Add(this.label_SelectPlaybackComponent);
            this.panelPlayback.Controls.Add(this.radioButton_PhoneSpeaker);
            this.panelPlayback.Controls.Add(this.radioButton_UnofficialiPhoneHeadset);
            this.panelPlayback.Controls.Add(this.radioButton_SamsungHeadset);
            this.panelPlayback.Controls.Add(this.radioButton_iPhoneHeadset);
            this.panelPlayback.Location = new System.Drawing.Point(29, 40);
            this.panelPlayback.Margin = new System.Windows.Forms.Padding(6);
            this.panelPlayback.Name = "panelPlayback";
            this.panelPlayback.Size = new System.Drawing.Size(336, 260);
            this.panelPlayback.TabIndex = 0;
            // 
            // button_ApplyPlayback
            // 
            this.button_ApplyPlayback.Location = new System.Drawing.Point(230, 210);
            this.button_ApplyPlayback.Name = "button_ApplyPlayback";
            this.button_ApplyPlayback.Size = new System.Drawing.Size(75, 34);
            this.button_ApplyPlayback.TabIndex = 5;
            this.button_ApplyPlayback.Text = "Apply";
            this.button_ApplyPlayback.UseVisualStyleBackColor = true;
            this.button_ApplyPlayback.Click += new System.EventHandler(this.button_ApplyPlayback_Click);
            // 
            // label_SelectPlaybackComponent
            // 
            this.label_SelectPlaybackComponent.AutoSize = true;
            this.label_SelectPlaybackComponent.Location = new System.Drawing.Point(38, 21);
            this.label_SelectPlaybackComponent.Name = "label_SelectPlaybackComponent";
            this.label_SelectPlaybackComponent.Size = new System.Drawing.Size(247, 24);
            this.label_SelectPlaybackComponent.TabIndex = 4;
            this.label_SelectPlaybackComponent.Text = "Select playback component:";
            // 
            // radioButton_PhoneSpeaker
            // 
            this.radioButton_PhoneSpeaker.AutoSize = true;
            this.radioButton_PhoneSpeaker.Location = new System.Drawing.Point(31, 169);
            this.radioButton_PhoneSpeaker.Margin = new System.Windows.Forms.Padding(6);
            this.radioButton_PhoneSpeaker.Name = "radioButton_PhoneSpeaker";
            this.radioButton_PhoneSpeaker.Size = new System.Drawing.Size(154, 28);
            this.radioButton_PhoneSpeaker.TabIndex = 3;
            this.radioButton_PhoneSpeaker.Text = "PhoneSpeaker";
            this.radioButton_PhoneSpeaker.UseVisualStyleBackColor = true;
            this.radioButton_PhoneSpeaker.CheckedChanged += new System.EventHandler(this.radioButton_PhoneSpeaker_CheckedChanged);
            // 
            // radioButton_UnofficialiPhoneHeadset
            // 
            this.radioButton_UnofficialiPhoneHeadset.AutoSize = true;
            this.radioButton_UnofficialiPhoneHeadset.Location = new System.Drawing.Point(31, 131);
            this.radioButton_UnofficialiPhoneHeadset.Margin = new System.Windows.Forms.Padding(6);
            this.radioButton_UnofficialiPhoneHeadset.Name = "radioButton_UnofficialiPhoneHeadset";
            this.radioButton_UnofficialiPhoneHeadset.Size = new System.Drawing.Size(233, 28);
            this.radioButton_UnofficialiPhoneHeadset.TabIndex = 2;
            this.radioButton_UnofficialiPhoneHeadset.Text = "UnofficialiPhoneHeadset";
            this.radioButton_UnofficialiPhoneHeadset.UseVisualStyleBackColor = true;
            this.radioButton_UnofficialiPhoneHeadset.CheckedChanged += new System.EventHandler(this.radioButton_UnofficialiPhoneHeadset_CheckedChanged);
            // 
            // radioButton_SamsungHeadset
            // 
            this.radioButton_SamsungHeadset.AutoSize = true;
            this.radioButton_SamsungHeadset.Location = new System.Drawing.Point(31, 93);
            this.radioButton_SamsungHeadset.Margin = new System.Windows.Forms.Padding(6);
            this.radioButton_SamsungHeadset.Name = "radioButton_SamsungHeadset";
            this.radioButton_SamsungHeadset.Size = new System.Drawing.Size(178, 28);
            this.radioButton_SamsungHeadset.TabIndex = 1;
            this.radioButton_SamsungHeadset.Text = "SamsungHeadset";
            this.radioButton_SamsungHeadset.UseVisualStyleBackColor = true;
            this.radioButton_SamsungHeadset.CheckedChanged += new System.EventHandler(this.radioButton_SamsungHeadset_CheckedChanged);
            // 
            // radioButton_iPhoneHeadset
            // 
            this.radioButton_iPhoneHeadset.AutoSize = true;
            this.radioButton_iPhoneHeadset.Checked = true;
            this.radioButton_iPhoneHeadset.Location = new System.Drawing.Point(31, 55);
            this.radioButton_iPhoneHeadset.Margin = new System.Windows.Forms.Padding(6);
            this.radioButton_iPhoneHeadset.Name = "radioButton_iPhoneHeadset";
            this.radioButton_iPhoneHeadset.Size = new System.Drawing.Size(158, 28);
            this.radioButton_iPhoneHeadset.TabIndex = 0;
            this.radioButton_iPhoneHeadset.TabStop = true;
            this.radioButton_iPhoneHeadset.Text = "iPhoneHeadset";
            this.radioButton_iPhoneHeadset.UseVisualStyleBackColor = true;
            this.radioButton_iPhoneHeadset.CheckedChanged += new System.EventHandler(this.radioButton_iPhoneHeadset_CheckedChanged);
            // 
            // panelCharge
            // 
            this.panelCharge.BackColor = System.Drawing.SystemColors.Control;
            this.panelCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCharge.Controls.Add(this.button_ApplyCharger);
            this.panelCharge.Controls.Add(this.label_SelectChargerComponent);
            this.panelCharge.Controls.Add(this.radioButton_UsualCharge);
            this.panelCharge.Controls.Add(this.radioButton_FastCharge);
            this.panelCharge.Location = new System.Drawing.Point(404, 40);
            this.panelCharge.Margin = new System.Windows.Forms.Padding(6);
            this.panelCharge.Name = "panelCharge";
            this.panelCharge.Size = new System.Drawing.Size(312, 260);
            this.panelCharge.TabIndex = 1;
            // 
            // button_ApplyCharger
            // 
            this.button_ApplyCharger.Location = new System.Drawing.Point(204, 207);
            this.button_ApplyCharger.Name = "button_ApplyCharger";
            this.button_ApplyCharger.Size = new System.Drawing.Size(75, 34);
            this.button_ApplyCharger.TabIndex = 3;
            this.button_ApplyCharger.Text = "Apply";
            this.button_ApplyCharger.UseVisualStyleBackColor = true;
            this.button_ApplyCharger.Click += new System.EventHandler(this.button_ApplyCharger_Click);
            // 
            // label_SelectChargerComponent
            // 
            this.label_SelectChargerComponent.AutoSize = true;
            this.label_SelectChargerComponent.Location = new System.Drawing.Point(33, 21);
            this.label_SelectChargerComponent.Name = "label_SelectChargerComponent";
            this.label_SelectChargerComponent.Size = new System.Drawing.Size(238, 24);
            this.label_SelectChargerComponent.TabIndex = 2;
            this.label_SelectChargerComponent.Text = "Select charger component:";
            // 
            // radioButton_UsualCharge
            // 
            this.radioButton_UsualCharge.AutoSize = true;
            this.radioButton_UsualCharge.Location = new System.Drawing.Point(28, 93);
            this.radioButton_UsualCharge.Name = "radioButton_UsualCharge";
            this.radioButton_UsualCharge.Size = new System.Drawing.Size(137, 28);
            this.radioButton_UsualCharge.TabIndex = 1;
            this.radioButton_UsualCharge.Text = "UsualCharge";
            this.radioButton_UsualCharge.UseVisualStyleBackColor = true;
            this.radioButton_UsualCharge.CheckedChanged += new System.EventHandler(this.radioButton_UsualCharge_CheckedChanged);
            // 
            // radioButton_FastCharge
            // 
            this.radioButton_FastCharge.AutoSize = true;
            this.radioButton_FastCharge.Checked = true;
            this.radioButton_FastCharge.Location = new System.Drawing.Point(28, 57);
            this.radioButton_FastCharge.Name = "radioButton_FastCharge";
            this.radioButton_FastCharge.Size = new System.Drawing.Size(125, 28);
            this.radioButton_FastCharge.TabIndex = 0;
            this.radioButton_FastCharge.TabStop = true;
            this.radioButton_FastCharge.Text = "FastCharge";
            this.radioButton_FastCharge.UseVisualStyleBackColor = true;
            this.radioButton_FastCharge.CheckedChanged += new System.EventHandler(this.radioButton_FastCharge_CheckedChanged);
            // 
            // richTextBoxOutWindow
            // 
            this.richTextBoxOutWindow.Location = new System.Drawing.Point(29, 325);
            this.richTextBoxOutWindow.Name = "richTextBoxOutWindow";
            this.richTextBoxOutWindow.Size = new System.Drawing.Size(687, 384);
            this.richTextBoxOutWindow.TabIndex = 2;
            this.richTextBoxOutWindow.Text = "";
            // 
            // button_Clean
            // 
            this.button_Clean.Location = new System.Drawing.Point(638, 729);
            this.button_Clean.Name = "button_Clean";
            this.button_Clean.Size = new System.Drawing.Size(75, 36);
            this.button_Clean.TabIndex = 3;
            this.button_Clean.Text = "Clean";
            this.button_Clean.UseVisualStyleBackColor = true;
            this.button_Clean.Click += new System.EventHandler(this.button_Clean_Click);
            // 
            // labelCurentPhone
            // 
            this.labelCurentPhone.AutoSize = true;
            this.labelCurentPhone.Location = new System.Drawing.Point(232, 8);
            this.labelCurentPhone.Name = "labelCurentPhone";
            this.labelCurentPhone.Size = new System.Drawing.Size(131, 24);
            this.labelCurentPhone.TabIndex = 4;
            this.labelCurentPhone.Text = "Curent phone:";
            // 
            // L2_WinFormsApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 785);
            this.Controls.Add(this.labelCurentPhone);
            this.Controls.Add(this.button_Clean);
            this.Controls.Add(this.richTextBoxOutWindow);
            this.Controls.Add(this.panelCharge);
            this.Controls.Add(this.panelPlayback);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "L2_WinFormsApplication";
            this.Text = "L2_WinFormsApplication";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelPlayback.ResumeLayout(false);
            this.panelPlayback.PerformLayout();
            this.panelCharge.ResumeLayout(false);
            this.panelCharge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPlayback;
        private System.Windows.Forms.RadioButton radioButton_PhoneSpeaker;
        private System.Windows.Forms.RadioButton radioButton_UnofficialiPhoneHeadset;
        private System.Windows.Forms.RadioButton radioButton_SamsungHeadset;
        private System.Windows.Forms.RadioButton radioButton_iPhoneHeadset;
        private System.Windows.Forms.Panel panelCharge;
        private System.Windows.Forms.RadioButton radioButton_UsualCharge;
        private System.Windows.Forms.RadioButton radioButton_FastCharge;
        private System.Windows.Forms.Button button_ApplyPlayback;
        private System.Windows.Forms.Label label_SelectPlaybackComponent;
        private System.Windows.Forms.Label label_SelectChargerComponent;
        private System.Windows.Forms.Button button_ApplyCharger;
        private System.Windows.Forms.RichTextBox richTextBoxOutWindow;
        private System.Windows.Forms.Button button_Clean;
        private System.Windows.Forms.Label labelCurentPhone;
    }
}

