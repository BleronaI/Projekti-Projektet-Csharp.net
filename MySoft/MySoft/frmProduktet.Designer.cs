namespace MySoft
{
    partial class frmProduktet
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtEmri = new System.Windows.Forms.TextBox();
            this.txtCmimiMeTVSH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.txtPershkrimi = new System.Windows.Forms.TextBox();
            this.cbKategoria = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.radioVendor = new System.Windows.Forms.RadioButton();
            this.radioJoVendor = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.brnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.dgvProduktet = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmimiMeTVSH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pershkrimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KategoriaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoVendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduktet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(161, 9);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 0;
            // 
            // txtEmri
            // 
            this.txtEmri.Location = new System.Drawing.Point(161, 52);
            this.txtEmri.Name = "txtEmri";
            this.txtEmri.Size = new System.Drawing.Size(100, 22);
            this.txtEmri.TabIndex = 1;
            // 
            // txtCmimiMeTVSH
            // 
            this.txtCmimiMeTVSH.Location = new System.Drawing.Point(161, 97);
            this.txtCmimiMeTVSH.Name = "txtCmimiMeTVSH";
            this.txtCmimiMeTVSH.Size = new System.Drawing.Size(100, 22);
            this.txtCmimiMeTVSH.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Emri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "CmimiMeTVSH";
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(161, 141);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 22);
            this.dtpData.TabIndex = 6;
            // 
            // txtPershkrimi
            // 
            this.txtPershkrimi.Location = new System.Drawing.Point(161, 194);
            this.txtPershkrimi.Name = "txtPershkrimi";
            this.txtPershkrimi.Size = new System.Drawing.Size(100, 22);
            this.txtPershkrimi.TabIndex = 7;
            // 
            // cbKategoria
            // 
            this.cbKategoria.FormattingEnabled = true;
            this.cbKategoria.Location = new System.Drawing.Point(161, 239);
            this.cbKategoria.Name = "cbKategoria";
            this.cbKategoria.Size = new System.Drawing.Size(121, 24);
            this.cbKategoria.TabIndex = 8;
            this.cbKategoria.SelectedIndexChanged += new System.EventHandler(this.cbKategoria_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(161, 286);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 22);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // radioVendor
            // 
            this.radioVendor.AutoSize = true;
            this.radioVendor.Location = new System.Drawing.Point(542, 40);
            this.radioVendor.Name = "radioVendor";
            this.radioVendor.Size = new System.Drawing.Size(72, 20);
            this.radioVendor.TabIndex = 10;
            this.radioVendor.TabStop = true;
            this.radioVendor.Text = "Vendor";
            this.radioVendor.UseVisualStyleBackColor = true;
            // 
            // radioJoVendor
            // 
            this.radioJoVendor.AutoSize = true;
            this.radioJoVendor.Location = new System.Drawing.Point(542, 97);
            this.radioJoVendor.Name = "radioJoVendor";
            this.radioJoVendor.Size = new System.Drawing.Size(90, 20);
            this.radioJoVendor.TabIndex = 11;
            this.radioJoVendor.TabStop = true;
            this.radioJoVendor.Text = "Jo Vendor";
            this.radioJoVendor.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(542, 147);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // brnClear
            // 
            this.brnClear.Location = new System.Drawing.Point(667, 147);
            this.brnClear.Name = "brnClear";
            this.brnClear.Size = new System.Drawing.Size(75, 23);
            this.brnClear.TabIndex = 13;
            this.brnClear.Text = "Clear";
            this.brnClear.UseVisualStyleBackColor = true;
            this.brnClear.Click += new System.EventHandler(this.brnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(797, 147);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Pershkrimi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Kategoria";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Search";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // dgvProduktet
            // 
            this.dgvProduktet.AllowUserToAddRows = false;
            this.dgvProduktet.AllowUserToDeleteRows = false;
            this.dgvProduktet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduktet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Emri,
            this.CmimiMeTVSH,
            this.Data,
            this.Pershkrimi,
            this.KategoriaId,
            this.Vendor,
            this.JoVendor});
            this.dgvProduktet.Location = new System.Drawing.Point(12, 337);
            this.dgvProduktet.Name = "dgvProduktet";
            this.dgvProduktet.ReadOnly = true;
            this.dgvProduktet.RowHeadersWidth = 51;
            this.dgvProduktet.RowTemplate.Height = 24;
            this.dgvProduktet.Size = new System.Drawing.Size(1056, 283);
            this.dgvProduktet.TabIndex = 19;
            this.dgvProduktet.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduktet_RowEnter);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // Emri
            // 
            this.Emri.DataPropertyName = "Emri";
            this.Emri.HeaderText = "Emri";
            this.Emri.MinimumWidth = 6;
            this.Emri.Name = "Emri";
            this.Emri.ReadOnly = true;
            this.Emri.Width = 125;
            // 
            // CmimiMeTVSH
            // 
            this.CmimiMeTVSH.DataPropertyName = "CmimiMeTVSH";
            this.CmimiMeTVSH.HeaderText = "CmimiMeTVSH";
            this.CmimiMeTVSH.MinimumWidth = 6;
            this.CmimiMeTVSH.Name = "CmimiMeTVSH";
            this.CmimiMeTVSH.ReadOnly = true;
            this.CmimiMeTVSH.Width = 125;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.MinimumWidth = 6;
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 125;
            // 
            // Pershkrimi
            // 
            this.Pershkrimi.DataPropertyName = "Pershkrimi";
            this.Pershkrimi.HeaderText = "Pershkrimi";
            this.Pershkrimi.MinimumWidth = 6;
            this.Pershkrimi.Name = "Pershkrimi";
            this.Pershkrimi.ReadOnly = true;
            this.Pershkrimi.Width = 125;
            // 
            // KategoriaId
            // 
            this.KategoriaId.DataPropertyName = "KategoriaId";
            this.KategoriaId.HeaderText = "KategoriaId";
            this.KategoriaId.MinimumWidth = 6;
            this.KategoriaId.Name = "KategoriaId";
            this.KategoriaId.ReadOnly = true;
            this.KategoriaId.Width = 125;
            // 
            // Vendor
            // 
            this.Vendor.DataPropertyName = "Vendor";
            this.Vendor.HeaderText = "Vendor";
            this.Vendor.MinimumWidth = 6;
            this.Vendor.Name = "Vendor";
            this.Vendor.ReadOnly = true;
            this.Vendor.Width = 125;
            // 
            // JoVendor
            // 
            this.JoVendor.DataPropertyName = "JoVendor";
            this.JoVendor.HeaderText = "JoVendor";
            this.JoVendor.MinimumWidth = 6;
            this.JoVendor.Name = "JoVendor";
            this.JoVendor.ReadOnly = true;
            this.JoVendor.Width = 125;
            // 
            // frmProduktet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 632);
            this.Controls.Add(this.dgvProduktet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.brnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.radioJoVendor);
            this.Controls.Add(this.radioVendor);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbKategoria);
            this.Controls.Add(this.txtPershkrimi);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCmimiMeTVSH);
            this.Controls.Add(this.txtEmri);
            this.Controls.Add(this.txtId);
            this.Name = "frmProduktet";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmProduktet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduktet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtEmri;
        private System.Windows.Forms.TextBox txtCmimiMeTVSH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox txtPershkrimi;
        private System.Windows.Forms.ComboBox cbKategoria;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton radioVendor;
        private System.Windows.Forms.RadioButton radioJoVendor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button brnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.DataGridView dgvProduktet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emri;
        private System.Windows.Forms.DataGridViewTextBoxColumn CmimiMeTVSH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pershkrimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategoriaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoVendor;
    }
}

