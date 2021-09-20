using System;

namespace Tic_Tac_Toe_v21
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.A00 = new System.Windows.Forms.Button();
            this.A01 = new System.Windows.Forms.Button();
            this.A02 = new System.Windows.Forms.Button();
            this.A12 = new System.Windows.Forms.Button();
            this.A11 = new System.Windows.Forms.Button();
            this.A10 = new System.Windows.Forms.Button();
            this.A22 = new System.Windows.Forms.Button();
            this.A21 = new System.Windows.Forms.Button();
            this.A20 = new System.Windows.Forms.Button();
            this.NGButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Draws = new System.Windows.Forms.Label();
            this.OWin = new System.Windows.Forms.Label();
            this.XWin = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // A00
            // 
            this.A00.Location = new System.Drawing.Point(88, 57);
            this.A00.Name = "A00";
            this.A00.Size = new System.Drawing.Size(99, 99);
            this.A00.TabIndex = 0;
            this.A00.UseVisualStyleBackColor = true;
            this.A00.Click += new System.EventHandler(this.Button_Click);
            // 
            // A01
            // 
            this.A01.Location = new System.Drawing.Point(218, 57);
            this.A01.Name = "A01";
            this.A01.Size = new System.Drawing.Size(99, 99);
            this.A01.TabIndex = 1;
            this.A01.UseVisualStyleBackColor = true;
            this.A01.Click += new System.EventHandler(this.Button_Click);
            // 
            // A02
            // 
            this.A02.Location = new System.Drawing.Point(345, 57);
            this.A02.Name = "A02";
            this.A02.Size = new System.Drawing.Size(99, 99);
            this.A02.TabIndex = 2;
            this.A02.UseVisualStyleBackColor = true;
            this.A02.Click += new System.EventHandler(this.Button_Click);
            // 
            // A12
            // 
            this.A12.Location = new System.Drawing.Point(345, 172);
            this.A12.Name = "A12";
            this.A12.Size = new System.Drawing.Size(99, 99);
            this.A12.TabIndex = 5;
            this.A12.UseVisualStyleBackColor = true;
            this.A12.Click += new System.EventHandler(this.Button_Click);
            // 
            // A11
            // 
            this.A11.Location = new System.Drawing.Point(218, 172);
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(99, 99);
            this.A11.TabIndex = 4;
            this.A11.UseVisualStyleBackColor = true;
            this.A11.Click += new System.EventHandler(this.Button_Click);
            // 
            // A10
            // 
            this.A10.Location = new System.Drawing.Point(88, 172);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(99, 99);
            this.A10.TabIndex = 3;
            this.A10.UseVisualStyleBackColor = true;
            this.A10.Click += new System.EventHandler(this.Button_Click);
            // 
            // A22
            // 
            this.A22.Location = new System.Drawing.Point(345, 289);
            this.A22.Name = "A22";
            this.A22.Size = new System.Drawing.Size(99, 99);
            this.A22.TabIndex = 8;
            this.A22.UseVisualStyleBackColor = true;
            this.A22.Click += new System.EventHandler(this.Button_Click);
            // 
            // A21
            // 
            this.A21.Location = new System.Drawing.Point(218, 289);
            this.A21.Name = "A21";
            this.A21.Size = new System.Drawing.Size(99, 99);
            this.A21.TabIndex = 7;
            this.A21.UseVisualStyleBackColor = true;
            this.A21.Click += new System.EventHandler(this.Button_Click);
            // 
            // A20
            // 
            this.A20.Location = new System.Drawing.Point(88, 289);
            this.A20.Name = "A20";
            this.A20.Size = new System.Drawing.Size(99, 99);
            this.A20.TabIndex = 6;
            this.A20.UseVisualStyleBackColor = true;
            this.A20.Click += new System.EventHandler(this.Button_Click);
            // 
            // NGButton
            // 
            this.NGButton.Location = new System.Drawing.Point(17, 17);
            this.NGButton.Name = "NGButton";
            this.NGButton.Size = new System.Drawing.Size(75, 23);
            this.NGButton.TabIndex = 9;
            this.NGButton.Text = "New Game";
            this.NGButton.UseVisualStyleBackColor = true;
            this.NGButton.Click += new System.EventHandler(this.NGButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ExitButton);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.RButton);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NGButton);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(466, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 161);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genral";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Draws);
            this.groupBox2.Controls.Add(this.OWin);
            this.groupBox2.Controls.Add(this.XWin);
            this.groupBox2.Location = new System.Drawing.Point(466, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(110, 164);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Score";
            // 
            // Draws
            // 
            this.Draws.AutoSize = true;
            this.Draws.Location = new System.Drawing.Point(17, 85);
            this.Draws.Name = "Draws";
            this.Draws.Size = new System.Drawing.Size(0, 13);
            this.Draws.TabIndex = 2;
            // 
            // OWin
            // 
            this.OWin.AutoSize = true;
            this.OWin.Location = new System.Drawing.Point(17, 57);
            this.OWin.Name = "OWin";
            this.OWin.Size = new System.Drawing.Size(0, 13);
            this.OWin.TabIndex = 1;
            // 
            // XWin
            // 
            this.XWin.AutoSize = true;
            this.XWin.Location = new System.Drawing.Point(14, 26);
            this.XWin.Name = "XWin";
            this.XWin.Size = new System.Drawing.Size(0, 13);
            this.XWin.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 451);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.A22);
            this.Controls.Add(this.A21);
            this.Controls.Add(this.A20);
            this.Controls.Add(this.A12);
            this.Controls.Add(this.A11);
            this.Controls.Add(this.A10);
            this.Controls.Add(this.A02);
            this.Controls.Add(this.A01);
            this.Controls.Add(this.A00);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

     

        #endregion

        private System.Windows.Forms.Button A00;
        private System.Windows.Forms.Button A01;
        private System.Windows.Forms.Button A02;
        private System.Windows.Forms.Button A12;
        private System.Windows.Forms.Button A11;
        private System.Windows.Forms.Button A10;
        private System.Windows.Forms.Button A22;
        private System.Windows.Forms.Button A21;
        private System.Windows.Forms.Button A20;
        private System.Windows.Forms.Button NGButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label XWin;
        private System.Windows.Forms.Label Draws;
        private System.Windows.Forms.Label OWin;
    }
}

