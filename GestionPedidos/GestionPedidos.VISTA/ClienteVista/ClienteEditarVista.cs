using GestionPedidos.BSS;
using GestionPedidos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionPedidos.VISTA.ClienteVista
{
    public partial class ClienteEditarVista : Form
    {
        Cliente cliente = new Cliente();
        ClienteBss bss = new ClienteBss();
        public ClienteEditarVista()
        {
            InitializeComponent();
        }

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
            cliente.Nombre = textBox1.Text;
            cliente.Apellido = textBox2.Text;
            cliente.CorreoElectronico = textBox3.Text;
            cliente.Telefono = textBox4.Text;
            cliente.Direccion = textBox5.Text;

            bss.EditarClienteBss(cliente);
            MessageBox.Show("Actualizado exitosamente");
        }

        private void btnID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
