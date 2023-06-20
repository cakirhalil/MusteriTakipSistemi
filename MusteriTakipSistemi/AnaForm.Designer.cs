
namespace MusteriTakipSistemi
{
    partial class AnaForm
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
            this.btnMusteriListesi = new System.Windows.Forms.Button();
            this.btnEkleme = new System.Windows.Forms.Button();
            this.btnSilme = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMusteriListesi
            // 
            this.btnMusteriListesi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMusteriListesi.Location = new System.Drawing.Point(59, 346);
            this.btnMusteriListesi.Name = "btnMusteriListesi";
            this.btnMusteriListesi.Size = new System.Drawing.Size(110, 56);
            this.btnMusteriListesi.TabIndex = 0;
            this.btnMusteriListesi.Text = "Müşteri Listesi";
            this.btnMusteriListesi.UseVisualStyleBackColor = false;
            this.btnMusteriListesi.Click += new System.EventHandler(this.btnMusteriListesi_Click);
            // 
            // btnEkleme
            // 
            this.btnEkleme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEkleme.Location = new System.Drawing.Point(294, 346);
            this.btnEkleme.Name = "btnEkleme";
            this.btnEkleme.Size = new System.Drawing.Size(110, 56);
            this.btnEkleme.TabIndex = 1;
            this.btnEkleme.Text = "Ekleme";
            this.btnEkleme.UseVisualStyleBackColor = false;
            this.btnEkleme.Click += new System.EventHandler(this.btnEkleme_Click);
            // 
            // btnSilme
            // 
            this.btnSilme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSilme.Location = new System.Drawing.Point(523, 346);
            this.btnSilme.Name = "btnSilme";
            this.btnSilme.Size = new System.Drawing.Size(110, 56);
            this.btnSilme.TabIndex = 2;
            this.btnSilme.Text = "Silme";
            this.btnSilme.UseVisualStyleBackColor = false;
            this.btnSilme.Click += new System.EventHandler(this.btnSilme_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGuncelle.Location = new System.Drawing.Point(761, 346);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(110, 56);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelleme";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(277, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 44);
            this.label1.TabIndex = 8;
            this.label1.Text = "Müşteri Takip Sistemi";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MusteriTakipSistemi.Properties.Resources.refresh;
            this.pictureBox4.Location = new System.Drawing.Point(719, 152);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(193, 169);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MusteriTakipSistemi.Properties.Resources.customer;
            this.pictureBox3.Location = new System.Drawing.Point(482, 152);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(193, 169);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MusteriTakipSistemi.Properties.Resources.add_user;
            this.pictureBox2.Location = new System.Drawing.Point(249, 152);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 169);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MusteriTakipSistemi.Properties.Resources.review;
            this.pictureBox1.Location = new System.Drawing.Point(17, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(934, 493);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSilme);
            this.Controls.Add(this.btnEkleme);
            this.Controls.Add(this.btnMusteriListesi);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMusteriListesi;
        private System.Windows.Forms.Button btnEkleme;
        private System.Windows.Forms.Button btnSilme;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
    }
}

