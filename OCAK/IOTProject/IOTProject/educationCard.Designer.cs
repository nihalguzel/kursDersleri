
namespace IOTProject
{
    partial class educationCard
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(educationCard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.baslikLbl = new System.Windows.Forms.Label();
            this.gosterBtn = new System.Windows.Forms.Button();
            this.puanLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // baslikLbl
            // 
            this.baslikLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.baslikLbl.Location = new System.Drawing.Point(5, 201);
            this.baslikLbl.Name = "baslikLbl";
            this.baslikLbl.Size = new System.Drawing.Size(277, 105);
            this.baslikLbl.TabIndex = 1;
            this.baslikLbl.Text = "label1";
            // 
            // gosterBtn
            // 
            this.gosterBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gosterBtn.Location = new System.Drawing.Point(138, 309);
            this.gosterBtn.Name = "gosterBtn";
            this.gosterBtn.Size = new System.Drawing.Size(128, 52);
            this.gosterBtn.TabIndex = 2;
            this.gosterBtn.Text = "Daha Fazla...";
            this.gosterBtn.UseVisualStyleBackColor = true;
            this.gosterBtn.Click += new System.EventHandler(this.gosterBtn_Click);
            // 
            // puanLbl
            // 
            this.puanLbl.AutoSize = true;
            this.puanLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.puanLbl.Location = new System.Drawing.Point(19, 325);
            this.puanLbl.Name = "puanLbl";
            this.puanLbl.Size = new System.Drawing.Size(80, 27);
            this.puanLbl.TabIndex = 3;
            this.puanLbl.Text = "label1";
            // 
            // educationCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.puanLbl);
            this.Controls.Add(this.gosterBtn);
            this.Controls.Add(this.baslikLbl);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "educationCard";
            this.Size = new System.Drawing.Size(285, 375);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label baslikLbl;
        private System.Windows.Forms.Button gosterBtn;
        private System.Windows.Forms.Label puanLbl;
    }
}
