using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionPedidos.DAL;

namespace GestionPedidos.BSS
{
    public class PedidosBss
    {
        PedidosDal dal = new PedidosDal();
        public DataTable ListarPedidosBss()
        {
            return dal.ListarPedidosDal();
        }
        public DataTable ListarPedidosClienteBss (int id)
        {
            return dal.ListarPedidosClienteDal(id);
        }
        public DataTable CalcularPedidosClienteBss (int id)
        {
            return dal.CalcularTotalClienteDal(id);
        }
    }
}
