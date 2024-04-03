using GestionPedidos.BSS;
using GestionPedidos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionPedidos.VISTA.ClienteVista
{
    public partial class ClienteEliminarVista : Form
    {
        public ClienteEliminarVista()
        {
            InitializeComponent();
        }

        ClienteBss bss = new ClienteBss();
        Cliente cliente = new Cliente();
        private void button2_Click(object sender, EventArgs e)
        {
            cliente = bss.ObtenerIdClienteBss(Convert.ToInt32(btnID.Text));
            textBox1.Text = cliente.Nombre.ToString();
            textBox2.Text = cliente.Apellido.ToString();
            textBox3.Text = cliente.CorreoElectronico.ToString();
            textBox4.Text = cliente.Telefono.ToString();
            textBox5.Text = cliente.Direccion.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int IdClienteSeleccionado = Convert.ToInt32(btnID.Text);
            DialogResult result = MessageBox.Show("Esta seguro de eliminarlo?", "Eliminando",
                                                  MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarClienteBss(IdClienteSeleccionado);
                MessageBox.Show("Eliminado exitosamente");
            }
        }
    }
}
