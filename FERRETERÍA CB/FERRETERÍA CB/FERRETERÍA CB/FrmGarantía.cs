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
    public partial class FrmGarantía : Form
    {

        static string ConnectionString = "Trusted_Connection = True;" + "Database = FERRETERÍA;" + "Server = localhost;";
        static SqlConnection cnn = new SqlConnection(ConnectionString);
        DataTable GARANTÍASTable = new DataTable();
        DataSet ds = new DataSet("GarantíasSet");
        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM GARANTÍAS", cnn);

        public FrmGarantía()
        {
            InitializeComponent();
        }

        private void BtnCargarGarantías_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Fill(ds, "GARANTÍAS");
            GARANTÍASTable = ds.Tables["GARANTÍAS"];
            GrvGarantías.DataSource = GARANTÍASTable;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            adapter.Update(ds, "GARANTÍAS");
            MessageBox.Show("ACTUALIZADO");
        }
    }
}
