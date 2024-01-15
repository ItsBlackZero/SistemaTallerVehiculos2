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
    public partial class frmConsultarCliente : Form
    {
        CN_IngresoCliente obj_cliente = new CN_IngresoCliente();
        public frmConsultarCliente()
        {
            InitializeComponent();
            CargarComboCliente();
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CargarComboCliente()
        {
            try
            {
                dgvCliente.DataSource = obj_cliente.getCliente();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            obj_cliente.Cedula = txtConsultaCedula.Text;
            dgvCliente.DataSource = obj_cliente.getClienteByCedula(obj_cliente);

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            CargarComboCliente();
        }

        private void txtConsultaCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumeros(sender,e);
        }
        private void validarNumeros(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Por favor, ingrese solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }


}
