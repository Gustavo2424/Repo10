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

namespace FERRETERÍA
{
    public partial class FrmFabricante : Form
    {
        public FrmFabricante()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server = Localhost; Database = BDFERRETERÍA; Trusted_Connection = true;");
            SqlCommand cmd = new SqlCommand("spInsertarFabricante", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parIdFabricante = new SqlParameter("@IdFabricante", SqlDbType.Char);
            SqlParameter parNombre = new SqlParameter("@Nombre", SqlDbType.VarChar);
            parIdFabricante.Value = txtfabricante.Text;
            parNombre.Value = txtnombre.Text;
            cmd.Parameters.Add(parIdFabricante);
            cmd.Parameters.Add(parNombre);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            cmd.ExecuteNonQuery();
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
            MessageBox.Show("INSERTADO");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server = Localhost; Database = BDFERRETERÍA; Trusted_Connection = true;");
            SqlCommand cmd = new SqlCommand("spEditarFabricante", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parIdFabricante = new SqlParameter("@IdFabricante", SqlDbType.Char);
            SqlParameter parNombre = new SqlParameter("@Nombre", SqlDbType.VarChar);
            parIdFabricante.Value = txtfabricante.Text;
            parNombre.Value = txtnombre.Text;
            cmd.Parameters.Add(parIdFabricante);
            cmd.Parameters.Add(parNombre);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            cmd.ExecuteNonQuery();
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
            MessageBox.Show("EDITADO");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server = Localhost; Database = BDFERRETERÍA; Trusted_Connection = true;");
            SqlCommand cmd = new SqlCommand("spEliminarFabricante", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parIdFabricante = new SqlParameter("@IdFabricante", SqlDbType.Char);
            parIdFabricante.Value = txtideliminar.Text;
            cmd.Parameters.Add(parIdFabricante);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            cmd.ExecuteNonQuery();
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
            MessageBox.Show("ELIMINADO");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            DataTable dtFabricante = new DataTable();
            SqlConnection cnn = new SqlConnection("Server = Localhost; Database = BDFERRETERÍA; Trusted_Connection = true;");
            SqlCommand cmd = new SqlCommand("SELECT * FROM FABRICANTES", cnn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(dtFabricante);
            GRVFabricante.DataSource = dtFabricante;
        }
    }
}
