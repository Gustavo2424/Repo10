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
    public partial class FrmBanco : Form
    {

        static string ConnectionString = "Trusted_Connection = True;" + "Database = FERRETERÍA;" + "Server = localhost;";
        static SqlConnection cnn = new SqlConnection(ConnectionString);
        DataTable BANCOSTable = new DataTable();
        DataSet ds = new DataSet("BancosSet");
        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM BANCOS", cnn);

        public FrmBanco()
        {
            InitializeComponent();
        }

        private void BtnCargarBancos_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Fill(ds, "BANCOS");
            BANCOSTable = ds.Tables["BANCOS"];
            GrvBancos.DataSource = BANCOSTable;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            adapter.Update(ds, "BANCOS");
            MessageBox.Show("ACTUALIZADO");
        }
    }
}
