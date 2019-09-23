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

namespace FERRETERÍA_CB
{
    public partial class FrmCliente : Form
    {

        static string ConnectionString = "Trusted_Connection = True;" + "Database = FERRETERÍA;" + "Server = localhost;";
        static SqlConnection cnn = new SqlConnection(ConnectionString);
        DataTable CLIENTESTable = new DataTable();
        DataSet ds = new DataSet("ClientesSet");
        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM CLIENTES", cnn);

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void BtnCargarClientes_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Fill(ds, "CLIENTES");
            CLIENTESTable = ds.Tables["CLIENTES"];
            GrvClientes.DataSource = CLIENTESTable;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            adapter.Update(ds, "CLIENTES");
            MessageBox.Show("ACTUALIZADO");
        }
    }
}
