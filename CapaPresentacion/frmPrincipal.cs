using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngresoCliente frmCrearCliente = new frmIngresoCliente();
            frmCrearCliente.MdiParent = this;
            frmCrearCliente.Show();

        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultarCliente frmConsultar = new frmConsultarCliente();
            frmConsultar.MdiParent = this;
            frmConsultar.Show();
        }

        private void mecanicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarMecanico frmConsultarMecanico = new frmConsultarMecanico();
            frmConsultarMecanico.MdiParent = this;
            frmConsultarMecanico.Show();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngresoMantenimiento frmIngresoMantenimiento = new frmIngresoMantenimiento();
            frmIngresoMantenimiento.ShowDialog();
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngresoVehiculo frmIngresoVehiculo = new frmIngresoVehiculo();
            frmIngresoVehiculo.MdiParent = this;
            frmIngresoVehiculo.Show();
        }

        private void vehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarVehiculo frmConsultarVehiculo = new frmConsultarVehiculo();
            frmConsultarVehiculo.MdiParent=this;
            frmConsultarVehiculo .Show();
        }
    }
}
