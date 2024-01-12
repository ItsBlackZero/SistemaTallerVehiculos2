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
    public partial class frmIngresoCliente : Form
    {
        private CN_IngresoCliente obj_IngresoCliente = new CN_IngresoCliente();
        public frmIngresoCliente()
        {
            InitializeComponent();
            lblIngresoCliente.Font = new System.Drawing.Font("ARIAL", 30);
            CargarComboProvincias();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNombre.Focus();
            if (validarCamposVacios())
            {
                obj_IngresoCliente.Nombres = txtNombre.Text;
                obj_IngresoCliente.Apellidos = txtApellidos.Text;
                obj_IngresoCliente.Cedula = txtCedula.Text;
                obj_IngresoCliente.Direccion = txtDireccion.Text;
                obj_IngresoCliente.Telefono = txtTelefono.Text;
                if (obj_IngresoCliente.crearCliente(obj_IngresoCliente))
                {
                    MessageBox.Show("Registro Insertado con EXITO");
                    CargarComboProvincias();
                }
                limpiarCampos();


            }

        }

        


        private void limpiarCampos()
        {
            txtApellidos.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
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
                if (txtNombre.Text.Length != 0 && txtApellidos.Text.Length != 0 && txtCedula.Text.Length != 0 && txtDireccion.Text.Length != 0)
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
                dgvIngresoCliente.DataSource = obj_IngresoCliente.getCliente();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void txtCedula_KeyDown(object sender, KeyEventArgs e)
        {
            validarCedula(sender, e);
        }

        private void validarCedula(object sender, KeyEventArgs e)
        {

            // Verifica si la tecla presionada es la tecla de retroceso (Backspace).
            if (e.KeyCode == Keys.Back)
            {
                // Permite la eliminación de caracteres.
                e.SuppressKeyPress = false;
            }
            else
            {
                // Verifica que la tecla presionada sea un dígito y que la longitud sea menor o igual a 9.
                if (!char.IsDigit((char)e.KeyCode) || txtCedula.Text.Length >= 10)
                {
                    // Suprime la tecla presionada.
                    e.SuppressKeyPress = true;
                }

            }

        }

        private void validarTelefono(object sender, KeyEventArgs e)
        {

            // Verifica si la tecla presionada es la tecla de retroceso (Backspace).
            if (e.KeyCode == Keys.Back)
            {
                // Permite la eliminación de caracteres.
                e.SuppressKeyPress = false;
            }
            else
            {
                // Verifica que la tecla presionada sea un dígito y que la longitud sea menor o igual a 9.
                if (!char.IsDigit((char)e.KeyCode) || txtTelefono.Text.Length >= 11)
                {
                    // Suprime la tecla presionada.
                    e.SuppressKeyPress = true;
                }

            }

        }

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            validarTelefono(sender, e);
        }
    }
}
