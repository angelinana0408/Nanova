namespace MainForm
{
    partial class DirectUITEST
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
            DirectUI.DUILabel duiLabel1 = new DirectUI.DUILabel();
            DirectUI.DUILabel duiLabel2 = new DirectUI.DUILabel();
            this.SuspendLayout();
            // 
            // DirectUITEST
            // 
            this.Alpha = 100;
            this.AlphaGauss = 200;
            this.AlphaIsGauss = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MainForm.Properties.Resources.O18590_1360x768;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CanResize = true;
            this.ClientSize = new System.Drawing.Size(302, 287);
            duiLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            duiLabel1.BackImage = null;
            duiLabel1.Enabled = false;
            duiLabel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            duiLabel1.ForeColor = System.Drawing.Color.Black;
            duiLabel1.IsInvalidate = false;
            duiLabel1.Location = new System.Drawing.Point(50, 50);
            duiLabel1.Name = null;
            duiLabel1.Rectangle = new System.Drawing.Rectangle(50, 50, 120, 25);
            duiLabel1.Size = new System.Drawing.Size(120, 25);
            duiLabel1.Text = "DMSkin 强大的Winform界面库";
            duiLabel1.Visible = true;
            duiLabel2.BackColor = System.Drawing.Color.Transparent;
            duiLabel2.BackImage = null;
            duiLabel2.Enabled = false;
            duiLabel2.Font = new System.Drawing.Font("微软雅黑", 9F);
            duiLabel2.ForeColor = System.Drawing.Color.Red;
            duiLabel2.IsInvalidate = false;
            duiLabel2.Location = new System.Drawing.Point(50, 100);
            duiLabel2.Name = null;
            duiLabel2.Rectangle = new System.Drawing.Rectangle(50, 100, 100, 50);
            duiLabel2.Size = new System.Drawing.Size(100, 50);
            duiLabel2.Text = "DirectUI测试界面";
            duiLabel2.Visible = true;
            this.DUIControls.Add(duiLabel1);
            this.DUIControls.Add(duiLabel2);
            this.Name = "DirectUITEST";
            this.Text = "DirectUITEST";
            this.Load += new System.EventHandler(this.DirectUITEST_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}