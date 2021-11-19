
namespace WinFormsApp1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.yntsilBtn = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.yntduzenleBtn = new System.Windows.Forms.Button();
            this.yntekleBtn = new System.Windows.Forms.Button();
            this.yntindxTxt = new System.Windows.Forms.TextBox();
            this.yntadTxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.usrduzenleBtn = new System.Windows.Forms.Button();
            this.userındxTxt = new System.Windows.Forms.TextBox();
            this.useradTxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(133, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 94);
            this.listBox1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Araya Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(14, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(133, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Değiştir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 207);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.yntsilBtn);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this.yntduzenleBtn);
            this.groupBox2.Controls.Add(this.yntekleBtn);
            this.groupBox2.Controls.Add(this.yntindxTxt);
            this.groupBox2.Controls.Add(this.yntadTxt);
            this.groupBox2.Location = new System.Drawing.Point(302, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 131);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yönetici";
            // 
            // yntsilBtn
            // 
            this.yntsilBtn.BackColor = System.Drawing.Color.Red;
            this.yntsilBtn.Location = new System.Drawing.Point(98, 88);
            this.yntsilBtn.Name = "yntsilBtn";
            this.yntsilBtn.Size = new System.Drawing.Size(45, 23);
            this.yntsilBtn.TabIndex = 5;
            this.yntsilBtn.Text = "Sil";
            this.yntsilBtn.UseVisualStyleBackColor = false;
            this.yntsilBtn.Click += new System.EventHandler(this.yntsilBtn_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(150, 23);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 94);
            this.listBox2.TabIndex = 4;
            // 
            // yntduzenleBtn
            // 
            this.yntduzenleBtn.Location = new System.Drawing.Point(31, 88);
            this.yntduzenleBtn.Name = "yntduzenleBtn";
            this.yntduzenleBtn.Size = new System.Drawing.Size(61, 23);
            this.yntduzenleBtn.TabIndex = 3;
            this.yntduzenleBtn.Text = "Düzenle";
            this.yntduzenleBtn.UseVisualStyleBackColor = true;
            this.yntduzenleBtn.Click += new System.EventHandler(this.yntduzenleBtn_Click);
            // 
            // yntekleBtn
            // 
            this.yntekleBtn.Location = new System.Drawing.Point(31, 59);
            this.yntekleBtn.Name = "yntekleBtn";
            this.yntekleBtn.Size = new System.Drawing.Size(47, 23);
            this.yntekleBtn.TabIndex = 2;
            this.yntekleBtn.Text = "Ekle";
            this.yntekleBtn.UseVisualStyleBackColor = true;
            this.yntekleBtn.Click += new System.EventHandler(this.yntekleBtn_Click);
            // 
            // yntindxTxt
            // 
            this.yntindxTxt.Location = new System.Drawing.Point(105, 60);
            this.yntindxTxt.Name = "yntindxTxt";
            this.yntindxTxt.Size = new System.Drawing.Size(26, 23);
            this.yntindxTxt.TabIndex = 1;
            // 
            // yntadTxt
            // 
            this.yntadTxt.Location = new System.Drawing.Point(31, 31);
            this.yntadTxt.Name = "yntadTxt";
            this.yntadTxt.Size = new System.Drawing.Size(100, 23);
            this.yntadTxt.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox3);
            this.groupBox3.Controls.Add(this.usrduzenleBtn);
            this.groupBox3.Controls.Add(this.userındxTxt);
            this.groupBox3.Controls.Add(this.useradTxt);
            this.groupBox3.Location = new System.Drawing.Point(302, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 129);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kullanıcı";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Location = new System.Drawing.Point(150, 23);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 94);
            this.listBox3.TabIndex = 4;
            // 
            // usrduzenleBtn
            // 
            this.usrduzenleBtn.Location = new System.Drawing.Point(31, 81);
            this.usrduzenleBtn.Name = "usrduzenleBtn";
            this.usrduzenleBtn.Size = new System.Drawing.Size(103, 23);
            this.usrduzenleBtn.TabIndex = 3;
            this.usrduzenleBtn.Text = "Düzenle";
            this.usrduzenleBtn.UseVisualStyleBackColor = true;
            this.usrduzenleBtn.Click += new System.EventHandler(this.usrduzenleBtn_Click);
            // 
            // userındxTxt
            // 
            this.userındxTxt.Location = new System.Drawing.Point(105, 52);
            this.userındxTxt.Name = "userındxTxt";
            this.userındxTxt.Size = new System.Drawing.Size(26, 23);
            this.userındxTxt.TabIndex = 1;
            // 
            // useradTxt
            // 
            this.useradTxt.Location = new System.Drawing.Point(31, 23);
            this.useradTxt.Name = "useradTxt";
            this.useradTxt.Size = new System.Drawing.Size(100, 23);
            this.useradTxt.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button yntduzenleBtn;
        private System.Windows.Forms.Button yntekleBtn;
        private System.Windows.Forms.TextBox yntindxTxt;
        private System.Windows.Forms.TextBox yntadTxt;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button usrduzenleBtn;
        private System.Windows.Forms.TextBox userındxTxt;
        private System.Windows.Forms.TextBox useradTxt;
        private System.Windows.Forms.Button yntsilBtn;
    }
}

