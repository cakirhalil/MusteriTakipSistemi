
namespace MusteriTakipSistemi
{
    partial class SilForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SilForm));
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUSTERINODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLMusteriListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musteriTakipSistemiDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musteriTakipSistemi_DBDataSet = new MusteriTakipSistemi.MusteriTakipSistemi_DBDataSet();
            this.button3 = new System.Windows.Forms.Button();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBL_MusteriListTableAdapter = new MusteriTakipSistemi.MusteriTakipSistemi_DBDataSetTableAdapters.TBL_MusteriListTableAdapter();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMusteriListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriTakipSistemiDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriTakipSistemi_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.GhostWhite;
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(438, 167);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(254, 34);
            this.txtSoyad.TabIndex = 3;
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.GhostWhite;
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(438, 305);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(254, 34);
            this.txtMail.TabIndex = 5;
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.GhostWhite;
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(438, 98);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(254, 34);
            this.txtAd.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(320, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 32);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(320, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(320, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(320, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ad:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(60, 96);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(193, 169);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.mUSTERINODataGridViewTextBoxColumn,
            this.aDDataGridViewTextBoxColumn,
            this.sOYADDataGridViewTextBoxColumn,
            this.tELDataGridViewTextBoxColumn,
            this.mAILDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLMusteriListBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 448);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(736, 365);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Width = 125;
            // 
            // mUSTERINODataGridViewTextBoxColumn
            // 
            this.mUSTERINODataGridViewTextBoxColumn.DataPropertyName = "MUSTERINO";
            this.mUSTERINODataGridViewTextBoxColumn.HeaderText = "MUSTERINO";
            this.mUSTERINODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mUSTERINODataGridViewTextBoxColumn.Name = "mUSTERINODataGridViewTextBoxColumn";
            this.mUSTERINODataGridViewTextBoxColumn.Width = 125;
            // 
            // aDDataGridViewTextBoxColumn
            // 
            this.aDDataGridViewTextBoxColumn.DataPropertyName = "AD";
            this.aDDataGridViewTextBoxColumn.HeaderText = "AD";
            this.aDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aDDataGridViewTextBoxColumn.Name = "aDDataGridViewTextBoxColumn";
            this.aDDataGridViewTextBoxColumn.Width = 125;
            // 
            // sOYADDataGridViewTextBoxColumn
            // 
            this.sOYADDataGridViewTextBoxColumn.DataPropertyName = "SOYAD";
            this.sOYADDataGridViewTextBoxColumn.HeaderText = "SOYAD";
            this.sOYADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sOYADDataGridViewTextBoxColumn.Name = "sOYADDataGridViewTextBoxColumn";
            this.sOYADDataGridViewTextBoxColumn.Width = 125;
            // 
            // tELDataGridViewTextBoxColumn
            // 
            this.tELDataGridViewTextBoxColumn.DataPropertyName = "TEL";
            this.tELDataGridViewTextBoxColumn.HeaderText = "TEL";
            this.tELDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tELDataGridViewTextBoxColumn.Name = "tELDataGridViewTextBoxColumn";
            this.tELDataGridViewTextBoxColumn.Width = 125;
            // 
            // mAILDataGridViewTextBoxColumn
            // 
            this.mAILDataGridViewTextBoxColumn.DataPropertyName = "MAIL";
            this.mAILDataGridViewTextBoxColumn.HeaderText = "MAIL";
            this.mAILDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAILDataGridViewTextBoxColumn.Name = "mAILDataGridViewTextBoxColumn";
            this.mAILDataGridViewTextBoxColumn.Width = 125;
            // 
            // tBLMusteriListBindingSource
            // 
            this.tBLMusteriListBindingSource.DataMember = "TBL_MusteriList";
            this.tBLMusteriListBindingSource.DataSource = this.musteriTakipSistemiDBDataSetBindingSource;
            // 
            // musteriTakipSistemiDBDataSetBindingSource
            // 
            this.musteriTakipSistemiDBDataSetBindingSource.DataSource = this.musteriTakipSistemi_DBDataSet;
            this.musteriTakipSistemiDBDataSetBindingSource.Position = 0;
            // 
            // musteriTakipSistemi_DBDataSet
            // 
            this.musteriTakipSistemi_DBDataSet.DataSetName = "MusteriTakipSistemi_DBDataSet";
            this.musteriTakipSistemi_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(503, 370);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 56);
            this.button3.TabIndex = 6;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.Color.GhostWhite;
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTel.Location = new System.Drawing.Point(438, 236);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(254, 34);
            this.txtTel.TabIndex = 4;
            // 
            // txtNo
            // 
            this.txtNo.BackColor = System.Drawing.Color.GhostWhite;
            this.txtNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNo.Location = new System.Drawing.Point(438, 31);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(254, 34);
            this.txtNo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(320, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 32);
            this.label5.TabIndex = 27;
            this.label5.Text = "No:";
            // 
            // tBL_MusteriListTableAdapter
            // 
            this.tBL_MusteriListTableAdapter.ClearBeforeFill = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnTemizle.Location = new System.Drawing.Point(617, 370);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 32);
            this.btnTemizle.TabIndex = 44;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // SilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(767, 864);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SilForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SilForm";
            this.Load += new System.EventHandler(this.SilForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMusteriListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriTakipSistemiDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriTakipSistemi_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource musteriTakipSistemiDBDataSetBindingSource;
        private MusteriTakipSistemi_DBDataSet musteriTakipSistemi_DBDataSet;
        private System.Windows.Forms.BindingSource tBLMusteriListBindingSource;
        private MusteriTakipSistemi_DBDataSetTableAdapters.TBL_MusteriListTableAdapter tBL_MusteriListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUSTERINODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnTemizle;
    }
}