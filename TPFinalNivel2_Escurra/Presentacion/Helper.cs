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
        public static void cargarGrid(DataGridView grid,List<Articulo> listaArticulos)
        {
            
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
