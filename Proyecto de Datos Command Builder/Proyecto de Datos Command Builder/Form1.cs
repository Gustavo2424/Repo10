using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_de_Datos_Command_Builder
{
    public partial class Form1 : Form


    {
        static string ConnectionString = "Trusted_Connection = True;" + "Database = Northwind;" + "Server = localhost;";
        static SqlConnection cnn = new SqlConnection(ConnectionString);
        DataTable EmployeeTable = new DataTable();
        DataSet ds = new DataSet("EmployeeSet");
        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Employees ORDER by EmployeeID", cnn);

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEjemplo_Click(object sender, EventArgs e)
        {  
            cnn.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Fill(ds, "Employees");
            EmployeeTable = ds.Tables["Employees"];
            GrvEmpleado.DataSource = EmployeeTable;  
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            adapter.Update(ds, "Employees");
            MessageBox.Show("ACTUALIZADO");
        }
    }
}
