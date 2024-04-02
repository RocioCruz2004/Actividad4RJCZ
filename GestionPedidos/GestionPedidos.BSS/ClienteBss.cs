using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionPedidos.DAL;
using GestionPedidos.Modelos;

namespace GestionPedidos.BSS
{
    public class ClienteBss
    {
        ClientesDal dal = new ClientesDal();
        public DataTable ListarClientesBss()
        {
            return dal.ListarClientesDal();
        }
        public Cliente ObtenerIdClienteBss (int id)
        {
            return dal.ObtenerIdClienteDal(id);
        }
    }
}
