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
    public partial class FrmProducto : Form
    {

        static string ConnectionString = "Trusted_Connection = True;" + "Database = FERRETERÍA;" + "Server = localhost;";
        static SqlConnection cnn = new SqlConnection(ConnectionString);
        DataTable PRODUCTOSTable = new DataTable();
        DataSet ds = new DataSet("ProductosSet");
        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM PRODUCTOS", cnn);

        public FrmProducto()
        {
            InitializeComponent();
        }

        private void BtnCargarProductos_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Fill(ds, "PRODUCTOS");
            PRODUCTOSTable = ds.Tables["PRODUCTOS"];
            GrvProductos.DataSource = PRODUCTOSTable;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            adapter.Update(ds, "PRODUCTOS");
            MessageBox.Show("ACTUALIZADO");
        }

        
    }
}
