using GestionPedidos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPedidos.DAL
{
    public class ClientesDal
    {
        public DataTable ListarClientesDal()
        {
            string consulta = "SELECT * FROM CLIENTE";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public Cliente ObtenerIdClienteDal (int id)
        {
            string consulta = "SELECT * FROM CLIENTE WHERE IDCLIENTE = " + id;
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            Cliente cliente = new Cliente();
            if (lista.Rows.Count > 0)
            {
                cliente.IdCliente = Convert.ToInt32(lista.Rows[0]["idcliente"]);
                cliente.Nombre = lista.Rows[0]["nombre"].ToString();
                cliente.Apellido = lista.Rows[0]["apellido"].ToString();
                cliente.CorreoElectronico = lista.Rows[0]["CorreoElectronico"].ToString();
                cliente.Telefono = lista.Rows[0]["telefono"].ToString();
                cliente.Direccion = lista.Rows[0]["direccion"].ToString();
            }
            return cliente;
        }
    }
}
