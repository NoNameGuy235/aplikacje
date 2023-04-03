
namespace tictocktoe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboWhoStartGame = new System.Windows.Forms.ComboBox();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.tableLayoutBoard = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonPosition00 = new System.Windows.Forms.Button();
            this.ButtonPosition10 = new System.Windows.Forms.Button();
            this.ButtonPosition20 = new System.Windows.Forms.Button();
            this.ButtonPosition01 = new System.Windows.Forms.Button();
            this.ButtonPosition11 = new System.Windows.Forms.Button();
            this.ButtonPosition21 = new System.Windows.Forms.Button();
            this.ButtonPosition02 = new System.Windows.Forms.Button();
            this.ButtonPosition12 = new System.Windows.Forms.Button();
            this.ButtonPosition22 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboWhoStartGame);
            this.panel1.Controls.Add(this.buttonNewGame);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "kto zaczyna gre";
            // 
            // comboWhoStartGame
            // 
            this.comboWhoStartGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboWhoStartGame.FormattingEnabled = true;
            this.comboWhoStartGame.Items.AddRange(new object[] {
            "kółko",
            "krzyżyk"});
            this.comboWhoStartGame.Location = new System.Drawing.Point(12, 44);
            this.comboWhoStartGame.Name = "comboWhoStartGame";
            this.comboWhoStartGame.Size = new System.Drawing.Size(242, 23);
            this.comboWhoStartGame.TabIndex = 2;
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(304, 43);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(184, 23);
            this.buttonNewGame.TabIndex = 0;
            this.buttonNewGame.Text = "Nowa Giera";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            // 
            // tableLayoutBoard
            // 
            this.tableLayoutBoard.ColumnCount = 3;
            this.tableLayoutBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutBoard.Controls.Add(this.ButtonPosition00, 0, 0);
            this.tableLayoutBoard.Controls.Add(this.ButtonPosition10, 1, 0);
            this.tableLayoutBoard.Controls.Add(this.ButtonPosition20, 2, 0);
            this.tableLayoutBoard.Controls.Add(this.ButtonPosition01, 0, 1);
            this.tableLayoutBoard.Controls.Add(this.ButtonPosition11, 1, 1);
            this.tableLayoutBoard.Controls.Add(this.ButtonPosition21, 2, 1);
            this.tableLayoutBoard.Controls.Add(this.ButtonPosition02, 0, 2);
            this.tableLayoutBoard.Controls.Add(this.ButtonPosition12, 1, 2);
            this.tableLayoutBoard.Controls.Add(this.ButtonPosition22, 2, 2);
            this.tableLayoutBoard.Location = new System.Drawing.Point(0, 96);
            this.tableLayoutBoard.Name = "tableLayoutBoard";
            this.tableLayoutBoard.RowCount = 3;
            this.tableLayoutBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutBoard.Size = new System.Drawing.Size(800, 355);
            this.tableLayoutBoard.TabIndex = 0;
            // 
            // ButtonPosition00
            // 
            this.ButtonPosition00.Location = new System.Drawing.Point(3, 3);
            this.ButtonPosition00.Name = "ButtonPosition00";
            this.ButtonPosition00.Size = new System.Drawing.Size(259, 112);
            this.ButtonPosition00.TabIndex = 0;
            this.ButtonPosition00.UseVisualStyleBackColor = true;
            this.ButtonPosition00.Click += new System.EventHandler(this.MainForm_Load);
            // 
            // ButtonPosition10
            // 
            this.ButtonPosition10.Location = new System.Drawing.Point(269, 3);
            this.ButtonPosition10.Name = "ButtonPosition10";
            this.ButtonPosition10.Size = new System.Drawing.Size(259, 112);
            this.ButtonPosition10.TabIndex = 1;
            this.ButtonPosition10.UseVisualStyleBackColor = true;
            this.ButtonPosition10.Click += new System.EventHandler(this.MainForm_Load);
            // 
            // ButtonPosition20
            // 
            this.ButtonPosition20.Location = new System.Drawing.Point(535, 3);
            this.ButtonPosition20.Name = "ButtonPosition20";
            this.ButtonPosition20.Size = new System.Drawing.Size(262, 112);
            this.ButtonPosition20.TabIndex = 2;
            this.ButtonPosition20.UseVisualStyleBackColor = true;
            this.ButtonPosition20.Click += new System.EventHandler(this.MainForm_Load);
            // 
            // ButtonPosition01
            // 
            this.ButtonPosition01.Location = new System.Drawing.Point(3, 121);
            this.ButtonPosition01.Name = "ButtonPosition01";
            this.ButtonPosition01.Size = new System.Drawing.Size(259, 112);
            this.ButtonPosition01.TabIndex = 3;
            this.ButtonPosition01.UseVisualStyleBackColor = true;
            this.ButtonPosition01.Click += new System.EventHandler(this.MainForm_Load);
            // 
            // ButtonPosition11
            // 
            this.ButtonPosition11.Location = new System.Drawing.Point(269, 121);
            this.ButtonPosition11.Name = "ButtonPosition11";
            this.ButtonPosition11.Size = new System.Drawing.Size(259, 112);
            this.ButtonPosition11.TabIndex = 4;
            this.ButtonPosition11.UseVisualStyleBackColor = true;
            this.ButtonPosition11.Click += new System.EventHandler(this.MainForm_Load);
            // 
            // ButtonPosition21
            // 
            this.ButtonPosition21.Location = new System.Drawing.Point(535, 121);
            this.ButtonPosition21.Name = "ButtonPosition21";
            this.ButtonPosition21.Size = new System.Drawing.Size(262, 112);
            this.ButtonPosition21.TabIndex = 5;
            this.ButtonPosition21.UseVisualStyleBackColor = true;
            this.ButtonPosition21.Click += new System.EventHandler(this.MainForm_Load);
            // 
            // ButtonPosition02
            // 
            this.ButtonPosition02.Location = new System.Drawing.Point(3, 239);
            this.ButtonPosition02.Name = "ButtonPosition02";
            this.ButtonPosition02.Size = new System.Drawing.Size(259, 113);
            this.ButtonPosition02.TabIndex = 6;
            this.ButtonPosition02.UseVisualStyleBackColor = true;
            this.ButtonPosition02.Click += new System.EventHandler(this.MainForm_Load);
            // 
            // ButtonPosition12
            // 
            this.ButtonPosition12.Location = new System.Drawing.Point(269, 239);
            this.ButtonPosition12.Name = "ButtonPosition12";
            this.ButtonPosition12.Size = new System.Drawing.Size(259, 113);
            this.ButtonPosition12.TabIndex = 7;
            this.ButtonPosition12.UseVisualStyleBackColor = true;
            this.ButtonPosition12.Click += new System.EventHandler(this.MainForm_Load);
            // 
            // ButtonPosition22
            // 
            this.ButtonPosition22.Location = new System.Drawing.Point(535, 239);
            this.ButtonPosition22.Name = "ButtonPosition22";
            this.ButtonPosition22.Size = new System.Drawing.Size(262, 113);
            this.ButtonPosition22.TabIndex = 8;
            this.ButtonPosition22.UseVisualStyleBackColor = true;
            this.ButtonPosition22.Click += new System.EventHandler(this.MainForm_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 453);
            this.Controls.Add(this.tableLayoutBoard);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(819, 492);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutBoard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutBoard;
        private System.Windows.Forms.Button ButtonPosition00;
        private System.Windows.Forms.Button ButtonPosition10;
        private System.Windows.Forms.Button ButtonPosition20;
        private System.Windows.Forms.Button ButtonPosition01;
        private System.Windows.Forms.Button ButtonPosition11;
        private System.Windows.Forms.Button ButtonPosition21;
        private System.Windows.Forms.Button ButtonPosition02;
        private System.Windows.Forms.Button ButtonPosition12;
        private System.Windows.Forms.Button ButtonPosition22;
        private System.Windows.Forms.ComboBox comboWhoStartGame;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Label label1;
    }
}

