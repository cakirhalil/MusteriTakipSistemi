
namespace MusteriTakipSistemi
{
    partial class EkleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EkleForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnListe = new System.Windows.Forms.Button();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(47, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 169);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(303, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(303, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(303, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(303, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mail:";
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.GhostWhite;
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(421, 95);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(254, 34);
            this.txtAd.TabIndex = 2;
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.GhostWhite;
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(421, 302);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(254, 34);
            this.txtMail.TabIndex = 5;
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.GhostWhite;
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(421, 164);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(254, 34);
            this.txtSoyad.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEkle.Location = new System.Drawing.Point(484, 368);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(110, 56);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnListe
            // 
            this.btnListe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnListe.Location = new System.Drawing.Point(12, 450);
            this.btnListe.Name = "btnListe";
            this.btnListe.Size = new System.Drawing.Size(134, 31);
            this.btnListe.TabIndex = 7;
            this.btnListe.Text = "Müşteri Listesi";
            this.btnListe.UseVisualStyleBackColor = false;
            this.btnListe.Click += new System.EventHandler(this.btnListe_Click);
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.Color.GhostWhite;
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTel.Location = new System.Drawing.Point(421, 233);
            this.txtTel.MaxLength = 11;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(254, 34);
            this.txtTel.TabIndex = 4;
            // 
            // txtNo
            // 
            this.txtNo.BackColor = System.Drawing.Color.GhostWhite;
            this.txtNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNo.Location = new System.Drawing.Point(421, 23);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(254, 34);
            this.txtNo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(303, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 32);
            this.label5.TabIndex = 18;
            this.label5.Text = "No:";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnTemizle.Location = new System.Drawing.Point(600, 368);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 32);
            this.btnTemizle.TabIndex = 44;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // EkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(763, 493);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.btnListe);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EkleForm";
            this.Load += new System.EventHandler(this.EkleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnListe;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTemizle;
    }
}