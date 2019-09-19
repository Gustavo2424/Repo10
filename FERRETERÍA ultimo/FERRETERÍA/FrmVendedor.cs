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
    public partial class FrmVendedor : Form
    {
        public FrmVendedor()
        {
            InitializeComponent();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server = Localhost; Database = BDFERRETERÍA; Trusted_Connection = true;");
            SqlCommand cmd = new SqlCommand("spInsertarVendedor", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parIdVendedor = new SqlParameter("@IdVendedor", SqlDbType.Int);
            SqlParameter parNombre = new SqlParameter("@Nombre", SqlDbType.VarChar);
            parIdVendedor.Value = Convert.ToInt32(txtVendedor.Text);
            parNombre.Value = txtNombre.Text;
            cmd.Parameters.Add(parIdVendedor);
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

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server = Localhost; Database = BDFERRETERÍA; Trusted_Connection = true;");
            SqlCommand cmd = new SqlCommand("spEditarVendedor", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parIdVendedor = new SqlParameter("@IdVendedor", SqlDbType.Int);
            SqlParameter parNombre = new SqlParameter("@Nombre", SqlDbType.VarChar);
            parIdVendedor.Value = Convert.ToInt32(txtVendedor.Text);
            parNombre.Value = txtNombre.Text;
            cmd.Parameters.Add(parIdVendedor);
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server = Localhost; Database = BDFERRETERÍA; Trusted_Connection = true;");
            SqlCommand cmd = new SqlCommand("spEliminarVendedor", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parIdVendedor = new SqlParameter("@IdVendedor", SqlDbType.Int);
            parIdVendedor.Value = Convert.ToInt32(txtIDVendedor.Text);
            cmd.Parameters.Add(parIdVendedor);
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
            DataTable dtVendedor = new DataTable();
            SqlConnection cnn = new SqlConnection("Server = Localhost; Database = BDFERRETERÍA; Trusted_Connection = true;");
            SqlCommand cmd = new SqlCommand("SELECT * FROM VENDEDORES", cnn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(dtVendedor);
            GrvVendedor.DataSource = dtVendedor;
        }
    }
}
