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
    public partial class FrmMétodoPago : Form
    {
        public FrmMétodoPago()
        {
            InitializeComponent();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("server=localhost;database=BDFERRETERÍA;trusted_connection=true;");
            SqlCommand cmd = new SqlCommand("spInsertarMetodoPago", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parid = new SqlParameter("@IdMétodoPago", SqlDbType.Int);
            SqlParameter parDescripcion = new SqlParameter("@Descripción", SqlDbType.VarChar);
            parid.Value = txtId.Text;
            parDescripcion.Value = txtDescripcion.Text;
            cmd.Parameters.Add(parid);
            cmd.Parameters.Add(parDescripcion);

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
            SqlConnection cnn = new SqlConnection("server=localhost;database=BDFERRETERÍA;trusted_connection=true;");
            SqlCommand cmd = new SqlCommand("speditarMetodosPago", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parid = new SqlParameter("@IdMétodoPago", SqlDbType.Int);
            SqlParameter pardescripcion = new SqlParameter("@Descripción", SqlDbType.VarChar);
            parid.Value = Convert.ToInt32(txtId.Text);
            pardescripcion.Value = txtDescripcion.Text;
            cmd.Parameters.Add(parid);
            cmd.Parameters.Add(pardescripcion);

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

        private void Txtideliminar_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("server=localhost;database=BDFERRETERÍA;trusted_connection=true;");
            SqlCommand cmd = new SqlCommand("speliminarmetodopago", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parid = new SqlParameter("@idMétodopago", SqlDbType.Int);
            parid.Value = Convert.ToInt32(txtideliminar.Text);
            cmd.Parameters.Add(parid);

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
            DataTable dtMetodoPago = new DataTable();
            SqlConnection cnn = new SqlConnection("server=localhost;database=BDFERRETERÍA;trusted_connection=true");
            SqlCommand cmd = new SqlCommand("select * from MÉTODOSPAGO", cnn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(dtMetodoPago);
            GrvMetodoPago.DataSource = dtMetodoPago;
        }
    }
}
