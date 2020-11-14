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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nametovar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricetovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchetDataSet = new uchetzakazov.uchetDataSet();
            this.price_tovarTableAdapter = new uchetzakazov.uchetDataSetTableAdapters.price_tovarTableAdapter();
            this.clientsTableAdapter = new uchetzakazov.uchetDataSetTableAdapters.clientsTableAdapter();
            this.test = new System.Windows.Forms.TextBox();
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
            this.saveTovar.Click += new System.EventHandler(this.saveTovar_Click);
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
            this.id,
            this.nametovar,
            this.price});
            this.dataGridView1.DataSource = this.pricetovarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(547, 208);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // checkTovar
            // 
            this.checkTovar.HeaderText = " ";
            this.checkTovar.Name = "checkTovar";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nametovar
            // 
            this.nametovar.DataPropertyName = "name_tovar";
            this.nametovar.HeaderText = "name_tovar";
            this.nametovar.Name = "nametovar";
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "price";
            this.price.Name = "price";
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
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(294, 262);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(100, 20);
            this.test.TabIndex = 3;
            // 
            // priceTovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(576, 295);
            this.Controls.Add(this.test);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idtovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pricetovarBindingSource;
        private uchetDataSetTableAdapters.price_tovarTableAdapter price_tovarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricetovarDataGridViewTextBoxColumn;
        private uchetDataSetTableAdapters.clientsTableAdapter clientsTableAdapter;
        public uchetDataSet uchetDataSet;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkTovar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametovar;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        public System.Windows.Forms.TextBox test;
    }
}