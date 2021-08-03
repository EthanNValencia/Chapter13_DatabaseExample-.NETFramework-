using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Data Source=LAPTOP-FMDH9RA6\SQLEXPRESS;Initial Catalog=C#ExampleDatabase;Integrated Security=True

namespace Chapter13_DatabaseExample_.NETFramework_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_C_ExampleDatabaseDataSet1.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this._C_ExampleDatabaseDataSet1.Department);
            // TODO: This line of code loads data into the '_C_ExampleDatabaseDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this._C_ExampleDatabaseDataSet.Student);
        }

        private void dataGridStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.studentTableAdapter.Update(this._C_ExampleDatabaseDataSet.Student);
        }

        private void dataGridMajor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Validate();
            this.departmentBindingSource.EndEdit();
            this.departmentTableAdapter.Update(this._C_ExampleDatabaseDataSet1.Department);
        }
    }
}
