using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Drawing;
using CapaNegocio.Entidades;
namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
        private CN_Login obj_cnLogin = new CN_Login();

        public frmLogin()
        {
            InitializeComponent();
            lblOlvideContrasena.Font = new Font(lblOlvideContrasena.Font, FontStyle.Underline);
            lblCrearUsuario.Font = new Font(lblCrearUsuario.Font, FontStyle.Underline);


        }

        private void lblOlvideContrasena_Click(object sender, EventArgs e)
        {
            frmRecuperarUsuario frmRecuperarUsuario = new frmRecuperarUsuario();
            frmRecuperarUsuario.Show();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            obj_cnLogin.User = txtUser.Text;
            obj_cnLogin.Password = txtPass.Text;
            int result = obj_cnLogin.Login(obj_cnLogin);

            if (result == 1)
            {
                frmLogin frm = new frmLogin();
                this.Hide();
                frm.ShowDialog();
            }
            else if (result == 0)
            {
                MessageBox.Show("Usuario o Password Incorrectos");
            }
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {


            obj_cnLogin.User = txtUser.Text;
            obj_cnLogin.Password = txtPass.Text;
            int result = obj_cnLogin.Login(obj_cnLogin);
            if (result == 1)
            {
                frmPrincipal frm = new frmPrincipal();
                this.Hide();
                frm.ShowDialog();
            }
            else if (result == 0)
            {
                MessageBox.Show("Usuario o Password Incorrectos");
            }
        }

        private void lblCrearUsuario_Click(object sender, EventArgs e)
        {
            frmCrearUsuario frmCrearUsuario = new frmCrearUsuario();
            frmCrearUsuario.ShowDialog();
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
           
        }
    }
}
