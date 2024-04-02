using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPedidos.DAL
{
    public class PedidosDal
    {
        public DataTable ListarPedidosDal ()
        {
            string consulta = "select *\r\nfrom PEDIDOS";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public DataTable ListarPedidosClienteDal(int id)
        {
            string consulta = "select IdPedido, C.Nombre, FECHA, Total, Estado\r\nfrom PEDIDOS P\r\n\tINNER JOIN CLIENTE C ON C.IDCLIENTE = P.IDCLIENTE\r\nWHERE P.IdCliente = " + id;
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public DataTable CalcularTotalClienteDal(int id)
        {
            string consulta = "select C.Nombre, SUM(TOTAL) MONTOPEDIDOS\r\nfrom PEDIDOS P\r\n\tINNER JOIN CLIENTE C ON C.IDCLIENTE = P.IDCLIENTE\r\nWHERE P.IdCliente =" + id + "\r\nGROUP BY C.Nombre";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
    }
}
