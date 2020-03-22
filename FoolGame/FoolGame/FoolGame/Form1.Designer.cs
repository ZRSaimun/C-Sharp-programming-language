namespace FoolGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.nobtn = new System.Windows.Forms.Button();
            this.yesbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.label1.Location = new System.Drawing.Point(280, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Are You Fool?";
            // 
            // nobtn
            // 
            this.nobtn.BackColor = System.Drawing.Color.Red;
            this.nobtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.nobtn.Location = new System.Drawing.Point(390, 207);
            this.nobtn.Name = "nobtn";
            this.nobtn.Size = new System.Drawing.Size(80, 34);
            this.nobtn.TabIndex = 4;
            this.nobtn.Text = "NO";
            this.nobtn.UseVisualStyleBackColor = false;
            this.nobtn.Click += new System.EventHandler(this.nobtn_Click);
            this.nobtn.MouseEnter += new System.EventHandler(this.MouseEnter);
            // 
            // yesbtn
            // 
            this.yesbtn.BackColor = System.Drawing.Color.Green;
            this.yesbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yesbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.yesbtn.Location = new System.Drawing.Point(302, 208);
            this.yesbtn.Name = "yesbtn";
            this.yesbtn.Size = new System.Drawing.Size(82, 33);
            this.yesbtn.TabIndex = 3;
            this.yesbtn.Text = "YES";
            this.yesbtn.UseVisualStyleBackColor = false;
            this.yesbtn.Click += new System.EventHandler(this.yesbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nobtn);
            this.Controls.Add(this.yesbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nobtn;
        private System.Windows.Forms.Button yesbtn;
    }
}

