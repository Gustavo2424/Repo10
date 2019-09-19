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
    public partial class FrmBanco : Form
    {
        public FrmBanco()
        {
            InitializeComponent();
        }

        private void BtnIsertar_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server = Localhost; Database = BDFERRETERÍA; Trusted_Connection = true;");
            SqlCommand cmd = new SqlCommand("spInsertarBanco", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parIdBanco = new SqlParameter("@IdBanco", SqlDbType.Char);
            SqlParameter parDescripción = new SqlParameter("@Descripción", SqlDbType.VarChar);
            parIdBanco.Value = txtBanco.Text;
            parDescripción.Value = txtDescripción.Text;
            cmd.Parameters.Add(parIdBanco);
            cmd.Parameters.Add(parDescripción);
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
            ConsultarBanco();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

            SqlConnection cnn = new SqlConnection("Server = Localhost; Database = BDFERRETERÍA; Trusted_Connection = true;");
            SqlCommand cmd = new SqlCommand("spEditarBanco", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parIdBanco = new SqlParameter("@IdBanco", SqlDbType.Char);
            SqlParameter parDescripción = new SqlParameter("@Descripción", SqlDbType.VarChar);
            parIdBanco.Value = txtBanco.Text;
            parDescripción.Value = txtDescripción.Text;
            cmd.Parameters.Add(parIdBanco);
            cmd.Parameters.Add(parDescripción);
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
            ConsultarBanco();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server = Localhost; Database = BDFERRETERÍA; Trusted_Connection = true;");
            SqlCommand cmd = new SqlCommand("spEliminarBanco", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parIdBanco = new SqlParameter("@IdBanco", SqlDbType.Char);
            parIdBanco.Value = txtIDBanco.Text;
            cmd.Parameters.Add(parIdBanco);
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
            ConsultarBanco();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ConsultarBanco(); 
        }

        private void ConsultarBanco()
        {
            DataTable dtBanco = new DataTable();
            SqlConnection cnn = new SqlConnection("Server = Localhost; Database = BDFERRETERÍA; Trusted_Connection = true;");
            SqlCommand cmd = new SqlCommand("SELECT * FROM BANCOS", cnn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(dtBanco);
            GrvBanco.DataSource = dtBanco;

        }
    }
}
