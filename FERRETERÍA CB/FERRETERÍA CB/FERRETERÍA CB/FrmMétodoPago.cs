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
    public partial class FrmMétodoPago : Form
    {

        static string ConnectionString = "Trusted_Connection = True;" + "Database = FERRETERÍA;" + "Server = localhost;";
        static SqlConnection cnn = new SqlConnection(ConnectionString);
        DataTable MÉTODOSPAGOTable = new DataTable();
        DataSet ds = new DataSet("MétodosPagoSet");
        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM MÉTODOSPAGO", cnn);

        public FrmMétodoPago()
        {
            InitializeComponent();
        }

        private void BtnCargarMétodosDePago_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Fill(ds, "MÉTODOSPAGO");
            MÉTODOSPAGOTable = ds.Tables["MÉTODOSPAGO"];
            GrvMétodosPago.DataSource = MÉTODOSPAGOTable;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            adapter.Update(ds, "MÉTODOSPAGO");
            MessageBox.Show("ACTUALIZADO");
        }
    }
}
