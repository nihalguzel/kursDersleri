
namespace msgappodevi
{
    partial class messageCard
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
            this.personNameLbl = new System.Windows.Forms.Label();
            this.messageLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // personNameLbl
            // 
            this.personNameLbl.AutoSize = true;
            this.personNameLbl.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.personNameLbl.Location = new System.Drawing.Point(7, 6);
            this.personNameLbl.Name = "personNameLbl";
            this.personNameLbl.Size = new System.Drawing.Size(55, 21);
            this.personNameLbl.TabIndex = 0;
            this.personNameLbl.Text = "Kişi Adı";
            // 
            // messageLbl
            // 
            this.messageLbl.AutoSize = true;
            this.messageLbl.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.messageLbl.Location = new System.Drawing.Point(10, 28);
            this.messageLbl.MaximumSize = new System.Drawing.Size(250, 0);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(86, 19);
            this.messageLbl.TabIndex = 1;
            this.messageLbl.Text = "Mesaj Bölümü";
            // 
            // messageCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.messageLbl);
            this.Controls.Add(this.personNameLbl);
            this.Margin = new System.Windows.Forms.Padding(3, 100, 3, 3);
            this.Name = "messageCard";
            this.Size = new System.Drawing.Size(266, 57);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label personNameLbl;
        private System.Windows.Forms.Label messageLbl;
    }
}
