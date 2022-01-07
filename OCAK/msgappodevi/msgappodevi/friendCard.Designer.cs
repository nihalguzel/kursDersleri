
namespace msgappodevi
{
    partial class friendCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(friendCard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.personNameLbl = new System.Windows.Forms.Label();
            this.personIpLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // personNameLbl
            // 
            this.personNameLbl.AutoSize = true;
            this.personNameLbl.Location = new System.Drawing.Point(74, 4);
            this.personNameLbl.Name = "personNameLbl";
            this.personNameLbl.Size = new System.Drawing.Size(46, 15);
            this.personNameLbl.TabIndex = 1;
            this.personNameLbl.Text = "Kişi Adı";
            // 
            // personIpLbl
            // 
            this.personIpLbl.AutoSize = true;
            this.personIpLbl.Location = new System.Drawing.Point(74, 33);
            this.personIpLbl.Name = "personIpLbl";
            this.personIpLbl.Size = new System.Drawing.Size(53, 15);
            this.personIpLbl.TabIndex = 2;
            this.personIpLbl.Text = "Ip Adresi";
            // 
            // friendCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.personIpLbl);
            this.Controls.Add(this.personNameLbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "friendCard";
            this.Size = new System.Drawing.Size(213, 52);
            this.DoubleClick += new System.EventHandler(this.friendCard_DoubleClick);
            this.MouseLeave += new System.EventHandler(this.friendCard_MouseLeave);
            this.MouseHover += new System.EventHandler(this.friendCard_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label personNameLbl;
        private System.Windows.Forms.Label personIpLbl;
    }
}
