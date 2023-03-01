namespace WindowsFormsApp2
{
    partial class Form1
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
            this.comboBoxPhongBan = new System.Windows.Forms.ComboBox();
            this.dataGridViewNhanVien = new System.Windows.Forms.DataGridView();
            this.IDStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeTown = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddSV = new System.Windows.Forms.Button();
            this.buttonSaveSV = new System.Windows.Forms.Button();
            this.buttonDeleteSV = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxDepartment = new System.Windows.Forms.TextBox();
            this.textBoxIDStudent = new System.Windows.Forms.TextBox();
            this.textBoxfullName = new System.Windows.Forms.TextBox();
            this.textBoxhomeTown = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPhongBan
            // 
            this.comboBoxPhongBan.FormattingEnabled = true;
            this.comboBoxPhongBan.Location = new System.Drawing.Point(47, 35);
            this.comboBoxPhongBan.Name = "comboBoxPhongBan";
            this.comboBoxPhongBan.Size = new System.Drawing.Size(282, 26);
            this.comboBoxPhongBan.TabIndex = 0;
            this.comboBoxPhongBan.SelectedIndexChanged += new System.EventHandler(this.comboBoxPhongBan_SelectedIndexChanged);
            // 
            // dataGridViewNhanVien
            // 
            this.dataGridViewNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDStudent,
            this.fullName,
            this.homeTown,
            this.ID});
            this.dataGridViewNhanVien.Location = new System.Drawing.Point(47, 110);
            this.dataGridViewNhanVien.Name = "dataGridViewNhanVien";
            this.dataGridViewNhanVien.RowTemplate.Height = 24;
            this.dataGridViewNhanVien.Size = new System.Drawing.Size(700, 258);
            this.dataGridViewNhanVien.TabIndex = 1;
            // 
            // IDStudent
            // 
            this.IDStudent.DataPropertyName = "IDStudent";
            this.IDStudent.HeaderText = "ID of Student";
            this.IDStudent.Name = "IDStudent";
            this.IDStudent.Width = 200;
            // 
            // fullName
            // 
            this.fullName.DataPropertyName = "fullName";
            this.fullName.HeaderText = "Full name";
            this.fullName.Name = "fullName";
            this.fullName.Width = 200;
            // 
            // homeTown
            // 
            this.homeTown.DataPropertyName = "homeTown";
            this.homeTown.HeaderText = "Hometown";
            this.homeTown.Name = "homeTown";
            this.homeTown.Width = 200;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(591, 67);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(81, 37);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(692, 67);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(92, 37);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(806, 67);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(82, 37);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddSV
            // 
            this.buttonAddSV.Location = new System.Drawing.Point(458, 447);
            this.buttonAddSV.Name = "buttonAddSV";
            this.buttonAddSV.Size = new System.Drawing.Size(81, 37);
            this.buttonAddSV.TabIndex = 10;
            this.buttonAddSV.Text = "Add";
            this.buttonAddSV.UseVisualStyleBackColor = true;
            this.buttonAddSV.Click += new System.EventHandler(this.buttonAddSV_Click);
            // 
            // buttonSaveSV
            // 
            this.buttonSaveSV.Location = new System.Drawing.Point(560, 447);
            this.buttonSaveSV.Name = "buttonSaveSV";
            this.buttonSaveSV.Size = new System.Drawing.Size(81, 37);
            this.buttonSaveSV.TabIndex = 11;
            this.buttonSaveSV.Text = "Save";
            this.buttonSaveSV.UseVisualStyleBackColor = true;
            this.buttonSaveSV.Click += new System.EventHandler(this.buttonSaveSV_Click);
            // 
            // buttonDeleteSV
            // 
            this.buttonDeleteSV.Location = new System.Drawing.Point(666, 447);
            this.buttonDeleteSV.Name = "buttonDeleteSV";
            this.buttonDeleteSV.Size = new System.Drawing.Size(81, 37);
            this.buttonDeleteSV.TabIndex = 12;
            this.buttonDeleteSV.Text = "Delete";
            this.buttonDeleteSV.UseVisualStyleBackColor = true;
            this.buttonDeleteSV.Click += new System.EventHandler(this.buttonDeleteSV_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(355, 37);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(72, 24);
            this.textBoxID.TabIndex = 13;
            // 
            // textBoxDepartment
            // 
            this.textBoxDepartment.Location = new System.Drawing.Point(448, 37);
            this.textBoxDepartment.Name = "textBoxDepartment";
            this.textBoxDepartment.Size = new System.Drawing.Size(224, 24);
            this.textBoxDepartment.TabIndex = 14;
            // 
            // textBoxIDStudent
            // 
            this.textBoxIDStudent.Enabled = false;
            this.textBoxIDStudent.Location = new System.Drawing.Point(157, 396);
            this.textBoxIDStudent.Name = "textBoxIDStudent";
            this.textBoxIDStudent.Size = new System.Drawing.Size(87, 24);
            this.textBoxIDStudent.TabIndex = 15;
            // 
            // textBoxfullName
            // 
            this.textBoxfullName.Location = new System.Drawing.Point(157, 426);
            this.textBoxfullName.Name = "textBoxfullName";
            this.textBoxfullName.Size = new System.Drawing.Size(270, 24);
            this.textBoxfullName.TabIndex = 16;
            // 
            // textBoxhomeTown
            // 
            this.textBoxhomeTown.Location = new System.Drawing.Point(157, 460);
            this.textBoxhomeTown.Name = "textBoxhomeTown";
            this.textBoxhomeTown.Size = new System.Drawing.Size(270, 24);
            this.textBoxhomeTown.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Name of Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "ID Student";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Full Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Hometown";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 506);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxhomeTown);
            this.Controls.Add(this.textBoxfullName);
            this.Controls.Add(this.textBoxIDStudent);
            this.Controls.Add(this.textBoxDepartment);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonDeleteSV);
            this.Controls.Add(this.buttonSaveSV);
            this.Controls.Add(this.buttonAddSV);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewNhanVien);
            this.Controls.Add(this.comboBoxPhongBan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Connect and Read datas with SQL Server(Members of Departments)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPhongBan;
        private System.Windows.Forms.DataGridView dataGridViewNhanVien;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAddSV;
        private System.Windows.Forms.Button buttonSaveSV;
        private System.Windows.Forms.Button buttonDeleteSV;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxDepartment;
        private System.Windows.Forms.TextBox textBoxIDStudent;
        private System.Windows.Forms.TextBox textBoxfullName;
        private System.Windows.Forms.TextBox textBoxhomeTown;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeTown;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

