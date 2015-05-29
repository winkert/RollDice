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
            this.isWild = new System.Windows.Forms.CheckBox();
            this.isCritical = new System.Windows.Forms.CheckBox();
            this.ResultPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Roll
            // 
            this.btn_Roll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Roll.Location = new System.Drawing.Point(195, 59);
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
            this.txt_Roll.Location = new System.Drawing.Point(195, 27);
            this.txt_Roll.Name = "txt_Roll";
            this.txt_Roll.Size = new System.Drawing.Size(123, 26);
            this.txt_Roll.TabIndex = 0;
            this.txt_Roll.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Roll_KeyPress);
            // 
            // isWild
            // 
            this.isWild.AutoSize = true;
            this.isWild.Location = new System.Drawing.Point(12, 27);
            this.isWild.Name = "isWild";
            this.isWild.Size = new System.Drawing.Size(66, 17);
            this.isWild.TabIndex = 3;
            this.isWild.Text = "Wild Die";
            this.isWild.UseVisualStyleBackColor = true;
            // 
            // isCritical
            // 
            this.isCritical.AutoSize = true;
            this.isCritical.Location = new System.Drawing.Point(12, 50);
            this.isCritical.Name = "isCritical";
            this.isCritical.Size = new System.Drawing.Size(76, 17);
            this.isCritical.TabIndex = 4;
            this.isCritical.Text = "Critical Fail";
            this.isCritical.UseVisualStyleBackColor = true;
            // 
            // ResultPanel
            // 
            this.ResultPanel.AutoScroll = true;
            this.ResultPanel.Location = new System.Drawing.Point(12, 109);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.Size = new System.Drawing.Size(306, 304);
            this.ResultPanel.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 73);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Combine Rolls";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(12, 422);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 7;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(330, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Visible = false;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 457);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ResultPanel);
            this.Controls.Add(this.isCritical);
            this.Controls.Add(this.isWild);
            this.Controls.Add(this.txt_Roll);
            this.Controls.Add(this.btn_Roll);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Dice Roller";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Roll;
        private System.Windows.Forms.TextBox txt_Roll;
        private System.Windows.Forms.CheckBox isWild;
        private System.Windows.Forms.CheckBox isCritical;
        private System.Windows.Forms.FlowLayoutPanel ResultPanel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

