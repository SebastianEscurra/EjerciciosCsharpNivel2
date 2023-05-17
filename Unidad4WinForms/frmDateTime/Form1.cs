using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmDateTime
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string mes;
        private void btnFecha_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dtpFecha.Value.ToString("dd/MMMM/yyyy"));
            
        }

        private void btnRangoFecha_Click(object sender, EventArgs e)
        {
            MessageBox.Show(calRangoFecha.GetDisplayRange(true).ToString());
        }

       
    }
}
