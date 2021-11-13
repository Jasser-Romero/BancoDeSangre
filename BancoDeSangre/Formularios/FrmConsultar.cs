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
    public partial class FrmConsultar : Form
    {
        public DonanteModel donanteService { get; set; }
        public FrmConsultar()
        {
            InitializeComponent();
        }

        private void FrmConsultar_Load(object sender, EventArgs e)
        {
            dtgListaDonantes.DataSource = null;
            dtgListaDonantes.DataSource = donanteService.GetAll();
        }
    }
}
