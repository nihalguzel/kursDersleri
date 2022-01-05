
namespace IOTProject
{
    partial class teacherCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teacherCard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ogrtmnAdi = new System.Windows.Forms.Label();
            this.ogrtmnAciklama = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ogrtmnAdi
            // 
            this.ogrtmnAdi.AutoSize = true;
            this.ogrtmnAdi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ogrtmnAdi.Location = new System.Drawing.Point(131, 6);
            this.ogrtmnAdi.Name = "ogrtmnAdi";
            this.ogrtmnAdi.Size = new System.Drawing.Size(137, 25);
            this.ogrtmnAdi.TabIndex = 1;
            this.ogrtmnAdi.Text = "Öğretmen Adı";
            // 
            // ogrtmnAciklama
            // 
            this.ogrtmnAciklama.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ogrtmnAciklama.Location = new System.Drawing.Point(136, 33);
            this.ogrtmnAciklama.Name = "ogrtmnAciklama";
            this.ogrtmnAciklama.Size = new System.Drawing.Size(209, 105);
            this.ogrtmnAciklama.TabIndex = 2;
            this.ogrtmnAciklama.Text = "Öğretmen Adı";
            // 
            // teacherCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ogrtmnAciklama);
            this.Controls.Add(this.ogrtmnAdi);
            this.Controls.Add(this.pictureBox1);
            this.Name = "teacherCard";
            this.Size = new System.Drawing.Size(370, 148);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ogrtmnAdi;
        private System.Windows.Forms.Label ogrtmnAciklama;
    }
}
