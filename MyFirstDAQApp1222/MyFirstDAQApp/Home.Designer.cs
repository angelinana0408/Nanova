namespace MyFirstDAQApp
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.VOCLibrary = new System.Windows.Forms.Button();
            this.Calibrate = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.Button();
            this.CustomMethod = new System.Windows.Forms.Button();
            this.SelectMethod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "What would you like to do?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select Method";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Custom Method";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(435, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "History";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(591, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Calibrate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(743, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "VOC Library";
            // 
            // VOCLibrary
            // 
            this.VOCLibrary.Image = global::MyFirstDAQApp.Properties.Resources.voc_library_icon;
            this.VOCLibrary.Location = new System.Drawing.Point(734, 199);
            this.VOCLibrary.Name = "VOCLibrary";
            this.VOCLibrary.Size = new System.Drawing.Size(112, 111);
            this.VOCLibrary.TabIndex = 4;
            this.VOCLibrary.UseVisualStyleBackColor = true;
            // 
            // Calibrate
            // 
            this.Calibrate.Image = global::MyFirstDAQApp.Properties.Resources.calibrate_icon;
            this.Calibrate.Location = new System.Drawing.Point(571, 199);
            this.Calibrate.Name = "Calibrate";
            this.Calibrate.Size = new System.Drawing.Size(112, 111);
            this.Calibrate.TabIndex = 3;
            this.Calibrate.UseVisualStyleBackColor = true;
            // 
            // History
            // 
            this.History.Image = global::MyFirstDAQApp.Properties.Resources.method_history_icon;
            this.History.Location = new System.Drawing.Point(404, 199);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(112, 111);
            this.History.TabIndex = 2;
            this.History.UseVisualStyleBackColor = true;
            // 
            // CustomMethod
            // 
            this.CustomMethod.Image = global::MyFirstDAQApp.Properties.Resources.custom_method_icon;
            this.CustomMethod.Location = new System.Drawing.Point(245, 199);
            this.CustomMethod.Name = "CustomMethod";
            this.CustomMethod.Size = new System.Drawing.Size(112, 111);
            this.CustomMethod.TabIndex = 1;
            this.CustomMethod.UseVisualStyleBackColor = true;
            this.CustomMethod.Click += new System.EventHandler(this.CustomMethod_Click);
            // 
            // SelectMethod
            // 
            this.SelectMethod.Image = global::MyFirstDAQApp.Properties.Resources.select_method_icon;
            this.SelectMethod.Location = new System.Drawing.Point(80, 199);
            this.SelectMethod.Name = "SelectMethod";
            this.SelectMethod.Size = new System.Drawing.Size(112, 111);
            this.SelectMethod.TabIndex = 0;
            this.SelectMethod.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 704);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VOCLibrary);
            this.Controls.Add(this.Calibrate);
            this.Controls.Add(this.History);
            this.Controls.Add(this.CustomMethod);
            this.Controls.Add(this.SelectMethod);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectMethod;
        private System.Windows.Forms.Button CustomMethod;
        private System.Windows.Forms.Button History;
        private System.Windows.Forms.Button Calibrate;
        private System.Windows.Forms.Button VOCLibrary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}