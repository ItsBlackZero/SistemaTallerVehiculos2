using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.Entidades;
namespace CapaPresentacion
{
    public partial class frmFactura : Form
    {
        CN_factura obj_factura = new CN_factura();
        public frmFactura()
        {
            InitializeComponent();
            CargarComboFactura();
        }

        private void tblTitulo_Click(object sender, EventArgs e)
        {

        }
        private void CargarComboFactura()
        {
            try
            {
                dgvFactura.DataSource = obj_factura.getFactura();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
