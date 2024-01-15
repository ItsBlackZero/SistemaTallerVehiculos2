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
    public partial class frmConsultarMecanico : Form
    {
        CN_consultaMecanico obj_mecanico = new CN_consultaMecanico();
        public frmConsultarMecanico()
        {
            InitializeComponent();
            CargarComboMecanico();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            obj_mecanico.Cedula = txtConsultarMecanico.Text;
            dgvMecanico.DataSource = obj_mecanico.getMecanicoByCedula(obj_mecanico);
        }

        private void CargarComboMecanico()
        {
            try
            {
                dgvMecanico.DataSource = obj_mecanico.getMecanico();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            CargarComboMecanico();
        }

        private void txtConsultarMecanico_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumeros(sender, e);
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
