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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class frmIngresoVehiculo : Form
    {

        private CN_IngresoVehiculo obj_vehiculo = new CN_IngresoVehiculo();
        public frmIngresoVehiculo()
        {
            InitializeComponent();
            limpiarCampos();
            CargarComboProvincias();


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            validarCamposVacios();
            obj_vehiculo.Placa = txtPlaca.Text;
            obj_vehiculo.Kilometraje = txtKilometraje.Text;
            obj_vehiculo.Anio = txtAnio.Text;
            obj_vehiculo.Modelo = txtModelo.Text;
            if (obj_vehiculo.ingresarVehiculo(obj_vehiculo))
            {
                MessageBox.Show("Registro insertado con exito");
                CargarComboProvincias();
            }
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            txtPlaca.Text = string.Empty;
            txtModelo.Text = string.Empty;
            txtKilometraje.Text = string.Empty;
            txtAnio.Text = string.Empty;
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

        private bool validarCamposVacios()
        {
            try
            {
                if (txtAnio.Text.Length != 0 && txtKilometraje.Text.Length != 0 && txtModelo.Text.Length != 0 && txtPlaca.Text.Length != 0)
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
        private void CargarComboProvincias()
        {
            try
            {
                dgvIngreoVehiculo.DataSource = obj_vehiculo.getVehiculo();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {
            txtPlaca.Text = txtPlaca.Text.ToUpper();
            txtPlaca.SelectionStart = txtPlaca.Text.Length;
        }


        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPlaca_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = false;
            }
            else
            {
                if (txtPlaca.Text.Length >= 7)
                {
                    // Suprime la tecla presionada.
                    e.SuppressKeyPress = true;
                }

            }


        }
        
        private void txtAnio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = false;
            }
            else
            {
                if (!char.IsDigit((char)e.KeyCode) || txtAnio.Text.Length >= 4)
                {
                    // Suprime la tecla presionada.
                    e.SuppressKeyPress = true;
                }

            }
        }
    }
}
