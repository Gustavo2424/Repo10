using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FERRETERÍA_CB
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtnBanco_Click(object sender, EventArgs e)
        {
            FrmBanco ObjFrmBanco = new FrmBanco();
            ObjFrmBanco.Show();
        }

        private void BtnMétodoPago_Click(object sender, EventArgs e)
        {
            FrmMétodoPago ObjFrmMetodoPago = new FrmMétodoPago();
            ObjFrmMetodoPago.Show();
        }

        private void BtnSucursal_Click(object sender, EventArgs e)
        {
            FrmSucursal ObjFrmSucursal = new FrmSucursal();
            ObjFrmSucursal.Show();
        }

        private void BtnVendedor_Click(object sender, EventArgs e)
        {
            FrmVendedor ObjFrmVendedor = new FrmVendedor();
            ObjFrmVendedor.Show();
        }

        private void BtnVehículo_Click(object sender, EventArgs e)
        {
            FrmVehículo ObjFrmVehiculo = new FrmVehículo();
            ObjFrmVehiculo.Show();
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            FrmCliente ObjFrmCliente = new FrmCliente();
            ObjFrmCliente.Show();
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            FrmProducto ObjFrmProducto = new FrmProducto();
            ObjFrmProducto.Show();
        }

        private void BtnGarantía_Click(object sender, EventArgs e)
        {
            FrmGarantía ObjFrmGarantia = new FrmGarantía();
            ObjFrmGarantia.Show();
        }

        private void BtnFabricante_Click(object sender, EventArgs e)
        {
            FrmFabricante ObjFrmFabricante = new FrmFabricante();
            ObjFrmFabricante.Show();
        }

        private void BtnVenta_Click(object sender, EventArgs e)
        {
            FrmVenta ObjFrmVenta = new FrmVenta();
            ObjFrmVenta.Show();
        }

        private void BtnEntrega_Click(object sender, EventArgs e)
        {
            FrmEntrega ObjFrmEntrega = new FrmEntrega();
            ObjFrmEntrega.Show();
        }
    }
}
