using GestionPedidos.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPedidos.VISTA.PedidosVista
{
    public partial class PedidosListarVista : Form
    {
        public PedidosListarVista()
        {
            InitializeComponent();
        }

        PedidosBss bss = new PedidosBss();
        private void PedidosListarVista_Load(object sender, EventArgs e)
        {

        }

        
    }
}
