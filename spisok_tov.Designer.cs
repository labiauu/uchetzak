namespace uchetzakazov
{
    partial class spisok_tov
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
            this.uchetDataSet1 = new uchetzakazov.uchetDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.addTovar = new System.Windows.Forms.Button();
            this.addUsluga = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.zakazTableAdapter1 = new uchetzakazov.uchetDataSetTableAdapters.zakazTableAdapter();
            this.idzakazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idusulgaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iduserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveZakaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uchetDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // uchetDataSet1
            // 
            this.uchetDataSet1.DataSetName = "uchetDataSet";
            this.uchetDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "price_tovar";
            this.bindingSource1.DataSource = this.uchetDataSet1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Выберите что хотите добавить";
            // 
            // addTovar
            // 
            this.addTovar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addTovar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addTovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTovar.Location = new System.Drawing.Point(15, 30);
            this.addTovar.Name = "addTovar";
            this.addTovar.Size = new System.Drawing.Size(97, 23);
            this.addTovar.TabIndex = 1;
            this.addTovar.Text = "Товар";
            this.addTovar.UseVisualStyleBackColor = false;
            this.addTovar.Click += new System.EventHandler(this.addTovar_Click);
            // 
            // addUsluga
            // 
            this.addUsluga.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addUsluga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addUsluga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addUsluga.Location = new System.Drawing.Point(140, 30);
            this.addUsluga.Name = "addUsluga";
            this.addUsluga.Size = new System.Drawing.Size(97, 23);
            this.addUsluga.TabIndex = 2;
            this.addUsluga.Text = "Услугу";
            this.addUsluga.UseVisualStyleBackColor = false;
            this.addUsluga.Click += new System.EventHandler(this.addUsluga_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Заказ клиента";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idzakazDataGridViewTextBoxColumn,
            this.idclientDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.idusulgaDataGridViewTextBoxColumn,
            this.iduserDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(15, 91);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(555, 158);
            this.dataGridView2.TabIndex = 4;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "zakaz";
            this.bindingSource2.DataSource = this.uchetDataSet1;
            // 
            // zakazTableAdapter1
            // 
            this.zakazTableAdapter1.ClearBeforeFill = true;
            // 
            // idzakazDataGridViewTextBoxColumn
            // 
            this.idzakazDataGridViewTextBoxColumn.DataPropertyName = "id_zakaz";
            this.idzakazDataGridViewTextBoxColumn.HeaderText = "Номер заказа";
            this.idzakazDataGridViewTextBoxColumn.Name = "idzakazDataGridViewTextBoxColumn";
            this.idzakazDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idclientDataGridViewTextBoxColumn
            // 
            this.idclientDataGridViewTextBoxColumn.DataPropertyName = "id_client";
            this.idclientDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.idclientDataGridViewTextBoxColumn.Name = "idclientDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_tovar";
            this.dataGridViewTextBoxColumn1.HeaderText = "Товар";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // idusulgaDataGridViewTextBoxColumn
            // 
            this.idusulgaDataGridViewTextBoxColumn.DataPropertyName = "id_usulga";
            this.idusulgaDataGridViewTextBoxColumn.HeaderText = "Услуга";
            this.idusulgaDataGridViewTextBoxColumn.Name = "idusulgaDataGridViewTextBoxColumn";
            // 
            // iduserDataGridViewTextBoxColumn
            // 
            this.iduserDataGridViewTextBoxColumn.DataPropertyName = "id_user";
            this.iduserDataGridViewTextBoxColumn.HeaderText = "Ответственный сотрудник";
            this.iduserDataGridViewTextBoxColumn.Name = "iduserDataGridViewTextBoxColumn";
            // 
            // saveZakaz
            // 
            this.saveZakaz.BackColor = System.Drawing.Color.YellowGreen;
            this.saveZakaz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveZakaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveZakaz.Location = new System.Drawing.Point(15, 255);
            this.saveZakaz.Name = "saveZakaz";
            this.saveZakaz.Size = new System.Drawing.Size(111, 28);
            this.saveZakaz.TabIndex = 5;
            this.saveZakaz.Text = "Сохранить";
            this.saveZakaz.UseVisualStyleBackColor = false;
            // 
            // spisok_tov
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(652, 311);
            this.Controls.Add(this.saveZakaz);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addUsluga);
            this.Controls.Add(this.addTovar);
            this.Controls.Add(this.label2);
            this.Name = "spisok_tov";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.spisok_tov_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.uchetDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private uchetDataSet uchetDataSet;
        private System.Windows.Forms.BindingSource pricetovarBindingSource;
        private uchetDataSetTableAdapters.price_tovarTableAdapter price_tovarTableAdapter;
        private System.Windows.Forms.BindingSource priceuslugaBindingSource;
        private uchetDataSetTableAdapters.price_uslugaTableAdapter price_uslugaTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource zakazBindingSource;
        private uchetDataSetTableAdapters.zakazTableAdapter zakazTableAdapter;
        private System.Windows.Forms.BindingSource pricetovarBindingSource1;
        private System.Windows.Forms.BindingSource priceuslugaBindingSource1;
        private System.Windows.Forms.GroupBox boxTovar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricetovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.RadioButton radioTovar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioUsluga;
        private uchetDataSet uchetDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addTovar;
        private System.Windows.Forms.Button addUsluga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource bindingSource2;
        private uchetDataSetTableAdapters.zakazTableAdapter zakazTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idzakazDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusulgaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduserDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button saveZakaz;
    }
}