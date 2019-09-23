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

    public partial class FrmSucursal : Form
    {

        static string ConnectionString = "Trusted_Connection = True;" + "Database = FERRETERÍA;" + "Server = localhost;";
        static SqlConnection cnn = new SqlConnection(ConnectionString);
        DataTable SUCURSALESTable = new DataTable();
        DataSet ds = new DataSet("SucursalesSet");
        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM SUCURSALES", cnn);

        public FrmSucursal()
        {
            InitializeComponent();
        }

        private void BtnCargarSucursales_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Fill(ds, "SUCURSALES");
            SUCURSALESTable = ds.Tables["SUCURSALES"];
            GrvSucursales.DataSource = SUCURSALESTable;
        }

        

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            adapter.Update(ds, "SUCURSALES");
            MessageBox.Show("ACTUALIZADO");
        }
    }
}
