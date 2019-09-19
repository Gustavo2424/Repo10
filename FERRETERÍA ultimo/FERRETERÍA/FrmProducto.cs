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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server = Localhost; Database = BDFERRETERÍA; Trusted_Connection = true;");
            SqlCommand cmd = new SqlCommand("spInsertarProducto", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parIdProducto = new SqlParameter("@IdProducto", SqlDbType.Int);
            SqlParameter parNombre = new SqlParameter("@Nombre", SqlDbType.VarChar);
            SqlParameter parPrecio = new SqlParameter("@Precio", SqlDbType.Money);
            SqlParameter parIdFabricante = new SqlParameter("@IdFabricante", SqlDbType.Char);
            SqlParameter parIdGarantía = new SqlParameter("@IdGarantía", SqlDbType.Char);
            parIdProducto.Value = Convert.ToInt32(txtProducto.Text);
            parNombre.Value = txtNombre.Text;
            parPrecio.Value = txtPrecio.Text;
            parIdFabricante.Value = txtIDFabricante.Text;
            parIdGarantía.Value = txtIDGarantía.Text;
            cmd.Parameters.Add(parIdProducto);
            cmd.Parameters.Add(parNombre);
            cmd.Parameters.Add(parPrecio);
            cmd.Parameters.Add(parIdFabricante);
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
            MessageBox.Show("INSERTADO");
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server = Localhost; Database = BDFERRETERÍA; Trusted_Connection = true;");
            SqlCommand cmd = new SqlCommand("spEditarProducto", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parIdProducto = new SqlParameter("@IdProducto", SqlDbType.Int);
            SqlParameter parNombre = new SqlParameter("@Nombre", SqlDbType.VarChar);
            SqlParameter parPrecio = new SqlParameter("@Precio", SqlDbType.Money);
            SqlParameter parIdFabricante = new SqlParameter("@IdFabricante", SqlDbType.Char);
            SqlParameter parIdGarantía = new SqlParameter("@IdGarantía", SqlDbType.Char);
            parIdProducto.Value = Convert.ToInt32(txtProducto.Text);
            parNombre.Value = txtNombre.Text;
            parPrecio.Value = txtPrecio.Text;
            parIdFabricante.Value = txtIDFabricante.Text;
            parIdGarantía.Value = txtIDGarantía.Text;
            cmd.Parameters.Add(parIdProducto);
            cmd.Parameters.Add(parNombre);
            cmd.Parameters.Add(parPrecio);
            cmd.Parameters.Add(parIdFabricante);
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
            MessageBox.Show("EDITADO");
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server = Localhost; Database = BDFERRETERÍA; Trusted_Connection = true;");
            SqlCommand cmd = new SqlCommand("spEliminarProducto", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parIdProducto = new SqlParameter("@IdProducto", SqlDbType.Int);
            parIdProducto.Value = Convert.ToInt32(txtIDProducto.Text);
            cmd.Parameters.Add(parIdProducto);
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
            DataTable dtProducto = new DataTable();
            SqlConnection cnn = new SqlConnection("Server = Localhost; Database = BDFERRETERÍA; Trusted_Connection = true;");
            SqlCommand cmd = new SqlCommand("SELECT * FROM PRODUCTOS", cnn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(dtProducto);
            GrvProducto.DataSource = dtProducto;
        }
    }
}
