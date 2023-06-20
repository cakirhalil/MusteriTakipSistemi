
namespace MusteriTakipSistemi
{
    partial class MusteriListForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUSTERINODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLMusteriListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musteriTakipSistemi_DBDataSet = new MusteriTakipSistemi.MusteriTakipSistemi_DBDataSet();
            this.tBL_MusteriListTableAdapter = new MusteriTakipSistemi.MusteriTakipSistemi_DBDataSetTableAdapters.TBL_MusteriListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMusteriListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriTakipSistemi_DBDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1054, 469);
            this.dataGridView1.TabIndex = 0;
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
            this.tBLMusteriListBindingSource.DataSource = this.musteriTakipSistemi_DBDataSet;
            // 
            // musteriTakipSistemi_DBDataSet
            // 
            this.musteriTakipSistemi_DBDataSet.DataSetName = "MusteriTakipSistemi_DBDataSet";
            this.musteriTakipSistemi_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBL_MusteriListTableAdapter
            // 
            this.tBL_MusteriListTableAdapter.ClearBeforeFill = true;
            // 
            // MusteriListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1075, 493);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MusteriListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriListForm";
            this.Load += new System.EventHandler(this.MusteriListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMusteriListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriTakipSistemi_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MusteriTakipSistemi_DBDataSet musteriTakipSistemi_DBDataSet;
        private System.Windows.Forms.BindingSource tBLMusteriListBindingSource;
        private MusteriTakipSistemi_DBDataSetTableAdapters.TBL_MusteriListTableAdapter tBL_MusteriListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUSTERINODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAILDataGridViewTextBoxColumn;
    }
}