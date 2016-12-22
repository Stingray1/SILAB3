namespace SI_Lab3
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
            this.messageBox = new System.Windows.Forms.RichTextBox();
            this.btnSemneaza = new System.Windows.Forms.Button();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cheiePBox = new System.Windows.Forms.RichTextBox();
            this.cheieQBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cheieYBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cheieXBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.msgHashBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cheieRBox = new System.Windows.Forms.RichTextBox();
            this.cheieSBox = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // messageBox
            // 
            this.messageBox.AccessibleDescription = "";
            this.messageBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageBox.Location = new System.Drawing.Point(12, 415);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(420, 165);
            this.messageBox.TabIndex = 0;
            this.messageBox.Text = "";
            // 
            // btnSemneaza
            // 
            this.btnSemneaza.Location = new System.Drawing.Point(12, 586);
            this.btnSemneaza.Name = "btnSemneaza";
            this.btnSemneaza.Size = new System.Drawing.Size(75, 23);
            this.btnSemneaza.TabIndex = 1;
            this.btnSemneaza.Text = "Semneaza";
            this.btnSemneaza.UseVisualStyleBackColor = true;
            this.btnSemneaza.Click += new System.EventHandler(this.btnSemneaza_Click);
            // 
            // btnVerifica
            // 
            this.btnVerifica.Location = new System.Drawing.Point(742, 586);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(75, 23);
            this.btnVerifica.TabIndex = 2;
            this.btnVerifica.Text = "Verifica";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cheia P";
            // 
            // cheiePBox
            // 
            this.cheiePBox.Location = new System.Drawing.Point(62, 10);
            this.cheiePBox.Name = "cheiePBox";
            this.cheiePBox.ReadOnly = true;
            this.cheiePBox.Size = new System.Drawing.Size(755, 50);
            this.cheiePBox.TabIndex = 5;
            this.cheiePBox.Text = "";
            // 
            // cheieQBox
            // 
            this.cheieQBox.Location = new System.Drawing.Point(62, 66);
            this.cheieQBox.Name = "cheieQBox";
            this.cheieQBox.ReadOnly = true;
            this.cheieQBox.Size = new System.Drawing.Size(755, 50);
            this.cheieQBox.TabIndex = 7;
            this.cheieQBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cheia Q";
            // 
            // GBox
            // 
            this.GBox.Location = new System.Drawing.Point(62, 122);
            this.GBox.Name = "GBox";
            this.GBox.ReadOnly = true;
            this.GBox.Size = new System.Drawing.Size(755, 50);
            this.GBox.TabIndex = 9;
            this.GBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "G";
            // 
            // cheieYBox
            // 
            this.cheieYBox.Location = new System.Drawing.Point(62, 178);
            this.cheieYBox.Name = "cheieYBox";
            this.cheieYBox.ReadOnly = true;
            this.cheieYBox.Size = new System.Drawing.Size(755, 50);
            this.cheieYBox.TabIndex = 11;
            this.cheieYBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cheia Y";
            // 
            // cheieXBox
            // 
            this.cheieXBox.Location = new System.Drawing.Point(62, 234);
            this.cheieXBox.Name = "cheieXBox";
            this.cheieXBox.ReadOnly = true;
            this.cheieXBox.Size = new System.Drawing.Size(754, 50);
            this.cheieXBox.TabIndex = 13;
            this.cheieXBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mesaj";
            // 
            // msgHashBox
            // 
            this.msgHashBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgHashBox.Location = new System.Drawing.Point(438, 415);
            this.msgHashBox.Name = "msgHashBox";
            this.msgHashBox.Size = new System.Drawing.Size(379, 165);
            this.msgHashBox.TabIndex = 15;
            this.msgHashBox.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Hash al mesajului";
            // 
            // cheieRBox
            // 
            this.cheieRBox.Location = new System.Drawing.Point(62, 290);
            this.cheieRBox.Name = "cheieRBox";
            this.cheieRBox.ReadOnly = true;
            this.cheieRBox.Size = new System.Drawing.Size(754, 50);
            this.cheieRBox.TabIndex = 18;
            this.cheieRBox.Text = "";
            // 
            // cheieSBox
            // 
            this.cheieSBox.Location = new System.Drawing.Point(62, 346);
            this.cheieSBox.Name = "cheieSBox";
            this.cheieSBox.ReadOnly = true;
            this.cheieSBox.Size = new System.Drawing.Size(752, 50);
            this.cheieSBox.TabIndex = 20;
            this.cheieSBox.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 234);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(45, 50);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "Cheia privata X";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 290);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(45, 50);
            this.textBox2.TabIndex = 22;
            this.textBox2.Text = "Cheia privata R";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 346);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(46, 50);
            this.textBox3.TabIndex = 23;
            this.textBox3.Text = "Cheia privata S";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 616);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cheieSBox);
            this.Controls.Add(this.cheieRBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.msgHashBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cheieXBox);
            this.Controls.Add(this.cheieYBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cheieQBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cheiePBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.btnSemneaza);
            this.Controls.Add(this.messageBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox messageBox;
        private System.Windows.Forms.Button btnSemneaza;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox cheiePBox;
        private System.Windows.Forms.RichTextBox cheieQBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox GBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox cheieYBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox cheieXBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox msgHashBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox cheieRBox;
        private System.Windows.Forms.RichTextBox cheieSBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

