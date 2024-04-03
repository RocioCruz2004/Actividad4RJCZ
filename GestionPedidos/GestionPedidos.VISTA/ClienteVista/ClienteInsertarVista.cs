﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionPedidos.BSS;
using GestionPedidos.Modelos;

namespace GestionPedidos.VISTA.ClienteVista
{
    public partial class ClienteInsertarVista : Form
    {
        public ClienteInsertarVista()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = textBox1.Text;
            cliente.Apellido = textBox2.Text;
            cliente.CorreoElectronico = textBox3.Text;
            cliente.Telefono = textBox4.Text;
            cliente.Direccion = textBox5.Text;

            bss.InsertarClienteBss(cliente);
            MessageBox.Show("Se agregó correctamente");
        }
    }
}
