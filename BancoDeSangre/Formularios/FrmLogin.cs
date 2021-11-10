using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeSangre.Formularios
{
    public partial class FrmLogin : Form
    {
        private string User = "Admin";
        private string Password = "Anaconda";
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Black;
            }

        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "CONTRASEÑA")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.Black;
                txtContrasena.UseSystemPasswordChar = true;
            }

        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "CONTRASEÑA";
                txtContrasena.ForeColor = Color.Black;
                txtContrasena.UseSystemPasswordChar = false;
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text.Equals(User) && txtContrasena.Text.Equals(Password))
            {
                this.Hide();
                FrmMenuPrincipal principal = new FrmMenuPrincipal();
                principal.ShowDialog();
                this.Close();
            }
            else { 
           
                MessageBox.Show("Usted tiene algun dato erroneo, vuelva ingresar bien los datos", "Error de Verificacion", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
          
           
        }

        }
    }

