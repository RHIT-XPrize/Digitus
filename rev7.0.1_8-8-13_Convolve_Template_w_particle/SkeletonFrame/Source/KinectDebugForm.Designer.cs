namespace KinectHand
{
    partial class KinectDebugForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KinectDebugForm));
            this.MessageBox = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.VersionInfo = new System.Windows.Forms.TextBox();
            this.FPSInfo = new System.Windows.Forms.TextBox();
            this.HandDepth = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MessageBox
            // 
            this.MessageBox.AutoEllipsis = true;
            this.MessageBox.BackColor = System.Drawing.Color.Transparent;
            this.MessageBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageBox.ForeColor = System.Drawing.Color.White;
            this.MessageBox.Location = new System.Drawing.Point(16, 1034);
            this.MessageBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(1653, 90);
            this.MessageBox.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // VersionInfo
            // 
            this.VersionInfo.BackColor = System.Drawing.Color.Black;
            this.VersionInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VersionInfo.ForeColor = System.Drawing.Color.White;
            this.VersionInfo.Location = new System.Drawing.Point(859, 214);
            this.VersionInfo.Margin = new System.Windows.Forms.Padding(4);
            this.VersionInfo.Multiline = true;
            this.VersionInfo.Name = "VersionInfo";
            this.VersionInfo.Size = new System.Drawing.Size(192, 49);
            this.VersionInfo.TabIndex = 6;
            this.VersionInfo.Text = "Version:";
            // 
            // FPSInfo
            // 
            this.FPSInfo.BackColor = System.Drawing.Color.Black;
            this.FPSInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FPSInfo.ForeColor = System.Drawing.Color.White;
            this.FPSInfo.Location = new System.Drawing.Point(859, 270);
            this.FPSInfo.Margin = new System.Windows.Forms.Padding(4);
            this.FPSInfo.Name = "FPSInfo";
            this.FPSInfo.Size = new System.Drawing.Size(192, 15);
            this.FPSInfo.TabIndex = 7;
            this.FPSInfo.Text = "FPS: ";
            // 
            // HandDepth
            // 
            this.HandDepth.BackColor = System.Drawing.Color.Black;
            this.HandDepth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HandDepth.ForeColor = System.Drawing.Color.White;
            this.HandDepth.Location = new System.Drawing.Point(859, 293);
            this.HandDepth.Margin = new System.Windows.Forms.Padding(4);
            this.HandDepth.Name = "HandDepth";
            this.HandDepth.Size = new System.Drawing.Size(192, 15);
            this.HandDepth.TabIndex = 8;
            this.HandDepth.Text = "Hand Depth:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(859, 318);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 21);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Show Angle";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(859, 346);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(125, 21);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Left Hand Only";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(22, 410);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(802, 15);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Hand Depth:";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // KinectDebugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1067, 591);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.HandDepth);
            this.Controls.Add(this.FPSInfo);
            this.Controls.Add(this.VersionInfo);
            this.Controls.Add(this.MessageBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "KinectDebugForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KinectDebug";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MessageBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox VersionInfo;
        private System.Windows.Forms.TextBox FPSInfo;
        private System.Windows.Forms.TextBox HandDepth;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox1;
    }


}

