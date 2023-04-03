
namespace test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.value1 = new System.Windows.Forms.Label();
            this.value2 = new System.Windows.Forms.Label();
            this.solution = new System.Windows.Forms.Label();
            this.dane1 = new System.Windows.Forms.TextBox();
            this.dane2 = new System.Windows.Forms.TextBox();
            this.dane3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.oblicz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // value1
            // 
            this.value1.AutoSize = true;
            this.value1.Location = new System.Drawing.Point(38, 135);
            this.value1.Name = "value1";
            this.value1.Size = new System.Drawing.Size(16, 15);
            this.value1.TabIndex = 0;
            this.value1.Text = "a:";
            // 
            // value2
            // 
            this.value2.AutoSize = true;
            this.value2.Location = new System.Drawing.Point(38, 184);
            this.value2.Name = "value2";
            this.value2.Size = new System.Drawing.Size(17, 15);
            this.value2.TabIndex = 1;
            this.value2.Text = "b:";
            // 
            // solution
            // 
            this.solution.AutoSize = true;
            this.solution.Location = new System.Drawing.Point(38, 237);
            this.solution.Name = "solution";
            this.solution.Size = new System.Drawing.Size(16, 15);
            this.solution.TabIndex = 2;
            this.solution.Text = "c:";
            // 
            // dane1
            // 
            this.dane1.Location = new System.Drawing.Point(69, 132);
            this.dane1.Name = "dane1";
            this.dane1.Size = new System.Drawing.Size(100, 23);
            this.dane1.TabIndex = 3;
            // 
            // dane2
            // 
            this.dane2.Location = new System.Drawing.Point(69, 181);
            this.dane2.Name = "dane2";
            this.dane2.Size = new System.Drawing.Size(100, 23);
            this.dane2.TabIndex = 4;
            // 
            // dane3
            // 
            this.dane3.Location = new System.Drawing.Point(69, 234);
            this.dane3.Name = "dane3";
            this.dane3.Size = new System.Drawing.Size(100, 23);
            this.dane3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dane";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // oblicz
            // 
            this.oblicz.Location = new System.Drawing.Point(69, 295);
            this.oblicz.Name = "oblicz";
            this.oblicz.Size = new System.Drawing.Size(100, 38);
            this.oblicz.TabIndex = 7;
            this.oblicz.Text = "oblicz";
            this.oblicz.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.oblicz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dane3);
            this.Controls.Add(this.dane2);
            this.Controls.Add(this.dane1);
            this.Controls.Add(this.solution);
            this.Controls.Add(this.value2);
            this.Controls.Add(this.value1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label value1;
        private System.Windows.Forms.Label value2;
        private System.Windows.Forms.Label solution;
        private System.Windows.Forms.TextBox dane1;
        private System.Windows.Forms.TextBox dane2;
        private System.Windows.Forms.TextBox dane3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button oblicz;
    }
}

