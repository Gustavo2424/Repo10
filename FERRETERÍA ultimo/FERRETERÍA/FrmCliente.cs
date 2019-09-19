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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server = Localhost; Database = BDFERRETERÍA; Trusted_Connection = true;");
            SqlCommand cmd = new SqlCommand("spInsertarCliente", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parIdCliente = new SqlParameter("@IdCliente", SqlDbType.Int);
            SqlParameter parNombre = new SqlParameter("@Nombre", SqlDbType.VarChar);
            SqlParameter parDireccion = new SqlParameter("@Direccion", SqlDbType.VarChar);
            SqlParameter partelefono = new SqlParameter("@Telefono", SqlDbType.VarChar);
            SqlParameter paremail = new SqlParameter("@Email", SqlDbType.VarChar);
            SqlParameter parRfc = new SqlParameter("@Rfc", SqlDbType.VarChar);
            parIdCliente.Value = Convert.ToInt32(txtidcliente.Text);
            parNombre.Value = txtnombre.Text;
            parDireccion.Value = txtdireccion.Text;
            partelefono.Value = txttelefono.Text;
            paremail.Value = txtemail.Text;
            parRfc.Value = txtrfc.Text;
            cmd.Parameters.Add(parIdCliente);
            cmd.Parameters.Add(parNombre);
            cmd.Parameters.Add(parDireccion);
            cmd.Parameters.Add(partelefono);
            cmd.Parameters.Add(paremail);
            cmd.Parameters.Add(parRfc);
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
            SqlCommand cmd = new SqlCommand("spEditarCliente", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parIdCliente = new SqlParameter("@IdCliente", SqlDbType.Int);
            SqlParameter parNombre = new SqlParameter("@Nombre", SqlDbType.VarChar);
            SqlParameter parDirección = new SqlParameter("@Dirección", SqlDbType.VarChar);
            SqlParameter partelefono = new SqlParameter("@Telefono", SqlDbType.VarChar);
            SqlParameter paremail = new SqlParameter("@Email", SqlDbType.VarChar);
            SqlParameter parRfc = new SqlParameter("@Rfc", SqlDbType.VarChar);
            parIdCliente.Value = Convert.ToInt32(txtidcliente.Text);
            parNombre.Value =txtnombre.Text;
            parDirección.Value = txtdireccion.Text;
            partelefono.Value = txttelefono.Text;
            paremail.Value =txtemail.Text;
            parRfc.Value = txtrfc.Text;
            cmd.Parameters.Add(parIdCliente);
            cmd.Parameters.Add(parNombre);
            cmd.Parameters.Add(parDirección);
            cmd.Parameters.Add(partelefono);
            cmd.Parameters.Add(paremail);
            cmd.Parameters.Add(parRfc);
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
            SqlCommand cmd = new SqlCommand("spEliminarCliente", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parIdCliente = new SqlParameter("@IdCliente", SqlDbType.Int);
            parIdCliente.Value = Convert.ToInt32(txtidcliente.Text);
            cmd.Parameters.Add(parIdCliente);
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
            DataTable dtClientes = new DataTable();
            SqlConnection cnn = new SqlConnection("Server = Localhost; Database = BDFERRETERÍA; Trusted_Connection = true;");
            SqlCommand cmd = new SqlCommand("SELECT * FROM CLIENTES", cnn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(dtClientes);
            GRVClientes.DataSource = dtClientes;
        }
    }
}
