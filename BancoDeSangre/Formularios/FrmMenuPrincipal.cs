using AppCore.Interfaces;
using AppCore.Services;
using Infraestructure.Donantes;
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
    public partial class FrmMenuPrincipal : Form
    {

        public int xClick = 0, yClick = 0;
        //public DonanteRepository donanteService;
        private IDonanteService donanteService;
        private IDonacionService donacionService;
        public FrmMenuPrincipal(IDonanteService donanteService, IDonacionService donacionService)
        {
            this.donanteService = donanteService;
            this.donacionService = donacionService;
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FrmRegistrarDonante frmRegistrarDonante = new FrmRegistrarDonante();
            frmRegistrarDonante.donanteModel = donanteService;
            AbrirFormHija(new FrmRegistrarDonante() {
            donanteModel = donanteService
            });
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            FrmConsultar frmConsultar = new FrmConsultar();
            frmConsultar.donanteService = donanteService;
            AbrirFormHija(frmConsultar);

        }

        private void btnDonar_Click(object sender, EventArgs e)
        {
            FrmDonaciones frmDonaciones = new FrmDonaciones();
            frmDonaciones.donanteRepository = donanteService;
            frmDonaciones.donacionService = donacionService;
            AbrirFormHija(frmDonaciones);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void pnlBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                xClick = e.X; yClick = e.Y;

            }
            else
            {
                this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick);
            }
        }

        private void FrmMenuPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                xClick = e.X; yClick = e.Y;

            }
            else
            {
                this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick);
            }
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            FrmAlmacen frmAlmacen = new FrmAlmacen();
            frmAlmacen.DonacionService = donacionService;
            frmAlmacen.DonanteService = donanteService;
            AbrirFormHija(frmAlmacen);
        }

        private void AbrirFormHija(object formHija)
        {
            if (this.pnlContenedor.Controls.Count > 0)
            {
                this.pnlContenedor.Controls.RemoveAt(0);
            }
            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            FrmAyuda frmAyuda = new FrmAyuda();
            AbrirFormHija(frmAyuda);
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {
          
        }
    }
}
