
namespace prosty_kalkulator
{
    partial class MainForm
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
            this.labelFirstNumber = new System.Windows.Forms.Label();
            this.textBoxFirstNumber = new System.Windows.Forms.TextBox();
            this.textBoxSecondNumber = new System.Windows.Forms.TextBox();
            this.labelsecondNumber = new System.Windows.Forms.Label();
            this.buttonDodawanie = new System.Windows.Forms.Button();
            this.buttonOdejmowanie = new System.Windows.Forms.Button();
            this.buttonMnozenie = new System.Windows.Forms.Button();
            this.buttonDzielenoie = new System.Windows.Forms.Button();
            this.labelWynik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFirstNumber
            // 
            this.labelFirstNumber.AutoSize = true;
            this.labelFirstNumber.Location = new System.Drawing.Point(87, 46);
            this.labelFirstNumber.Name = "labelFirstNumber";
            this.labelFirstNumber.Size = new System.Drawing.Size(88, 15);
            this.labelFirstNumber.TabIndex = 0;
            this.labelFirstNumber.Text = "Pierwsza Liczba";
            // 
            // textBoxFirstNumber
            // 
            this.textBoxFirstNumber.Location = new System.Drawing.Point(87, 68);
            this.textBoxFirstNumber.Name = "textBoxFirstNumber";
            this.textBoxFirstNumber.Size = new System.Drawing.Size(95, 23);
            this.textBoxFirstNumber.TabIndex = 1;
            // 
            // textBoxSecondNumber
            // 
            this.textBoxSecondNumber.Location = new System.Drawing.Point(293, 68);
            this.textBoxSecondNumber.Name = "textBoxSecondNumber";
            this.textBoxSecondNumber.Size = new System.Drawing.Size(95, 23);
            this.textBoxSecondNumber.TabIndex = 3;
            // 
            // labelsecondNumber
            // 
            this.labelsecondNumber.AutoSize = true;
            this.labelsecondNumber.Location = new System.Drawing.Point(293, 46);
            this.labelsecondNumber.Name = "labelsecondNumber";
            this.labelsecondNumber.Size = new System.Drawing.Size(75, 15);
            this.labelsecondNumber.TabIndex = 2;
            this.labelsecondNumber.Text = "Druga Liczba";
            // 
            // buttonDodawanie
            // 
            this.buttonDodawanie.Location = new System.Drawing.Point(26, 111);
            this.buttonDodawanie.Name = "buttonDodawanie";
            this.buttonDodawanie.Size = new System.Drawing.Size(75, 23);
            this.buttonDodawanie.TabIndex = 4;
            this.buttonDodawanie.Text = "+";
            this.buttonDodawanie.UseVisualStyleBackColor = true;
            this.buttonDodawanie.Click += new System.EventHandler(this.buttonDodawanie_Click);
            // 
            // buttonOdejmowanie
            // 
            this.buttonOdejmowanie.Location = new System.Drawing.Point(150, 111);
            this.buttonOdejmowanie.Name = "buttonOdejmowanie";
            this.buttonOdejmowanie.Size = new System.Drawing.Size(75, 23);
            this.buttonOdejmowanie.TabIndex = 5;
            this.buttonOdejmowanie.Text = "-";
            this.buttonOdejmowanie.UseVisualStyleBackColor = true;
            // 
            // buttonMnozenie
            // 
            this.buttonMnozenie.Location = new System.Drawing.Point(274, 111);
            this.buttonMnozenie.Name = "buttonMnozenie";
            this.buttonMnozenie.Size = new System.Drawing.Size(75, 23);
            this.buttonMnozenie.TabIndex = 6;
            this.buttonMnozenie.Text = "*";
            this.buttonMnozenie.UseVisualStyleBackColor = true;
            // 
            // buttonDzielenoie
            // 
            this.buttonDzielenoie.Location = new System.Drawing.Point(394, 111);
            this.buttonDzielenoie.Name = "buttonDzielenoie";
            this.buttonDzielenoie.Size = new System.Drawing.Size(75, 23);
            this.buttonDzielenoie.TabIndex = 7;
            this.buttonDzielenoie.Text = "/";
            this.buttonDzielenoie.UseVisualStyleBackColor = true;
            // 
            // labelWynik
            // 
            this.labelWynik.AutoSize = true;
            this.labelWynik.Location = new System.Drawing.Point(87, 197);
            this.labelWynik.Name = "labelWynik";
            this.labelWynik.Size = new System.Drawing.Size(0, 15);
            this.labelWynik.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 222);
            this.Controls.Add(this.labelWynik);
            this.Controls.Add(this.buttonDzielenoie);
            this.Controls.Add(this.buttonMnozenie);
            this.Controls.Add(this.buttonOdejmowanie);
            this.Controls.Add(this.buttonDodawanie);
            this.Controls.Add(this.textBoxSecondNumber);
            this.Controls.Add(this.labelsecondNumber);
            this.Controls.Add(this.textBoxFirstNumber);
            this.Controls.Add(this.labelFirstNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Kalkulator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstNumber;
        private System.Windows.Forms.TextBox textBoxFirstNumber;
        private System.Windows.Forms.TextBox textBoxSecondNumber;
        private System.Windows.Forms.Label labelsecondNumber;
        private System.Windows.Forms.Button buttonDodawanie;
        private System.Windows.Forms.Button buttonOdejmowanie;
        private System.Windows.Forms.Button buttonMnozenie;
        private System.Windows.Forms.Button buttonDzielenoie;
        private System.Windows.Forms.Label labelWynik;
    }
}

