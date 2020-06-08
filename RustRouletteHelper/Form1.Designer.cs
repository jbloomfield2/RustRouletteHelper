namespace RustRouletteHelper
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
            this.txtIn = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl20 = new System.Windows.Forms.Label();
            this.lblSince1 = new System.Windows.Forms.Label();
            this.lblSince3 = new System.Windows.Forms.Label();
            this.lblSince5 = new System.Windows.Forms.Label();
            this.lblSince10 = new System.Windows.Forms.Label();
            this.lblSince20 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtIn
            // 
            this.txtIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIn.Location = new System.Drawing.Point(17, 156);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(100, 29);
            this.txtIn.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(123, 156);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 30);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(13, 13);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(185, 24);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "1 48%   Since Last:";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(13, 42);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(185, 24);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "3 24%   Since Last:";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(13, 71);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(185, 24);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "5 16%   Since Last:";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10.Location = new System.Drawing.Point(13, 100);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(185, 24);
            this.lbl10.TabIndex = 5;
            this.lbl10.Text = "10 8%   Since Last:";
            // 
            // lbl20
            // 
            this.lbl20.AutoSize = true;
            this.lbl20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl20.Location = new System.Drawing.Point(13, 129);
            this.lbl20.Name = "lbl20";
            this.lbl20.Size = new System.Drawing.Size(185, 24);
            this.lbl20.TabIndex = 6;
            this.lbl20.Text = "20 4%   Since Last:";
            // 
            // lblSince1
            // 
            this.lblSince1.AutoSize = true;
            this.lblSince1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSince1.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblSince1.Location = new System.Drawing.Point(228, 13);
            this.lblSince1.Name = "lblSince1";
            this.lblSince1.Size = new System.Drawing.Size(21, 24);
            this.lblSince1.TabIndex = 7;
            this.lblSince1.Text = "?";
            // 
            // lblSince3
            // 
            this.lblSince3.AutoSize = true;
            this.lblSince3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSince3.ForeColor = System.Drawing.Color.Red;
            this.lblSince3.Location = new System.Drawing.Point(228, 42);
            this.lblSince3.Name = "lblSince3";
            this.lblSince3.Size = new System.Drawing.Size(21, 24);
            this.lblSince3.TabIndex = 8;
            this.lblSince3.Text = "?";
            // 
            // lblSince5
            // 
            this.lblSince5.AutoSize = true;
            this.lblSince5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSince5.ForeColor = System.Drawing.Color.Red;
            this.lblSince5.Location = new System.Drawing.Point(228, 71);
            this.lblSince5.Name = "lblSince5";
            this.lblSince5.Size = new System.Drawing.Size(21, 24);
            this.lblSince5.TabIndex = 9;
            this.lblSince5.Text = "?";
            // 
            // lblSince10
            // 
            this.lblSince10.AutoSize = true;
            this.lblSince10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSince10.ForeColor = System.Drawing.Color.Red;
            this.lblSince10.Location = new System.Drawing.Point(228, 100);
            this.lblSince10.Name = "lblSince10";
            this.lblSince10.Size = new System.Drawing.Size(21, 24);
            this.lblSince10.TabIndex = 10;
            this.lblSince10.Text = "?";
            // 
            // lblSince20
            // 
            this.lblSince20.AutoSize = true;
            this.lblSince20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSince20.ForeColor = System.Drawing.Color.Red;
            this.lblSince20.Location = new System.Drawing.Point(228, 129);
            this.lblSince20.Name = "lblSince20";
            this.lblSince20.Size = new System.Drawing.Size(21, 24);
            this.lblSince20.TabIndex = 11;
            this.lblSince20.Text = "?";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(221, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(292, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Unlikely";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(292, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Less Likely";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(292, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Likely";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(296, 107);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Stay on Top";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 195);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSince20);
            this.Controls.Add(this.lblSince10);
            this.Controls.Add(this.lblSince5);
            this.Controls.Add(this.lblSince3);
            this.Controls.Add(this.lblSince1);
            this.Controls.Add(this.lbl20);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtIn);
            this.Name = "Form1";
            this.Text = "RustRouletteHelper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbl20;
        private System.Windows.Forms.Label lblSince1;
        private System.Windows.Forms.Label lblSince3;
        private System.Windows.Forms.Label lblSince5;
        private System.Windows.Forms.Label lblSince10;
        private System.Windows.Forms.Label lblSince20;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

