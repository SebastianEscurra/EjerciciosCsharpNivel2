using Domino2;
using Negocio2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Presentacion
{
    internal static class Helper
    {
        public static void cargarGrid(DataGridView grid,ref List<Articulo> listaArticulos)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.listar();
            grid.DataSource = listaArticulos;
            grid.Columns["Id"].Visible = false;
            grid.Columns["UrlImagen"].Visible = false;
            grid.Columns["Categoria"].Visible = false;
        }
        public static void cargarGrid(DataGridView grid, ref List<Articulo> listaArticulos,string campo,string criterio,string filtro)// Carga con el filtro
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.filtrar(campo,criterio,filtro);
            grid.DataSource = listaArticulos;
            grid.Columns["Id"].Visible = false;
            grid.Columns["UrlImagen"].Visible = false;
            grid.Columns["Categoria"].Visible = false;
        }
        public static void cargarImagen(PictureBox pictureBox,string direccion)
        {
            try
            {
                pictureBox.Load(direccion);
            }
            catch (Exception)
            {
                pictureBox.Load("https://www.puroverso.com.uy/images/virtuemart/product/9788430531325.jpg");
            }
        }
    }
}
