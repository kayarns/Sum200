namespace Sum200
{
    partial class frmMain
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblHalfWay = new System.Windows.Forms.Label();
            this.txtHalfWay = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.txtTop = new System.Windows.Forms.TextBox();
            this.lblTop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(32, 34);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(109, 54);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblHalfWay
            // 
            this.lblHalfWay.AutoSize = true;
            this.lblHalfWay.Location = new System.Drawing.Point(174, 186);
            this.lblHalfWay.Name = "lblHalfWay";
            this.lblHalfWay.Size = new System.Drawing.Size(142, 25);
            this.lblHalfWay.TabIndex = 1;
            this.lblHalfWay.Text = "Halfway Total";
            // 
            // txtHalfWay
            // 
            this.txtHalfWay.Location = new System.Drawing.Point(41, 183);
            this.txtHalfWay.Name = "txtHalfWay";
            this.txtHalfWay.ReadOnly = true;
            this.txtHalfWay.Size = new System.Drawing.Size(109, 31);
            this.txtHalfWay.TabIndex = 2;
            this.txtHalfWay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(41, 257);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(109, 31);
            this.txtSum.TabIndex = 4;
            this.txtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(174, 260);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(55, 25);
            this.lblSum.TabIndex = 3;
            this.lblSum.Text = "Sum";
            // 
            // txtTop
            // 
            this.txtTop.Location = new System.Drawing.Point(41, 123);
            this.txtTop.Name = "txtTop";
            this.txtTop.Size = new System.Drawing.Size(109, 31);
            this.txtTop.TabIndex = 6;
            this.txtTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Location = new System.Drawing.Point(174, 126);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(110, 25);
            this.lblTop.TabIndex = 5;
            this.lblTop.Text = "Top Value";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 450);
            this.Controls.Add(this.txtTop);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.txtHalfWay);
            this.Controls.Add(this.lblHalfWay);
            this.Controls.Add(this.btnStart);
            this.Name = "frmMain";
            this.Text = "Sum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblHalfWay;
        private System.Windows.Forms.TextBox txtHalfWay;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.TextBox txtTop;
        private System.Windows.Forms.Label lblTop;
    }
}

