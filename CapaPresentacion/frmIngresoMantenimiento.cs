using CapaNegocio.Entidades;
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
    public partial class frmIngresoMantenimiento : Form
    {
        private CN_IngresoMantenimiento obj_mantenimiento = new CN_IngresoMantenimiento();
        public frmIngresoMantenimiento()
        {
            InitializeComponent();
            obtenerCodigo();
            obtenerMecanico();
            obtenerVehiculo();
            obtenerCliente();
            obtenerServicio();



        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            obj_mantenimiento.Codigo = txtCodigo.Text;
            obj_mantenimiento.FechaMantenimiento = dtpFechaNacimiento.Value.ToString();
            obj_mantenimiento.Diagnostico = txtDiagnostico.Text;
            obj_mantenimiento.TrabajosRealizados = rtbTrabajosRealizados.Text;
            int idMecanico = (int)cmbMecanico.SelectedValue;
            obj_mantenimiento.Id_Mecanico = idMecanico;
            int idCliente = (int)cmbCliente.SelectedValue;
            obj_mantenimiento.Id_Cliente = idCliente;
            int idServicio = (int)cmbServicio.SelectedValue;
            obj_mantenimiento.Id_servicio = idServicio;
            int idVehiculo = (int)cmbVehiculo.SelectedValue;
            obj_mantenimiento.Id_Vehiculo = idVehiculo;
            obj_mantenimiento.RepuestosUtilizados = txtRepuestosUtilizados.Text;
            obj_mantenimiento.Id_Mantenimiento = obtenerIdMantenimiento();
            setearRepuestos();
            comprobarChecked();
            ingresarBaseDatos();
            this.Dispose();
        }

        private void setearRepuestos()
        {
            if (txtValorRepuestos.ReadOnly == true)
            {
                obj_mantenimiento.ValorRespuestos = 0.00F;
            }
            else
            {
                obj_mantenimiento.ValorRespuestos = Convert.ToInt64(txtValorRepuestos.Text);
            }
        }

        private void comprobarChecked()
        {
            if (rbCorrectivo.Checked)
            {
                obj_mantenimiento.TipoMantenimiento = "Correctivo";
            }
            else
            {
                obj_mantenimiento.TipoMantenimiento = "Preventivo";
            }
        }

        private void ingresarBaseDatos()
        {
            try
            {
                if(rbServicioNo.Checked == true)
                {
                    if (obj_mantenimiento.ingresarMantenimiento(obj_mantenimiento))
                    {
                        MessageBox.Show("Registro Insertado con EXITO");
                    }
                    else
                    {
                        MessageBox.Show("El registro no se pudo insertar");
                    }
                }
                else
                {
                    if (obj_mantenimiento.ingresarMantenimiento(obj_mantenimiento) && obj_mantenimiento.ingresarServicio(obj_mantenimiento))
                    {
                        MessageBox.Show("Registro Insertado con EXITO");
                    }
                    else
                    {
                        MessageBox.Show("El registro no se pudo insertar");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ingresar a la base de datos" + ex.Message);
            }
        }

        private void obtenerMecanico()
        {
            try
            {
                CN_consultaMecanico objMecanico = new CN_consultaMecanico();
                DataTable tablaMecanicos = objMecanico.getMecanico();

                if (tablaMecanicos != null && tablaMecanicos.Rows.Count > 0)
                {
                    // Concatenar nombres y apellidos en una nueva columna "NombreCompleto"
                    tablaMecanicos.Columns.Add("NombreCompleto", typeof(string), "Nombres + ' ' + Apellidos");

                    cmbMecanico.DataSource = tablaMecanicos;
                    cmbMecanico.DisplayMember = "NombreCompleto";
                    cmbMecanico.ValueMember = "Id_Mecanico";
                }
                else
                {
                    cmbMecanico.Items.Add("No hay mecánicos disponibles");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener mecánico: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void obtenerCliente()
        {
            try
            {
                CN_IngresoCliente objCliente = new CN_IngresoCliente();
                DataTable tablaClientes = objCliente.getCliente();

                if (tablaClientes != null && tablaClientes.Rows.Count > 0)
                {
                    // Concatenar nombres y apellidos en una nueva columna "NombreCompleto"
                    tablaClientes.Columns.Add("NombreCompleto", typeof(string), "Nombres + ' ' + Apellidos");

                    cmbCliente.DataSource = tablaClientes;
                    cmbCliente.DisplayMember = "NombreCompleto";
                    cmbCliente.ValueMember = "Id_Cliente";
                }
                else
                {
                    cmbCliente.Items.Add("No hay clientes disponibles");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener Cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void obtenerVehiculo()
        {
            try
            {
                CN_IngresoVehiculo obj_vehiculo = new CN_IngresoVehiculo();
                cmbVehiculo.DataSource = obj_vehiculo.getVehiculo();
                cmbVehiculo.DisplayMember = "Placa";
                cmbVehiculo.ValueMember = "Id_Vehiculo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener Vehiculos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void obtenerServicio()
        {
            try
            {
                cmbServicio.DataSource = obj_mantenimiento.getServicio();
                cmbServicio.DisplayMember = "NombreServicio";
                cmbServicio.ValueMember = "Id_Servicio";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener Servicios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int obtenerIdMantenimiento()
        {
            try
            {
                return Convert.ToInt32(obj_mantenimiento.getIdMantenimiento())+1;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el Id mantenimiento" + ex.Message);
            }
        }
        private void obtenerCodigo()
        {
            string codigo = obj_mantenimiento.getCodigoMantenimiento();
            string parteNumerica = codigo.Substring(3);
            if (int.TryParse(parteNumerica, out int numero))
            {
                // Incrementar el número en 1
                numero++;

                // Formatear el nuevo código
                string nuevoCodigo = $"{codigo.Substring(0, 3)}{numero:D3}";
                txtCodigo.Text = nuevoCodigo;
            }
            else
            {
                Console.WriteLine("No se pudo extraer la parte numérica.");
            }

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            frmMantenimientoCorrectivo frmMantenimientoCorrectivo = new frmMantenimientoCorrectivo();
            frmMantenimientoCorrectivo.ShowDialog();
        }

        private void rbCorrectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCorrectivo.Checked)
            {
                txtRepuestosUtilizados.Text = String.Empty;
                txtValorRepuestos.Text = String.Empty;
                txtRepuestosUtilizados.ReadOnly = false;
                txtValorRepuestos.ReadOnly = false;

            }
        }

        private void rbPreventivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPreventivo.Checked)
            {
                txtRepuestosUtilizados.Text = "N/A";
                txtValorRepuestos.Text = "00.00";
                txtRepuestosUtilizados.ReadOnly = true;
                txtValorRepuestos.ReadOnly = true;
            }
        }

        private void rbServicioSI_EnabledChanged(object sender, EventArgs e)
        {
            cmbServicio.Enabled = true;
        }

        private void rbServicioSI_CheckedChanged(object sender, EventArgs e)
        {
            cmbServicio.Enabled = true;

        }

        private void rbServicioNo_CheckedChanged(object sender, EventArgs e)
        {
            cmbServicio.Enabled = false;
        }

        /*private void limpiarCampos()
        {
            txtApellidos.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }*/
        /*private bool validarCamposVacios()
        {
            try
            {
                if (txtDiagnostico.Text.Length != 0 && cmbCliente.Text.Length != 0 && c.Text.Length != 0 && txtDireccion.Text.Length != 0)
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
        }*/
    }
}
