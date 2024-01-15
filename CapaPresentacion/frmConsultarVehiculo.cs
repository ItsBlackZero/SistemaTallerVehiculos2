using CapaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmConsultarVehiculo : Form
    {
        private CN_IngresoVehiculo obj_mecanico = new CN_IngresoVehiculo();
        public frmConsultarVehiculo()
        {
            InitializeComponent();
            CargarComboVehiculos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            validarCamposVacios();
            obj_mecanico.Placa = txtConsulta.Text;
            dgvVehiculo.DataSource = obj_mecanico.getVehiculoByPlaca(obj_mecanico);

        }
        private void CargarComboVehiculos()
        {
            try
            {
                dgvVehiculo.DataSource = obj_mecanico.getVehiculo();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool validarCamposVacios()
        {
            try
            {
                if (txtConsulta.Text.Length != 0)
                {
                    return true;
                }
                MessageBox.Show("Por favor, llene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            txtConsulta.Text = txtConsulta.Text.ToUpper();
            txtConsulta.SelectionStart = txtConsulta.Text.Length;
        }

        private void txtConsulta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = false;
            }
            else
            {
                if (txtConsulta.Text.Length >= 7)
                {
                    // Suprime la tecla presionada.
                    e.SuppressKeyPress = true;
                }

            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            CargarComboVehiculos();
        }
    }
}
