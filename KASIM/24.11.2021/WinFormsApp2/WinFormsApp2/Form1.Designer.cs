
namespace WinFormsApp2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.textTxt = new System.Windows.Forms.TextBox();
            this.ykorTxt = new System.Windows.Forms.TextBox();
            this.xkorTxt = new System.Windows.Forms.TextBox();
            this.genTxt = new System.Windows.Forms.TextBox();
            this.yukTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Button",
            "Label",
            "ListBox",
            "ComboBox",
            "TextBox",
            "RadioButton",
            "CheckBox"});
            this.listBox1.Location = new System.Drawing.Point(12, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 109);
            this.listBox1.TabIndex = 0;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(138, 32);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(108, 23);
            this.nameTxt.TabIndex = 1;
            // 
            // textTxt
            // 
            this.textTxt.Location = new System.Drawing.Point(138, 71);
            this.textTxt.Name = "textTxt";
            this.textTxt.Size = new System.Drawing.Size(108, 23);
            this.textTxt.TabIndex = 2;
            // 
            // ykorTxt
            // 
            this.ykorTxt.Location = new System.Drawing.Point(195, 110);
            this.ykorTxt.Name = "ykorTxt";
            this.ykorTxt.Size = new System.Drawing.Size(51, 23);
            this.ykorTxt.TabIndex = 4;
            // 
            // xkorTxt
            // 
            this.xkorTxt.Location = new System.Drawing.Point(138, 110);
            this.xkorTxt.Name = "xkorTxt";
            this.xkorTxt.Size = new System.Drawing.Size(51, 23);
            this.xkorTxt.TabIndex = 5;
            // 
            // genTxt
            // 
            this.genTxt.Location = new System.Drawing.Point(138, 149);
            this.genTxt.Name = "genTxt";
            this.genTxt.Size = new System.Drawing.Size(51, 23);
            this.genTxt.TabIndex = 7;
            // 
            // yukTxt
            // 
            this.yukTxt.Location = new System.Drawing.Point(195, 149);
            this.yukTxt.Name = "yukTxt";
            this.yukTxt.Size = new System.Drawing.Size(51, 23);
            this.yukTxt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "x koor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "y koor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Genişlik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Yükseklik";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tıklanma Özelliği ?";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(139, 198);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 19);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.Text = "Evet";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(195, 198);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 19);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Hayır";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Nesne Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(267, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 330);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eklenen Nesneler";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Button",
            "Label",
            "TextBox"});
            this.comboBox1.Location = new System.Drawing.Point(12, 171);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nesne Çağır";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(13, 201);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 94);
            this.listBox2.TabIndex = 21;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Düzenle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genTxt);
            this.Controls.Add(this.yukTxt);
            this.Controls.Add(this.xkorTxt);
            this.Controls.Add(this.ykorTxt);
            this.Controls.Add(this.textTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox textTxt;
        private System.Windows.Forms.TextBox ykorTxt;
        private System.Windows.Forms.TextBox xkorTxt;
        private System.Windows.Forms.TextBox genTxt;
        private System.Windows.Forms.TextBox yukTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button2;
    }
}

