using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FERRETERÍA
{
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }


        private void FrmVenta_Load(object sender, EventArgs e)
        {

            DAO ObjDaoCliente = new DAO();
            ObjDaoCliente.CadenaConexion = "Server = Localhost; Database = BDFERRETERÍA; Trusted_Connection = true";
            DataTable dtCliente = ObjDaoCliente.ClienteCombo();
            CBCliente.DataSource = dtCliente;
            CBCliente.DisplayMember = "Nombre";
            CBCliente.ValueMember = "IdCliente";

            DAO ObjDaoVendedor = new DAO();
            ObjDaoVendedor.CadenaConexion = "Server = Localhost; Database = BDFERRETERÍA; Trusted_Connection = true";
            DataTable dtVendedor = ObjDaoVendedor.VendedorCombo();
            CBVendedor.DataSource = dtVendedor;
            CBVendedor.DisplayMember = "Nombre";
            CBVendedor.ValueMember = "IdVendedor";

            DAO ObjDaoVehículo = new DAO();
            ObjDaoVehículo.CadenaConexion = "Server = Localhost; Database = BDFERRETERÍA; Trusted_Connection = true";
            DataTable dtVehículo = ObjDaoVehículo.VehículoCombo();
            CBVehículo.DataSource = dtVehículo;
            CBVehículo.DisplayMember = "IdVhículo";
            CBVehículo.ValueMember = "IdVehículo";

            DAO ObjDaoProducto = new DAO();
            ObjDaoProducto.CadenaConexion = "Server = Localhost; Database = BDFERRETERÍA; Trusted_Connection = true";
            DataTable dtProducto = ObjDaoProducto.ProductoCombo();
            CBProductosVenta.DataSource = dtProducto;
            CBProductosVenta.DisplayMember = "Nombre";
            CBProductosVenta.ValueMember = "IdProducto";
            
        }

        
        private void CBProductosVenta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DAO ObjDaoPrecio = new DAO();
            ObjDaoPrecio.CadenaConexion = "Server = Localhost; Database = BDFERRETERÍA; Trusted_Connection = true";
            DataTable dtProductoPrecio = ObjDaoPrecio.ProductoPrecio(Convert.ToInt32(CBProductosVenta.SelectedValue));
            GrvPrecioProducto.DataSource = dtProductoPrecio;
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            LBFechaVenta.Text = DateTime.Now.ToLongDateString();
            LBHoraVenta.Text = DateTime.Now.ToLongTimeString();
        }
    }
    
}
