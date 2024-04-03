using GestionPedidos.BSS;
using GestionPedidos.VISTA.PedidosVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPedidos.VISTA.ClienteVista
{
    public partial class ClienteListarVista : Form
    {
        public ClienteListarVista()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        private void ClienteListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarClientesBss();
        }

        private void button1_Click(object sender, EventArgs e) //btn insertar cliente
        {
            ClienteInsertarVista ventana1 = new ClienteInsertarVista();
            /*ventana1 .Show();*/
            if (ventana1.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarClientesBss();
            }
        }

        private void button2_Click(object sender, EventArgs e) //btn editar cliente
        {
            ClienteEditarVista ventana2 = new ClienteEditarVista();
            if (ventana2.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarClientesBss();
            }
        }

        private void button3_Click(object sender, EventArgs e) //btn eliminar cliente
        {
            ClienteEliminarVista ventana3 = new ClienteEliminarVista();
            if (ventana3.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarClientesBss();
            }
        }
    }
}
