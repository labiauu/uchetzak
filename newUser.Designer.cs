namespace uchetzakazov
{
    partial class newUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newUser));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.roleBox = new System.Windows.Forms.ComboBox();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchetDataSet = new uchetzakazov.uchetDataSet();
            this.roleTableAdapter = new uchetzakazov.uchetDataSetTableAdapters.roleTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление нового сотрудника";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(12, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logBox
            // 
            this.logBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logBox.Location = new System.Drawing.Point(12, 60);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(192, 24);
            this.logBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль:";
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passBox.Location = new System.Drawing.Point(12, 105);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(192, 24);
            this.passBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(228, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Роль:";
            // 
            // roleBox
            // 
            this.roleBox.DataSource = this.roleBindingSource;
            this.roleBox.DisplayMember = "name_role";
            this.roleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleBox.FormattingEnabled = true;
            this.roleBox.Location = new System.Drawing.Point(231, 60);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(192, 26);
            this.roleBox.TabIndex = 7;
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataMember = "role";
            this.roleBindingSource.DataSource = this.uchetDataSet;
            // 
            // uchetDataSet
            // 
            this.uchetDataSet.DataSetName = "uchetDataSet";
            this.uchetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roleTableAdapter
            // 
            this.roleTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(135, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = " Отменить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // newUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(435, 195);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.roleBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "newUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание нового пользователя";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.newUser_FormClosed);
            this.Load += new System.EventHandler(this.newUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox roleBox;
        private uchetDataSet uchetDataSet;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private uchetDataSetTableAdapters.roleTableAdapter roleTableAdapter;
        private System.Windows.Forms.Button button2;
    }
}