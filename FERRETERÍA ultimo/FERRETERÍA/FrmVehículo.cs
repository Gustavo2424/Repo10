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
    public partial class FrmVehículo : Form
    {
        public FrmVehículo()
        {
            InitializeComponent();
        }

        private void FrmVehículo_Load(object sender, EventArgs e)
        {

        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server = Localhost; Database = BDFERRETERÍA; Trusted_Connection = true;");
            SqlCommand cmd = new SqlCommand("spInsertarVehiculo", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parIdvehículo = new SqlParameter("@IdVehículo", SqlDbType.Int);
            SqlParameter parplacas = new SqlParameter("@Placas", SqlDbType.VarChar);
            parIdvehículo.Value = txtidvehículo.Text;
            parplacas.Value = txtplacas.Text;
            cmd.Parameters.Add(parIdvehículo);
            cmd.Parameters.Add(parplacas);
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
            SqlCommand cmd = new SqlCommand("spEditarVehiculo", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parIdVehículo = new SqlParameter("@IdVehículo", SqlDbType.Int);
            SqlParameter parplacas = new SqlParameter("@Placas", SqlDbType.VarChar);
            parIdVehículo.Value = txtidvehículo.Text;
            parplacas.Value = txtplacas.Text;
            cmd.Parameters.Add(parIdVehículo);
            cmd.Parameters.Add(parplacas);
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
            SqlCommand cmd = new SqlCommand("spEliminarVehiculo", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parIdvehículo = new SqlParameter("@IdVehículo", SqlDbType.Int);
            parIdvehículo.Value = txtidvehículoaliminar.Text;
            cmd.Parameters.Add(parIdvehículo);
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
            DataTable dtVehiculo = new DataTable();
            SqlConnection cnn = new SqlConnection("Server = Localhost; Database = BDFERRETERÍA; Trusted_Connection = true;");
            SqlCommand cmd = new SqlCommand("SELECT * FROM VEHÍCULOS", cnn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(dtVehiculo);
            GrvVehiculos.DataSource = dtVehiculo;
        }
    }
}
