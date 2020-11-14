namespace uchetzakazov
{
    partial class FormUsers
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
            this.uchetDataSet = new uchetzakazov.uchetDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new uchetzakazov.uchetDataSetTableAdapters.usersTableAdapter();
            this.newUser = new System.Windows.Forms.Button();
            this.deleteUser = new System.Windows.Forms.Button();
            this.checkUser = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iduserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idroleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkUser,
            this.iduserDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.idroleDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(-1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 200);
            this.dataGridView1.TabIndex = 0;
            // 
            // uchetDataSet
            // 
            this.uchetDataSet.DataSetName = "uchetDataSet";
            this.uchetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.uchetDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // newUser
            // 
            this.newUser.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.newUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newUser.Location = new System.Drawing.Point(12, 205);
            this.newUser.Name = "newUser";
            this.newUser.Size = new System.Drawing.Size(106, 23);
            this.newUser.TabIndex = 1;
            this.newUser.Text = "Добавить";
            this.newUser.UseVisualStyleBackColor = false;
            this.newUser.Click += new System.EventHandler(this.newUser_Click);
            // 
            // deleteUser
            // 
            this.deleteUser.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteUser.Location = new System.Drawing.Point(124, 205);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(106, 23);
            this.deleteUser.TabIndex = 2;
            this.deleteUser.Text = "Удалить";
            this.deleteUser.UseVisualStyleBackColor = false;
            // 
            // checkUser
            // 
            this.checkUser.HeaderText = "";
            this.checkUser.Name = "checkUser";
            this.checkUser.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // iduserDataGridViewTextBoxColumn
            // 
            this.iduserDataGridViewTextBoxColumn.DataPropertyName = "id_user";
            this.iduserDataGridViewTextBoxColumn.HeaderText = "id";
            this.iduserDataGridViewTextBoxColumn.Name = "iduserDataGridViewTextBoxColumn";
            this.iduserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // idroleDataGridViewTextBoxColumn
            // 
            this.idroleDataGridViewTextBoxColumn.DataPropertyName = "id_role";
            this.idroleDataGridViewTextBoxColumn.HeaderText = "Роль";
            this.idroleDataGridViewTextBoxColumn.Name = "idroleDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(541, 340);
            this.Controls.Add(this.deleteUser);
            this.Controls.Add(this.newUser);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUsers";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private uchetDataSet uchetDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private uchetDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Button newUser;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idroleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}