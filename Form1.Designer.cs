
namespace Chapter13_DatabaseExample_.NETFramework_
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
            this.components = new System.ComponentModel.Container();
            this.dataGridStudent = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cExampleDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._C_ExampleDatabaseDataSet = new Chapter13_DatabaseExample_.NETFramework_._C_ExampleDatabaseDataSet();
            this.studentTableAdapter = new Chapter13_DatabaseExample_.NETFramework_._C_ExampleDatabaseDataSetTableAdapters.StudentTableAdapter();
            this.dataGridMajor = new System.Windows.Forms.DataGridView();
            this.majorIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorChairDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._C_ExampleDatabaseDataSet1 = new Chapter13_DatabaseExample_.NETFramework_._C_ExampleDatabaseDataSet1();
            this.departmentTableAdapter = new Chapter13_DatabaseExample_.NETFramework_._C_ExampleDatabaseDataSet1TableAdapters.DepartmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cExampleDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._C_ExampleDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMajor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._C_ExampleDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridStudent
            // 
            this.dataGridStudent.AutoGenerateColumns = false;
            this.dataGridStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.studentFirstNameDataGridViewTextBoxColumn,
            this.studentLastNameDataGridViewTextBoxColumn,
            this.majorIDDataGridViewTextBoxColumn,
            this.studentPhoneDataGridViewTextBoxColumn});
            this.dataGridStudent.DataSource = this.studentBindingSource;
            this.dataGridStudent.Location = new System.Drawing.Point(12, 12);
            this.dataGridStudent.Name = "dataGridStudent";
            this.dataGridStudent.RowHeadersWidth = 51;
            this.dataGridStudent.RowTemplate.Height = 24;
            this.dataGridStudent.Size = new System.Drawing.Size(940, 150);
            this.dataGridStudent.TabIndex = 0;
            this.dataGridStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStudent_CellContentClick);
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "student_ID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "student_ID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentFirstNameDataGridViewTextBoxColumn
            // 
            this.studentFirstNameDataGridViewTextBoxColumn.DataPropertyName = "student_FirstName";
            this.studentFirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.studentFirstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentFirstNameDataGridViewTextBoxColumn.Name = "studentFirstNameDataGridViewTextBoxColumn";
            this.studentFirstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentLastNameDataGridViewTextBoxColumn
            // 
            this.studentLastNameDataGridViewTextBoxColumn.DataPropertyName = "student_LastName";
            this.studentLastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.studentLastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentLastNameDataGridViewTextBoxColumn.Name = "studentLastNameDataGridViewTextBoxColumn";
            this.studentLastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // majorIDDataGridViewTextBoxColumn
            // 
            this.majorIDDataGridViewTextBoxColumn.DataPropertyName = "major_ID";
            this.majorIDDataGridViewTextBoxColumn.HeaderText = "major_ID";
            this.majorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.majorIDDataGridViewTextBoxColumn.Name = "majorIDDataGridViewTextBoxColumn";
            this.majorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentPhoneDataGridViewTextBoxColumn
            // 
            this.studentPhoneDataGridViewTextBoxColumn.DataPropertyName = "student_Phone";
            this.studentPhoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.studentPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentPhoneDataGridViewTextBoxColumn.Name = "studentPhoneDataGridViewTextBoxColumn";
            this.studentPhoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.cExampleDatabaseDataSetBindingSource;
            // 
            // cExampleDatabaseDataSetBindingSource
            // 
            this.cExampleDatabaseDataSetBindingSource.DataSource = this._C_ExampleDatabaseDataSet;
            this.cExampleDatabaseDataSetBindingSource.Position = 0;
            // 
            // _C_ExampleDatabaseDataSet
            // 
            this._C_ExampleDatabaseDataSet.DataSetName = "_C_ExampleDatabaseDataSet";
            this._C_ExampleDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridMajor
            // 
            this.dataGridMajor.AutoGenerateColumns = false;
            this.dataGridMajor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMajor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.majorIDDataGridViewTextBoxColumn1,
            this.majorNameDataGridViewTextBoxColumn,
            this.majorChairDataGridViewTextBoxColumn,
            this.majorPhoneDataGridViewTextBoxColumn});
            this.dataGridMajor.DataSource = this.departmentBindingSource;
            this.dataGridMajor.Location = new System.Drawing.Point(13, 169);
            this.dataGridMajor.Name = "dataGridMajor";
            this.dataGridMajor.RowHeadersWidth = 51;
            this.dataGridMajor.RowTemplate.Height = 24;
            this.dataGridMajor.Size = new System.Drawing.Size(939, 160);
            this.dataGridMajor.TabIndex = 1;
            this.dataGridMajor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMajor_CellClick);
            // 
            // majorIDDataGridViewTextBoxColumn1
            // 
            this.majorIDDataGridViewTextBoxColumn1.DataPropertyName = "major_ID";
            this.majorIDDataGridViewTextBoxColumn1.HeaderText = "major_ID";
            this.majorIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.majorIDDataGridViewTextBoxColumn1.Name = "majorIDDataGridViewTextBoxColumn1";
            this.majorIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // majorNameDataGridViewTextBoxColumn
            // 
            this.majorNameDataGridViewTextBoxColumn.DataPropertyName = "major_Name";
            this.majorNameDataGridViewTextBoxColumn.HeaderText = "major_Name";
            this.majorNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.majorNameDataGridViewTextBoxColumn.Name = "majorNameDataGridViewTextBoxColumn";
            this.majorNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // majorChairDataGridViewTextBoxColumn
            // 
            this.majorChairDataGridViewTextBoxColumn.DataPropertyName = "major_Chair";
            this.majorChairDataGridViewTextBoxColumn.HeaderText = "major_Chair";
            this.majorChairDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.majorChairDataGridViewTextBoxColumn.Name = "majorChairDataGridViewTextBoxColumn";
            this.majorChairDataGridViewTextBoxColumn.Width = 125;
            // 
            // majorPhoneDataGridViewTextBoxColumn
            // 
            this.majorPhoneDataGridViewTextBoxColumn.DataPropertyName = "major_Phone";
            this.majorPhoneDataGridViewTextBoxColumn.HeaderText = "major_Phone";
            this.majorPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.majorPhoneDataGridViewTextBoxColumn.Name = "majorPhoneDataGridViewTextBoxColumn";
            this.majorPhoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this._C_ExampleDatabaseDataSet1;
            // 
            // _C_ExampleDatabaseDataSet1
            // 
            this._C_ExampleDatabaseDataSet1.DataSetName = "_C_ExampleDatabaseDataSet1";
            this._C_ExampleDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(963, 338);
            this.Controls.Add(this.dataGridMajor);
            this.Controls.Add(this.dataGridStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cExampleDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._C_ExampleDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMajor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._C_ExampleDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridStudent;
        private System.Windows.Forms.BindingSource cExampleDatabaseDataSetBindingSource;
        private _C_ExampleDatabaseDataSet _C_ExampleDatabaseDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private _C_ExampleDatabaseDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridMajor;
        private _C_ExampleDatabaseDataSet1 _C_ExampleDatabaseDataSet1;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private _C_ExampleDatabaseDataSet1TableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorChairDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorPhoneDataGridViewTextBoxColumn;
    }
}

