namespace RollDiced
{
    partial class Form1
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
            this.btn_Roll = new System.Windows.Forms.Button();
            this.txt_Roll = new System.Windows.Forms.TextBox();
            this.results = new System.Windows.Forms.TextBox();
            this.isWild = new System.Windows.Forms.CheckBox();
            this.isCritical = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_Roll
            // 
            this.btn_Roll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Roll.Location = new System.Drawing.Point(149, 44);
            this.btn_Roll.Name = "btn_Roll";
            this.btn_Roll.Size = new System.Drawing.Size(123, 44);
            this.btn_Roll.TabIndex = 1;
            this.btn_Roll.Text = "Roll Dice";
            this.btn_Roll.UseVisualStyleBackColor = true;
            this.btn_Roll.Click += new System.EventHandler(this.btn_Roll_Click);
            // 
            // txt_Roll
            // 
            this.txt_Roll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Roll.Location = new System.Drawing.Point(149, 12);
            this.txt_Roll.Name = "txt_Roll";
            this.txt_Roll.Size = new System.Drawing.Size(123, 26);
            this.txt_Roll.TabIndex = 0;
            // 
            // results
            // 
            this.results.Cursor = System.Windows.Forms.Cursors.Default;
            this.results.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.results.Location = new System.Drawing.Point(12, 94);
            this.results.Multiline = true;
            this.results.Name = "results";
            this.results.ReadOnly = true;
            this.results.Size = new System.Drawing.Size(260, 155);
            this.results.TabIndex = 2;
            // 
            // isWild
            // 
            this.isWild.AutoSize = true;
            this.isWild.Location = new System.Drawing.Point(12, 12);
            this.isWild.Name = "isWild";
            this.isWild.Size = new System.Drawing.Size(66, 17);
            this.isWild.TabIndex = 3;
            this.isWild.Text = "Wild Die";
            this.isWild.UseVisualStyleBackColor = true;
            // 
            // isCritical
            // 
            this.isCritical.AutoSize = true;
            this.isCritical.Location = new System.Drawing.Point(12, 35);
            this.isCritical.Name = "isCritical";
            this.isCritical.Size = new System.Drawing.Size(76, 17);
            this.isCritical.TabIndex = 4;
            this.isCritical.Text = "Critical Fail";
            this.isCritical.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.isCritical);
            this.Controls.Add(this.isWild);
            this.Controls.Add(this.results);
            this.Controls.Add(this.txt_Roll);
            this.Controls.Add(this.btn_Roll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Dice Roller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Roll;
        private System.Windows.Forms.TextBox txt_Roll;
        private System.Windows.Forms.TextBox results;
        private System.Windows.Forms.CheckBox isWild;
        private System.Windows.Forms.CheckBox isCritical;
    }
}

