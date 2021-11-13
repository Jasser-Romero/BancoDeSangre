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
        public DonanteModel donanteService;
        public FrmMenuPrincipal()
        {
            donanteService = new DonanteModel();
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FrmRegistrarDonante frmRegistrarDonante = new FrmRegistrarDonante();
            frmRegistrarDonante.donanteModel = donanteService;
            frmRegistrarDonante.ShowDialog();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            FrmConsultar frmConsultar = new FrmConsultar();
            frmConsultar.donanteService = donanteService;
            frmConsultar.ShowDialog();

        }
    }
}
