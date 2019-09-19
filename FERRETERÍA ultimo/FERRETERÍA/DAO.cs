using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FERRETERÍA
{
    class DAO
    {
        public string CadenaConexion { get; set; }
        

        public DataTable ClienteCombo()
        {
            DataTable dtClientes = new DataTable();
            SqlConnection cnn = new SqlConnection(CadenaConexion);
            SqlCommand cmd = new SqlCommand("Select IdCliente, Nombre from CLIENTES", cnn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(dtClientes);
            return dtClientes;
        }

        public DataTable VendedorCombo()
        {
            DataTable dtVendedores = new DataTable();
            SqlConnection cnn = new SqlConnection(CadenaConexion);
            SqlCommand cmd = new SqlCommand("Select IdVendedor, Nombre from VENDEDORES", cnn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(dtVendedores);
            return dtVendedores;
        }

        public DataTable VehículoCombo()
        {
            DataTable dtVehículos = new DataTable();
            SqlConnection cnn = new SqlConnection(CadenaConexion);
            SqlCommand cmd = new SqlCommand("Select IdVehículo from VEHÍCULOS", cnn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(dtVehículos);
            return dtVehículos;
        }

        public DataTable ProductoCombo()
        {
            DataTable dtProductos = new DataTable();
            SqlConnection cnn = new SqlConnection(CadenaConexion);
            SqlCommand cmd = new SqlCommand("Select IdProducto, Nombre, Precio from PRODUCTOS", cnn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(dtProductos);
            return dtProductos;
        }

        public DataTable ProductoPrecio (int IdProducto)
        {
            DataTable dtProductoPrecio = new DataTable();
            SqlConnection cnn = new SqlConnection(CadenaConexion);
            SqlCommand cmd = new SqlCommand("Select Precio from PRODUCTOS where IdProducto = " + Convert.ToString(IdProducto), cnn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(dtProductoPrecio);
            return dtProductoPrecio;
        }

       
    }
}
