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
    public partial class FrmVendedor : Form
    {

        static string ConnectionString = "Trusted_Connection = True;" + "Database = FERRETERÍA;" + "Server = localhost;";
        static SqlConnection cnn = new SqlConnection(ConnectionString);
        DataTable VENDEDORESTable = new DataTable();
        DataSet ds = new DataSet("VendedoresSet");
        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM VENDEDORES", cnn);

        public FrmVendedor()
        {
            InitializeComponent();
        }

        private void BtnCargarVendedores_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Fill(ds, "VENDEDORES");
            VENDEDORESTable = ds.Tables["VENDEDORES"];
            GrvVendedores.DataSource = VENDEDORESTable;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            adapter.Update(ds, "VENDEDORES");
            MessageBox.Show("ACTUALIZADO");
        }

        
    }
}
