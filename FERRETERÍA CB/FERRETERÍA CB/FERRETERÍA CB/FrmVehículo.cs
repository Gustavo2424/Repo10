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
    public partial class FrmVehículo : Form

    {
        static string ConnectionString = "Trusted_Connection = True;" + "Database = FERRETERÍA;" + "Server = localhost;";
        static SqlConnection cnn = new SqlConnection(ConnectionString);
        DataTable VEHÍCULOSTable = new DataTable();
        DataSet ds = new DataSet("VehículosSet");
        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM VEHÍCULOS", cnn);


        public FrmVehículo()
        {
            InitializeComponent();
        }

        private void BtnCargarVehículos_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Fill(ds, "VEHÍCULOS");
            VEHÍCULOSTable = ds.Tables["VEHÍCULOS"];
            GrvVehículos.DataSource = VEHÍCULOSTable;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            adapter.Update(ds, "VEHÍCULOS");
            MessageBox.Show("ACTUALIZADO");
        }
    }
}
