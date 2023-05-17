using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaIntegradora
{
    public partial class frmNuevo : Form
    {
        public frmNuevo()
        {
            InitializeComponent();
            for (int x = 0; x < 12; x++)
            {
                vivaStyle.meses.Add(new Meses());
                vivaStyle.meses[x].venta = false;
            }
            vivaStyle.meses[0].meses = "enero";
            vivaStyle.meses[1].meses = "febrero";
            vivaStyle.meses[2].meses = "marzo";
            vivaStyle.meses[3].meses = "abril";
            vivaStyle.meses[4].meses = "mayo";
            vivaStyle.meses[5].meses = "junio";
            vivaStyle.meses[6].meses = "julio";
            vivaStyle.meses[7].meses = "agosto";
            vivaStyle.meses[8].meses = "septiembre";
            vivaStyle.meses[9].meses = "octubre";
            vivaStyle.meses[10].meses = "noviembre";
            vivaStyle.meses[11].meses = "diciembre";

        }
        //
        //
        //
        Empresa vivaStyle= new Empresa();
        public int contadorArticulos = 0;
        public int contadorClientes = 0;
        //
        //
        //
        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            
            
            vivaStyle.listaDeArticulosGeneral.Add(new Articulo());
            vivaStyle.listaDeArticulosGeneral[contadorArticulos].codigoDeArticulo = int.Parse(txbCodigoDeArticuloArticulo.Text);
            vivaStyle.listaDeArticulosGeneral[contadorArticulos].precioUnitario = float.Parse(txbPrecioUnitario.Text);
            cbCodigoDeArticulo.Items.Add(txbCodigoDeArticuloArticulo.Text);
            contadorArticulos++;
            lblDatosCargados.Text = "articulos cargados: " + contadorArticulos .ToString();


        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            vivaStyle.listaDeClientesGeneral.Add(new Cliente());
            vivaStyle.listaDeClientesGeneral[contadorClientes].numeroDeCliente = int.Parse(txbNumeroDeCliente.Text);
            vivaStyle.listaDeClientesGeneral[contadorClientes].codigoDeArtuculo = int.Parse(cbCodigoDeArticulo.Text);
            vivaStyle.listaDeClientesGeneral[contadorClientes].mes = txbMes.Text;
            vivaStyle.listaDeClientesGeneral[contadorClientes].dia = int.Parse(txbDia.Text);
            vivaStyle.listaDeClientesGeneral[contadorClientes].cantidadVendida=int.Parse(txbCantidadVendida.Text);
            contadorClientes++;
            lblVentasCargadas.Text = "Cantidad de ventas cargadas: " + contadorClientes.ToString();

        }

        private void btnMostrarCantidadVendida_Click(object sender, EventArgs e)
        {
            foreach (var venta in vivaStyle.listaDeClientesGeneral)
            {
                foreach (var articulo in vivaStyle.listaDeArticulosGeneral)
                {
                    if (venta.codigoDeArtuculo == articulo.codigoDeArticulo)
                        articulo.totalVendido += venta.cantidadVendida;
                }
            }
            //
            //ordenamos la lista de mayor a menor venta total
            //
            vivaStyle.listaDeArticulosGeneral.Sort((p1,p2)=>p1.totalVendido.CompareTo(p2.totalVendido));
            vivaStyle.listaDeArticulosGeneral.Reverse();
            //
            //Usamos dos list box una para codigo de articulo y otra para mostrar el total vendido del articulo
            //
            //
            lbxNumeroDeArticulo.Items.Add("codigo de articulo: ");
            lbxNumeroDeArticulo.Items.Add("");
            lbxCantidadTotal.Items.Add("Cantidad total: ");
            lbxCantidadTotal.Items.Add("");

            foreach (var item in vivaStyle.listaDeArticulosGeneral)
            {
                lbxNumeroDeArticulo.Items.Add(item.codigoDeArticulo.ToString());
                lbxCantidadTotal.Items.Add(item.totalVendido.ToString());
            }

            
        }

        private void btnMesSinVenta_Click(object sender, EventArgs e)
        {
            //
            //comparamos la lista de clientes que ya estan cargadas para colocar true si hubo venta en el mes.
            //

            foreach (var itemCliente in vivaStyle.listaDeClientesGeneral)
            {
                foreach (var itemEmpresa in vivaStyle.meses)
                {
                    if(itemCliente.mes==itemEmpresa.meses)
                    {
                        itemEmpresa.venta = true;
                    }
                }

            }

            //
            //mostramos los meses en los que hubo venta
            //
            lbxMeseSinVenta.Items.Add("Meses en los que no hubo ventas:");
            lbxMeseSinVenta.Items.Add("");

            foreach (var item in vivaStyle.meses)
            {
                if (item.venta == false)
                    lbxMeseSinVenta.Items.Add(item.meses);
            }
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            int total=0;
            foreach (var item in vivaStyle.listaDeArticulosGeneral)
            {
                total+=item.totalVendido;
            }
            int promedio = total / vivaStyle.listaDeArticulosGeneral.Count;

            lbxPromedio.Items.Add("promedio de venta: " + promedio);
            lbxPromedio.Items.Add("");

            foreach (var item in vivaStyle.listaDeArticulosGeneral)
            {
                if (item.totalVendido>promedio)
                {
                    lbxPromedio.Items.Add(item.codigoDeArticulo.ToString());
                }
            }
        }

        private void txbDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
