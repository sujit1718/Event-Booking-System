namespace FirstDemo
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
            this.btn1 = new System.Windows.Forms.Button();
            this.lable1 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(95, 148);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(104, 45);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Check";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(24, 39);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(109, 13);
            this.lable1.TabIndex = 3;
            this.lable1.Text = "Enter The Leap Year ";
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(168, 39);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(125, 20);
            this.txt.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 310);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.TextBox txt;
    }
}

