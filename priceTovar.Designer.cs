namespace uchetzakazov
{
    partial class priceTovar
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
            this.saveTovar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkTovar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idtovarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nametovarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricetovarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricetovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchetDataSet = new uchetzakazov.uchetDataSet();
            this.price_tovarTableAdapter = new uchetzakazov.uchetDataSetTableAdapters.price_tovarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricetovarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // saveTovar
            // 
            this.saveTovar.BackColor = System.Drawing.Color.YellowGreen;
            this.saveTovar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveTovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveTovar.Location = new System.Drawing.Point(15, 252);
            this.saveTovar.Name = "saveTovar";
            this.saveTovar.Size = new System.Drawing.Size(111, 28);
            this.saveTovar.TabIndex = 0;
            this.saveTovar.Text = "Сохранить";
            this.saveTovar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите товары из списка";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkTovar,
            this.idtovarDataGridViewTextBoxColumn,
            this.nametovarDataGridViewTextBoxColumn,
            this.pricetovarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pricetovarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 208);
            this.dataGridView1.TabIndex = 2;
            // 
            // checkTovar
            // 
            this.checkTovar.HeaderText = " ";
            this.checkTovar.Name = "checkTovar";
            // 
            // idtovarDataGridViewTextBoxColumn
            // 
            this.idtovarDataGridViewTextBoxColumn.DataPropertyName = "id_tovar";
            this.idtovarDataGridViewTextBoxColumn.HeaderText = "id товара";
            this.idtovarDataGridViewTextBoxColumn.Name = "idtovarDataGridViewTextBoxColumn";
            this.idtovarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nametovarDataGridViewTextBoxColumn
            // 
            this.nametovarDataGridViewTextBoxColumn.DataPropertyName = "name_tovar";
            this.nametovarDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nametovarDataGridViewTextBoxColumn.Name = "nametovarDataGridViewTextBoxColumn";
            // 
            // pricetovarDataGridViewTextBoxColumn
            // 
            this.pricetovarDataGridViewTextBoxColumn.DataPropertyName = "price_tovar";
            this.pricetovarDataGridViewTextBoxColumn.HeaderText = "Цена за шт.";
            this.pricetovarDataGridViewTextBoxColumn.Name = "pricetovarDataGridViewTextBoxColumn";
            // 
            // pricetovarBindingSource
            // 
            this.pricetovarBindingSource.DataMember = "price_tovar";
            this.pricetovarBindingSource.DataSource = this.uchetDataSet;
            // 
            // uchetDataSet
            // 
            this.uchetDataSet.DataSetName = "uchetDataSet";
            this.uchetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // price_tovarTableAdapter
            // 
            this.price_tovarTableAdapter.ClearBeforeFill = true;
            // 
            // priceTovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(576, 295);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveTovar);
            this.Name = "priceTovar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "priceTovar";
            this.Load += new System.EventHandler(this.priceTovar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricetovarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveTovar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private uchetDataSet uchetDataSet;
        private System.Windows.Forms.BindingSource pricetovarBindingSource;
        private uchetDataSetTableAdapters.price_tovarTableAdapter price_tovarTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkTovar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricetovarDataGridViewTextBoxColumn;
    }
}