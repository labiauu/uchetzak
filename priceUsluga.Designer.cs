namespace uchetzakazov
{
    partial class priceUsluga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(priceUsluga));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkUsluga = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameusluga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceuslugaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchetDataSet = new uchetzakazov.uchetDataSet();
            this.saveUsluga = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.price_uslugaTableAdapter = new uchetzakazov.uchetDataSetTableAdapters.price_uslugaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceuslugaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkUsluga,
            this.id,
            this.nameusluga,
            this.price});
            this.dataGridView1.DataSource = this.priceuslugaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 208);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // checkUsluga
            // 
            this.checkUsluga.HeaderText = "";
            this.checkUsluga.Name = "checkUsluga";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nameusluga
            // 
            this.nameusluga.DataPropertyName = "name_usluga";
            this.nameusluga.HeaderText = "Наименование";
            this.nameusluga.Name = "nameusluga";
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Цена р/час";
            this.price.Name = "price";
            // 
            // priceuslugaBindingSource
            // 
            this.priceuslugaBindingSource.DataMember = "price_usluga";
            this.priceuslugaBindingSource.DataSource = this.uchetDataSet;
            // 
            // uchetDataSet
            // 
            this.uchetDataSet.DataSetName = "uchetDataSet";
            this.uchetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saveUsluga
            // 
            this.saveUsluga.BackColor = System.Drawing.Color.SteelBlue;
            this.saveUsluga.Cursor = System.Windows.Forms.Cursors.Default;
            this.saveUsluga.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.saveUsluga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.saveUsluga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.saveUsluga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveUsluga.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveUsluga.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveUsluga.Location = new System.Drawing.Point(15, 244);
            this.saveUsluga.Name = "saveUsluga";
            this.saveUsluga.Size = new System.Drawing.Size(109, 28);
            this.saveUsluga.TabIndex = 1;
            this.saveUsluga.Text = "Сохранить";
            this.saveUsluga.UseVisualStyleBackColor = false;
            this.saveUsluga.Click += new System.EventHandler(this.saveUsluga_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите услугу из списка";
            // 
            // price_uslugaTableAdapter
            // 
            this.price_uslugaTableAdapter.ClearBeforeFill = true;
            // 
            // priceUsluga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(576, 295);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveUsluga);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "priceUsluga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Прайс-лист услуг";
            this.Load += new System.EventHandler(this.priceUsluga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceuslugaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button saveUsluga;
        private System.Windows.Forms.Label label1;
        private uchetDataSet uchetDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusulgaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource priceuslugaBindingSource;
        private uchetDataSetTableAdapters.price_uslugaTableAdapter price_uslugaTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkUsluga;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameusluga;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}