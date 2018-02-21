namespace MainForm
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnMin = new DMSkin.Controls.DMButtonMin();
            this.btnClose = new DMSkin.Controls.DMButtonClose();
            this.dmTabControl = new DMSkin.Controls.DMTabControl();
            this.myMenu1 = new MainForm.MyMenu();
            this.myMenu2 = new MainForm.MyMenu();
            this.myMenu4 = new MainForm.MyMenu();
            this.myMenu6 = new MainForm.MyMenu();
            this.myMenu5 = new MainForm.MyMenu();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.myMenu3 = new MainForm.MyMenu();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dmTabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.Location = new System.Drawing.Point(943, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 27);
            this.btnMin.TabIndex = 24;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(975, 0);
            this.btnClose.MaximumSize = new System.Drawing.Size(30, 27);
            this.btnClose.MinimumSize = new System.Drawing.Size(30, 27);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 27);
            this.btnClose.TabIndex = 23;
            // 
            // dmTabControl
            // 
            this.dmTabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.dmTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dmTabControl.BackColor = System.Drawing.Color.Transparent;
            this.dmTabControl.Controls.Add(this.tabPage1);
            this.dmTabControl.Controls.Add(this.tabPage2);
            this.dmTabControl.ItemSize = new System.Drawing.Size(80, 32);
            this.dmTabControl.Location = new System.Drawing.Point(-7, 78);
            this.dmTabControl.Name = "dmTabControl";
            this.dmTabControl.SelectedIndex = 0;
            this.dmTabControl.Size = new System.Drawing.Size(1017, 701);
            this.dmTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.dmTabControl.TabIndex = 25;
            // 
            // myMenu1
            // 
            this.myMenu1.BackColor = System.Drawing.Color.Transparent;
            this.myMenu1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myMenu1.BackgroundImage")));
            this.myMenu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myMenu1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myMenu1.Location = new System.Drawing.Point(120, 369);
            this.myMenu1.MyImage = global::MainForm.Properties.Resources.pic__1_;
            this.myMenu1.MyText = "搜索";
            this.myMenu1.Name = "myMenu1";
            this.myMenu1.Size = new System.Drawing.Size(200, 170);
            this.myMenu1.TabIndex = 0;
            // 
            // myMenu2
            // 
            this.myMenu2.BackColor = System.Drawing.Color.Transparent;
            this.myMenu2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myMenu2.BackgroundImage")));
            this.myMenu2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myMenu2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myMenu2.Location = new System.Drawing.Point(418, 369);
            this.myMenu2.MyImage = global::MainForm.Properties.Resources.pic__2_;
            this.myMenu2.MyText = "我的资源";
            this.myMenu2.Name = "myMenu2";
            this.myMenu2.Size = new System.Drawing.Size(200, 170);
            this.myMenu2.TabIndex = 1;
            // 
            // myMenu4
            // 
            this.myMenu4.BackColor = System.Drawing.Color.Transparent;
            this.myMenu4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myMenu4.BackgroundImage")));
            this.myMenu4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myMenu4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myMenu4.Location = new System.Drawing.Point(716, 369);
            this.myMenu4.MyImage = global::MainForm.Properties.Resources.pic__4_;
            this.myMenu4.MyText = "加密文件";
            this.myMenu4.Name = "myMenu4";
            this.myMenu4.Size = new System.Drawing.Size(200, 170);
            this.myMenu4.TabIndex = 3;
            // 
            // myMenu6
            // 
            this.myMenu6.BackColor = System.Drawing.Color.Transparent;
            this.myMenu6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myMenu6.BackgroundImage")));
            this.myMenu6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myMenu6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myMenu6.Location = new System.Drawing.Point(120, 111);
            this.myMenu6.MyImage = global::MainForm.Properties.Resources.pic__7_;
            this.myMenu6.MyText = "视频";
            this.myMenu6.Name = "myMenu6";
            this.myMenu6.Size = new System.Drawing.Size(200, 170);
            this.myMenu6.TabIndex = 4;
            // 
            // myMenu5
            // 
            this.myMenu5.BackColor = System.Drawing.Color.Transparent;
            this.myMenu5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myMenu5.BackgroundImage")));
            this.myMenu5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myMenu5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myMenu5.Location = new System.Drawing.Point(418, 111);
            this.myMenu5.MyImage = global::MainForm.Properties.Resources.pic__6_;
            this.myMenu5.MyText = "音乐";
            this.myMenu5.Name = "myMenu5";
            this.myMenu5.Size = new System.Drawing.Size(200, 170);
            this.myMenu5.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.tabPage2.Controls.Add(this.myMenu3);
            this.tabPage2.Controls.Add(this.myMenu5);
            this.tabPage2.Controls.Add(this.myMenu6);
            this.tabPage2.Controls.Add(this.myMenu4);
            this.tabPage2.Controls.Add(this.myMenu2);
            this.tabPage2.Controls.Add(this.myMenu1);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1009, 661);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // myMenu3
            // 
            this.myMenu3.BackColor = System.Drawing.Color.Transparent;
            this.myMenu3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myMenu3.BackgroundImage")));
            this.myMenu3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myMenu3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myMenu3.Location = new System.Drawing.Point(716, 111);
            this.myMenu3.MyImage = global::MainForm.Properties.Resources.pic__9_;
            this.myMenu3.MyText = "BT种子";
            this.myMenu3.Name = "myMenu3";
            this.myMenu3.Size = new System.Drawing.Size(200, 170);
            this.myMenu3.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1009, 661);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1005, 744);
            this.Controls.Add(this.dmTabControl);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.DM_CanResize = true;
            this.DM_howBorder = false;
            this.DM_Radius = 1;
            this.DM_ShadowWidth = 2;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 450);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DM万能播放器";
            this.Load += new System.EventHandler(this.Main_Load);
            this.dmTabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DMSkin.Controls.DMButtonMin btnMin;
        private DMSkin.Controls.DMButtonClose btnClose;
        private DMSkin.Controls.DMTabControl dmTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MyMenu myMenu3;
        private MyMenu myMenu5;
        private MyMenu myMenu6;
        private MyMenu myMenu4;
        private MyMenu myMenu2;
        private MyMenu myMenu1;
    }
}

