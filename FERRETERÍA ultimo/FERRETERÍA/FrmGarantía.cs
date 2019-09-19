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
    public partial class FrmGarantía : Form
    {
        public FrmGarantía()
        {
            InitializeComponent();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server = Localhost; Database = BDFERRETERÍA; Trusted_Connection = true;");
            SqlCommand cmd = new SqlCommand("spInsertarGarantia", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parIdGarantía = new SqlParameter("@IdGarantía", SqlDbType.Char);
            SqlParameter parSemanas = new SqlParameter("@Semanas", SqlDbType.Int);
            parIdGarantía.Value = txtidgarantía.Text;
            parSemanas.Value = txtsemanas.Text;
            cmd.Parameters.Add(parIdGarantía);
            cmd.Parameters.Add(parSemanas);
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

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server = Localhost; Database = BDFERRETERÍA; Trusted_Connection = true;");
            SqlCommand cmd = new SqlCommand("spEditarGarantÍa", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parIdGarantía = new SqlParameter("@IdGarantía", SqlDbType.Char);
            SqlParameter parSemanas = new SqlParameter("@Semanas", SqlDbType.Int);
            parIdGarantía.Value = txtidgarantía.Text;
            parSemanas.Value = txtsemanas.Text;
            cmd.Parameters.Add(parIdGarantía);
            cmd.Parameters.Add(parSemanas);
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server = Localhost; Database = BDFERRETERÍA; Trusted_Connection = true;");
            SqlCommand cmd = new SqlCommand("spEliminarGarantia", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parIdGarantía = new SqlParameter("@IdGarantía", SqlDbType.Char);
            parIdGarantía.Value = txtidgarantía.Text;
            cmd.Parameters.Add(parIdGarantía);
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

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            DataTable dtGarantias = new DataTable();
            SqlConnection cnn = new SqlConnection("Server = Localhost; Database = BDFERRETERÍA; Trusted_Connection = true;");
            SqlCommand cmd = new SqlCommand("SELECT * FROM GARANTÍAS", cnn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(dtGarantias);
            GrvGarantias.DataSource = dtGarantias;
        }
    }
}
