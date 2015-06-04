namespace RollDiced
{
    partial class settings
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
            this.chk_PlaySound = new System.Windows.Forms.CheckBox();
            this.chk_ClearUI = new System.Windows.Forms.CheckBox();
            this.btn_SaveSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chk_PlaySound
            // 
            this.chk_PlaySound.AutoSize = true;
            this.chk_PlaySound.Location = new System.Drawing.Point(12, 12);
            this.chk_PlaySound.Name = "chk_PlaySound";
            this.chk_PlaySound.Size = new System.Drawing.Size(80, 17);
            this.chk_PlaySound.TabIndex = 0;
            this.chk_PlaySound.Text = "Play Sound";
            this.chk_PlaySound.UseVisualStyleBackColor = true;
            // 
            // chk_ClearUI
            // 
            this.chk_ClearUI.AutoSize = true;
            this.chk_ClearUI.Location = new System.Drawing.Point(12, 35);
            this.chk_ClearUI.Name = "chk_ClearUI";
            this.chk_ClearUI.Size = new System.Drawing.Size(66, 17);
            this.chk_ClearUI.TabIndex = 1;
            this.chk_ClearUI.Text = "Clear roll";
            this.chk_ClearUI.UseVisualStyleBackColor = true;
            // 
            // btn_SaveSettings
            // 
            this.btn_SaveSettings.Location = new System.Drawing.Point(12, 120);
            this.btn_SaveSettings.Name = "btn_SaveSettings";
            this.btn_SaveSettings.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveSettings.TabIndex = 2;
            this.btn_SaveSettings.Text = "Save Settings";
            this.btn_SaveSettings.UseVisualStyleBackColor = true;
            this.btn_SaveSettings.Click += new System.EventHandler(this.btn_SaveSettings_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 155);
            this.Controls.Add(this.btn_SaveSettings);
            this.Controls.Add(this.chk_ClearUI);
            this.Controls.Add(this.chk_PlaySound);
            this.Name = "settings";
            this.Text = "settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_PlaySound;
        private System.Windows.Forms.CheckBox chk_ClearUI;
        private System.Windows.Forms.Button btn_SaveSettings;
    }
}