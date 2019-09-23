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
    public partial class FrmFabricante : Form
    {

        static string ConnectionString = "Trusted_Connection = True;" + "Database = FERRETERÍA;" + "Server = localhost;";
        static SqlConnection cnn = new SqlConnection(ConnectionString);
        DataTable FABRICANTESTable = new DataTable();
        DataSet ds = new DataSet("FabricantesSet");
        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM FABRICANTES", cnn);

        public FrmFabricante()
        {
            InitializeComponent();
        }

        private void BtnCargarFabricantes_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Fill(ds, "FABRICANTES");
            FABRICANTESTable = ds.Tables["FABRICANTES"];
            GrvFabricantes.DataSource = FABRICANTESTable;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            adapter.Update(ds, "FABRICANTES");
            MessageBox.Show("ACTUALIZADO");
        }
    }
}
