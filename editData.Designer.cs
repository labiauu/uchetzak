namespace uchetzakazov
{
    partial class editData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.editClient = new System.Windows.Forms.TextBox();
            this.btnAddUsluga = new System.Windows.Forms.Button();
            this.btnAddTovar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idzakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namezakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricezakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtovarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iduslugaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sostavzakazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchetDataSet = new uchetzakazov.uchetDataSet();
            this.editStatus = new System.Windows.Forms.ComboBox();
            this.statusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.editComment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.editNumber = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.editAdress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusesTableAdapter = new uchetzakazov.uchetDataSetTableAdapters.statusesTableAdapter();
            this.zakazTableAdapter = new uchetzakazov.uchetDataSetTableAdapters.zakazTableAdapter();
            this.saveChanges = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sostavzakazTableAdapter = new uchetzakazov.uchetDataSetTableAdapters.sostavzakazTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sostavzakazBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.editClient);
            this.groupBox1.Controls.Add(this.btnAddUsluga);
            this.groupBox1.Controls.Add(this.btnAddTovar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.editStatus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.editComment);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.editNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.editAdress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 330);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Изменить данные о клиенте";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 201);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 26);
            this.textBox1.TabIndex = 15;
            // 
            // editClient
            // 
            this.editClient.Location = new System.Drawing.Point(9, 101);
            this.editClient.Name = "editClient";
            this.editClient.Size = new System.Drawing.Size(261, 26);
            this.editClient.TabIndex = 14;
            // 
            // btnAddUsluga
            // 
            this.btnAddUsluga.BackColor = System.Drawing.Color.White;
            this.btnAddUsluga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddUsluga.Location = new System.Drawing.Point(426, 283);
            this.btnAddUsluga.Name = "btnAddUsluga";
            this.btnAddUsluga.Size = new System.Drawing.Size(117, 23);
            this.btnAddUsluga.TabIndex = 13;
            this.btnAddUsluga.Text = "Добавить услугу";
            this.btnAddUsluga.UseVisualStyleBackColor = false;
            this.btnAddUsluga.Click += new System.EventHandler(this.btnAddUsluga_Click);
            // 
            // btnAddTovar
            // 
            this.btnAddTovar.BackColor = System.Drawing.Color.White;
            this.btnAddTovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddTovar.Location = new System.Drawing.Point(303, 283);
            this.btnAddTovar.Name = "btnAddTovar";
            this.btnAddTovar.Size = new System.Drawing.Size(117, 23);
            this.btnAddTovar.TabIndex = 12;
            this.btnAddTovar.Text = "Добавить товар";
            this.btnAddTovar.UseVisualStyleBackColor = false;
            this.btnAddTovar.Click += new System.EventHandler(this.btnAddTovar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(273, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Заказ клиента";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idzakDataGridViewTextBoxColumn,
            this.namezakDataGridViewTextBoxColumn,
            this.pricezakDataGridViewTextBoxColumn,
            this.idclientDataGridViewTextBoxColumn,
            this.idtovarDataGridViewTextBoxColumn,
            this.iduslugaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sostavzakazBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(276, 43);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(429, 233);
            this.dataGridView1.TabIndex = 10;
            // 
            // idzakDataGridViewTextBoxColumn
            // 
            this.idzakDataGridViewTextBoxColumn.DataPropertyName = "id_zak";
            this.idzakDataGridViewTextBoxColumn.HeaderText = "id_zak";
            this.idzakDataGridViewTextBoxColumn.Name = "idzakDataGridViewTextBoxColumn";
            this.idzakDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namezakDataGridViewTextBoxColumn
            // 
            this.namezakDataGridViewTextBoxColumn.DataPropertyName = "name_zak";
            this.namezakDataGridViewTextBoxColumn.HeaderText = "name_zak";
            this.namezakDataGridViewTextBoxColumn.Name = "namezakDataGridViewTextBoxColumn";
            // 
            // pricezakDataGridViewTextBoxColumn
            // 
            this.pricezakDataGridViewTextBoxColumn.DataPropertyName = "price_zak";
            this.pricezakDataGridViewTextBoxColumn.HeaderText = "price_zak";
            this.pricezakDataGridViewTextBoxColumn.Name = "pricezakDataGridViewTextBoxColumn";
            // 
            // idclientDataGridViewTextBoxColumn
            // 
            this.idclientDataGridViewTextBoxColumn.DataPropertyName = "id_client";
            this.idclientDataGridViewTextBoxColumn.HeaderText = "id_client";
            this.idclientDataGridViewTextBoxColumn.Name = "idclientDataGridViewTextBoxColumn";
            // 
            // idtovarDataGridViewTextBoxColumn
            // 
            this.idtovarDataGridViewTextBoxColumn.DataPropertyName = "id_tovar";
            this.idtovarDataGridViewTextBoxColumn.HeaderText = "id_tovar";
            this.idtovarDataGridViewTextBoxColumn.Name = "idtovarDataGridViewTextBoxColumn";
            // 
            // iduslugaDataGridViewTextBoxColumn
            // 
            this.iduslugaDataGridViewTextBoxColumn.DataPropertyName = "id_usluga";
            this.iduslugaDataGridViewTextBoxColumn.HeaderText = "id_usluga";
            this.iduslugaDataGridViewTextBoxColumn.Name = "iduslugaDataGridViewTextBoxColumn";
            // 
            // sostavzakazBindingSource
            // 
            this.sostavzakazBindingSource.DataMember = "sostavzakaz";
            this.sostavzakazBindingSource.DataSource = this.uchetDataSet;
            // 
            // uchetDataSet
            // 
            this.uchetDataSet.DataSetName = "uchetDataSet";
            this.uchetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // editStatus
            // 
            this.editStatus.DataSource = this.statusesBindingSource;
            this.editStatus.DisplayMember = "name";
            this.editStatus.FormattingEnabled = true;
            this.editStatus.Location = new System.Drawing.Point(9, 44);
            this.editStatus.Name = "editStatus";
            this.editStatus.Size = new System.Drawing.Size(261, 28);
            this.editStatus.TabIndex = 9;
            // 
            // statusesBindingSource
            // 
            this.statusesBindingSource.DataMember = "statuses";
            this.statusesBindingSource.DataSource = this.uchetDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Статус";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // editComment
            // 
            this.editComment.Location = new System.Drawing.Point(9, 251);
            this.editComment.Name = "editComment";
            this.editComment.Size = new System.Drawing.Size(261, 26);
            this.editComment.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Комментарий";
            // 
            // editNumber
            // 
            this.editNumber.Location = new System.Drawing.Point(9, 151);
            this.editNumber.Mask = "+79990000000";
            this.editNumber.Name = "editNumber";
            this.editNumber.Size = new System.Drawing.Size(261, 26);
            this.editNumber.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Адрес";
            // 
            // editAdress
            // 
            this.editAdress.Location = new System.Drawing.Point(9, 201);
            this.editAdress.Name = "editAdress";
            this.editAdress.Size = new System.Drawing.Size(261, 26);
            this.editAdress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер телефона";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клиент";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // statusesTableAdapter
            // 
            this.statusesTableAdapter.ClearBeforeFill = true;
            // 
            // zakazTableAdapter
            // 
            this.zakazTableAdapter.ClearBeforeFill = true;
            // 
            // saveChanges
            // 
            this.saveChanges.BackColor = System.Drawing.Color.YellowGreen;
            this.saveChanges.FlatAppearance.BorderSize = 0;
            this.saveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveChanges.Location = new System.Drawing.Point(12, 348);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(147, 35);
            this.saveChanges.TabIndex = 12;
            this.saveChanges.Text = "Сохранить изменения";
            this.saveChanges.UseVisualStyleBackColor = false;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(165, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Отменить изменения";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sostavzakazTableAdapter
            // 
            this.sostavzakazTableAdapter.ClearBeforeFill = true;
            // 
            // editData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(735, 433);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(this.groupBox1);
            this.Name = "editData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "editData";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.editData_FormClosed);
            this.Load += new System.EventHandler(this.editData_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sostavzakazBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private uchetDataSetTableAdapters.statusesTableAdapter statusesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private uchetDataSetTableAdapters.zakazTableAdapter zakazTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddUsluga;
        private System.Windows.Forms.Button btnAddTovar;
        public System.Windows.Forms.TextBox editAdress;
        public System.Windows.Forms.MaskedTextBox editNumber;
        public System.Windows.Forms.TextBox editComment;
        public System.Windows.Forms.ComboBox editStatus;
        public System.Windows.Forms.TextBox editClient;
        public System.Windows.Forms.TextBox textBox1;
        private uchetDataSet uchetDataSet;
        private uchetDataSetTableAdapters.sostavzakazTableAdapter sostavzakazTableAdapter;
        private System.Windows.Forms.BindingSource statusesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sostavzakazBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idzakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namezakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricezakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduslugaDataGridViewTextBoxColumn;
    }
}