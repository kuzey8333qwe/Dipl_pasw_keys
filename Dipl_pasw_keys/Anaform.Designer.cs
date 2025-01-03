namespace Dipl_pasw_keys
{
    partial class Anaform
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtNotlar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdiMail = new System.Windows.Forms.TextBox();
            this.txtSiteUrl = new System.Windows.Forms.TextBox();
            this.txtSiteAdi = new System.Windows.Forms.TextBox();
            this.txtKayitNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblÖzelArama = new System.Windows.Forms.Label();
            this.txtSiteAdıAra = new System.Windows.Forms.TextBox();
            this.btnÖzelAra = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(224, 551);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(182, 113);
            this.btnTemizle.TabIndex = 41;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(224, 431);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(182, 113);
            this.btnKaydet.TabIndex = 39;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(36, 431);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(182, 113);
            this.btnSil.TabIndex = 38;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtNotlar
            // 
            this.txtNotlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNotlar.Location = new System.Drawing.Point(190, 253);
            this.txtNotlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNotlar.Multiline = true;
            this.txtNotlar.Name = "txtNotlar";
            this.txtNotlar.Size = new System.Drawing.Size(227, 134);
            this.txtNotlar.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(83, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 36;
            this.label6.Text = "Notlar :";
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(182, 206);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(235, 30);
            this.txtSifre.TabIndex = 35;
            // 
            // txtKullaniciAdiMail
            // 
            this.txtKullaniciAdiMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdiMail.Location = new System.Drawing.Point(228, 165);
            this.txtKullaniciAdiMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKullaniciAdiMail.Name = "txtKullaniciAdiMail";
            this.txtKullaniciAdiMail.Size = new System.Drawing.Size(188, 30);
            this.txtKullaniciAdiMail.TabIndex = 34;
            // 
            // txtSiteUrl
            // 
            this.txtSiteUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSiteUrl.Location = new System.Drawing.Point(198, 124);
            this.txtSiteUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSiteUrl.Name = "txtSiteUrl";
            this.txtSiteUrl.Size = new System.Drawing.Size(219, 30);
            this.txtSiteUrl.TabIndex = 33;
            // 
            // txtSiteAdi
            // 
            this.txtSiteAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSiteAdi.Location = new System.Drawing.Point(197, 89);
            this.txtSiteAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSiteAdi.Name = "txtSiteAdi";
            this.txtSiteAdi.Size = new System.Drawing.Size(219, 30);
            this.txtSiteAdi.TabIndex = 32;
            // 
            // txtKayitNo
            // 
            this.txtKayitNo.Enabled = false;
            this.txtKayitNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKayitNo.Location = new System.Drawing.Point(228, 44);
            this.txtKayitNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKayitNo.Name = "txtKayitNo";
            this.txtKayitNo.Size = new System.Drawing.Size(188, 30);
            this.txtKayitNo.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(88, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "Şifre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(28, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Kullanıcı Adı / Mail :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(76, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Site Url :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(74, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Site Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(121, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Kayıt No :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(454, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1154, 566);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // lblÖzelArama
            // 
            this.lblÖzelArama.AutoSize = true;
            this.lblÖzelArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblÖzelArama.Location = new System.Drawing.Point(478, 638);
            this.lblÖzelArama.Name = "lblÖzelArama";
            this.lblÖzelArama.Size = new System.Drawing.Size(197, 25);
            this.lblÖzelArama.TabIndex = 43;
            this.lblÖzelArama.Text = "Site Adına Göre Ara :";
            // 
            // txtSiteAdıAra
            // 
            this.txtSiteAdıAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSiteAdıAra.Location = new System.Drawing.Point(695, 634);
            this.txtSiteAdıAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSiteAdıAra.Name = "txtSiteAdıAra";
            this.txtSiteAdıAra.Size = new System.Drawing.Size(257, 30);
            this.txtSiteAdıAra.TabIndex = 44;
            this.txtSiteAdıAra.TextChanged += new System.EventHandler(this.txtSite_TextChanged);
            // 
            // btnÖzelAra
            // 
            this.btnÖzelAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÖzelAra.Location = new System.Drawing.Point(999, 619);
            this.btnÖzelAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnÖzelAra.Name = "btnÖzelAra";
            this.btnÖzelAra.Size = new System.Drawing.Size(109, 63);
            this.btnÖzelAra.TabIndex = 45;
            this.btnÖzelAra.Text = "Ara";
            this.btnÖzelAra.UseVisualStyleBackColor = true;
            this.btnÖzelAra.Click += new System.EventHandler(this.btnÖzelAra_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(36, 551);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(182, 113);
            this.btnGuncelle.TabIndex = 46;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // Anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1637, 709);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnÖzelAra);
            this.Controls.Add(this.txtSiteAdıAra);
            this.Controls.Add(this.lblÖzelArama);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtNotlar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdiMail);
            this.Controls.Add(this.txtSiteUrl);
            this.Controls.Add(this.txtSiteAdi);
            this.Controls.Add(this.txtKayitNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Anaform";
            this.Text = "Anaform";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Anaform_FormClosing);
            this.Load += new System.EventHandler(this.Anaform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtNotlar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdiMail;
        private System.Windows.Forms.TextBox txtSiteUrl;
        private System.Windows.Forms.TextBox txtSiteAdi;
        private System.Windows.Forms.TextBox txtKayitNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblÖzelArama;
        private System.Windows.Forms.TextBox txtSiteAdıAra;
        private System.Windows.Forms.Button btnÖzelAra;
        private System.Windows.Forms.Button btnGuncelle;
    }
}

