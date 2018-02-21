namespace MainForm
{
    partial class DMSKIN315
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
            this.metroButton3 = new DMSkin.Metro.Controls.MetroButton();
            this.metroButton2 = new DMSkin.Metro.Controls.MetroButton();
            this.metroButton1 = new DMSkin.Metro.Controls.MetroButton();
            this.metroButton4 = new DMSkin.Metro.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroButton3
            // 
            this.metroButton3.DM_UseSelectable = true;
            this.metroButton3.Location = new System.Drawing.Point(20, 180);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(109, 29);
            this.metroButton3.TabIndex = 32;
            this.metroButton3.Text = "是否显示分层线条";
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.DM_UseSelectable = true;
            this.metroButton2.Location = new System.Drawing.Point(20, 145);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(109, 29);
            this.metroButton2.TabIndex = 31;
            this.metroButton2.Text = "是否显示最大化";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.DM_UseSelectable = true;
            this.metroButton1.Location = new System.Drawing.Point(20, 110);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(109, 29);
            this.metroButton1.TabIndex = 30;
            this.metroButton1.Text = "系统按钮主题切换";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.DM_UseSelectable = true;
            this.metroButton4.Location = new System.Drawing.Point(20, 215);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(109, 29);
            this.metroButton4.TabIndex = 33;
            this.metroButton4.Text = "是否显示分层阴影";
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // DMSKIN315
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(920, 472);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.DM_SystemButtonShowMax = true;
            this.DM_SystemButtonThemeColor = DMSkin.DMSkinForm.DMColor.Dark;
            this.Name = "DMSKIN315";
            this.Text = "DMSKIN315";
            this.Load += new System.EventHandler(this.DMSKIN315_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DMSkin.Metro.Controls.MetroButton metroButton3;
        private DMSkin.Metro.Controls.MetroButton metroButton2;
        private DMSkin.Metro.Controls.MetroButton metroButton1;
        private DMSkin.Metro.Controls.MetroButton metroButton4;
    }
}