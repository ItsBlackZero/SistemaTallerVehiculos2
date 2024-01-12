using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaNegocio.Entidades;

namespace CapaPresentacion
{
    public partial class frmRecuperarUsuario : Form
    {
        public frmRecuperarUsuario()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var user = new CN_Login();
            var result = user.recoverPassword(txtCorreo.Text);
            lblResultado.Text = result;
        }
    }
}
