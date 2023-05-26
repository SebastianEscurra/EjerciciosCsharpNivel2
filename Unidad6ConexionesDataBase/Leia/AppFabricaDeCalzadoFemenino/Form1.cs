﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFabricaDeCalzadoFemenino
{
    public partial class Form1 : Form
    {
        private List<Pedido> pedidos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PedidoDato pedidoDato = new PedidoDato();
            pedidos = new List<Pedido>();
            pedidos = pedidoDato.listar();
            dgvListaPedidos.DataSource = pedidos;
            dgvListaPedidos.Columns[0].Visible = false;
            dgvListaPedidos.Columns[3].Visible = false;
            dgvListaPedidos.Columns["presupuesto"].Visible = false;





        }

        private void dgvListaPedidos_SelectionChanged(object sender, EventArgs e)
        {
            Pedido pedidoActual = (Pedido)dgvListaPedidos.CurrentRow.DataBoundItem;
            mostrarImagen(pedidoActual.tipoDeCalzado.UrlImagen);
        }

        public void mostrarImagen(string url)
        {
            try
            {
            pbxImagenCalzados.Load(url);
            }
            catch (Exception)
            {
                pbxImagenCalzados.Load("https://cdn-icons-png.flaticon.com/512/85/85488.png");
            }
        }
    }
}