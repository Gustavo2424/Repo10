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
    public partial class FrmSucursal : Form
    {
        public FrmSucursal()
        {
            InitializeComponent();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server = Localhost; Database = BDFERRETERÍA; Trusted_Connection = true;");
            SqlCommand cmd = new SqlCommand("spInsertarSucursal", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parIdSucursal = new SqlParameter("@IdSucursal", SqlDbType.Char);
            SqlParameter parIdBanco = new SqlParameter("@IdBanco", SqlDbType.Char);
            SqlParameter parDescripción = new SqlParameter("@Descripción", SqlDbType.VarChar);
            SqlParameter parDirección = new SqlParameter("@Dirección", SqlDbType.VarChar);
            SqlParameter parTeléfono = new SqlParameter("@Teléfono", SqlDbType.VarChar);
            parIdSucursal.Value = txtSucursal.Text;
            parIdBanco.Value = txtBanco.Text;
            parDescripción.Value = txtDescripción.Text;
            parDirección.Value = txtDirección.Text;
            parTeléfono.Value = txtTeléfono.Text;
            cmd.Parameters.Add(parIdSucursal);
            cmd.Parameters.Add(parIdBanco);
            cmd.Parameters.Add(parDescripción);
            cmd.Parameters.Add(parDirección);
            cmd.Parameters.Add(parTeléfono);
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
            SqlCommand cmd = new SqlCommand("spEditarSucursal", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parIdSucursal = new SqlParameter("@IdSucursal", SqlDbType.Char);
            SqlParameter parIdBanco = new SqlParameter("@IdBanco", SqlDbType.Char);
            SqlParameter parDescripción = new SqlParameter("@Descripción", SqlDbType.VarChar);
            SqlParameter parDirección = new SqlParameter("@Dirección", SqlDbType.VarChar);
            SqlParameter parTeléfono = new SqlParameter("@Teléfono", SqlDbType.VarChar);
            parIdSucursal.Value = txtSucursal.Text;
            parIdBanco.Value = txtBanco.Text;
            parDescripción.Value = txtDescripción.Text;
            parDirección.Value = txtDirección.Text;
            parTeléfono.Value = txtTeléfono.Text;
            cmd.Parameters.Add(parIdSucursal);
            cmd.Parameters.Add(parIdBanco);
            cmd.Parameters.Add(parDescripción);
            cmd.Parameters.Add(parDirección);
            cmd.Parameters.Add(parTeléfono);
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
            SqlCommand cmd = new SqlCommand("spEliminarSucursal", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parIdSucursal = new SqlParameter("@IdSucursal", SqlDbType.Char);
            parIdSucursal.Value = txtIDSucursal.Text;
            cmd.Parameters.Add(parIdSucursal);
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
            DataTable dtSucursal = new DataTable();
            SqlConnection cnn = new SqlConnection("Server = Localhost; Database = BDFERRETERÍA; Trusted_Connection = true;");
            SqlCommand cmd = new SqlCommand("SELECT * FROM SUCURSALES", cnn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(dtSucursal);
            GrvSucursal.DataSource = dtSucursal;
        }
    }
}
