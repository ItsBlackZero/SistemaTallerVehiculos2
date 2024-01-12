using CapaDatos.Entidades;
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
    public partial class frmCrearUsuario : Form
    {
        CN_Login obj_controlador = new CN_Login();
        public frmCrearUsuario()
        {
            InitializeComponent();
            lblCreacionUsuario.Font = new System.Drawing.Font("Arial", 20);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length != 0 && txtPassword.Text.Length != 0 && txtCorreo.Text.Length != 0 && txtUsuario.Text.Length != 0)
            {
                obj_controlador.Nombre = txtNombre.Text;
                obj_controlador.User = txtUsuario.Text;
                obj_controlador.Password = txtPassword.Text;
                obj_controlador.Email = txtCorreo.Text;
                if (obj_controlador.crearUsuario(obj_controlador))
                {
                    MessageBox.Show("USUARIO REGISTRADO CON EXITO");
                }
                else
                {
                    MessageBox.Show("REGISTRO NO PUDO CREARSE");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Porfavor llenar todos los campos");
            }

        }
    }
}
