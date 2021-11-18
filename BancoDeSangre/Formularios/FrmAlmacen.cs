using AppCore.Interfaces;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BancoDeSangre.Formularios
{
    public partial class FrmAlmacen : Form
    {
        public IDonanteService DonanteService { get; set; }
        public IDonacionService DonacionService { get; set; }
        public FrmAlmacen()
        {
            InitializeComponent();
        }

        private void FrmAlmacen_Load(object sender, EventArgs e)
        {
            cmbGrupoSanguineo.Items.AddRange(Enum.GetValues(typeof(GrupoSanguineo)).Cast<object>().ToArray());

            cpbProgresoAlmacen.Value = 0;
            cpbProgresoAlmacen.Minimum = 0;
            cpbProgresoAlmacen.Maximum = 10000;
            
        }

        private void cmbGrupoSanguineo_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Donacion> donaciones = DonacionService.GetAll();

            
            
            switch (cmbGrupoSanguineo.SelectedIndex)
            {
                //A+, A-, B+, B-, AB+, AB-, O+, O-
                case 0:
                    cpbProgresoAlmacen.Text = "A+";
                    cpbProgresoAlmacen.Value = donaciones.Where(x => x.GrupoSanguineo.Equals(GrupoSanguineo.A_Positivo)).Sum(x => x.CantidadDonada);
                    lblTotal.Text = donaciones.Where(x => x.GrupoSanguineo.Equals(GrupoSanguineo.A_Positivo)).Sum(x => x.CantidadDonada).ToString();
                    break;
                case 1:
                    cpbProgresoAlmacen.Text = "A-";
                    cpbProgresoAlmacen.Value = donaciones.Where(x => x.GrupoSanguineo.Equals(GrupoSanguineo.A_Negativo)).Sum(x => x.CantidadDonada);
                    lblTotal.Text = donaciones.Where(x => x.GrupoSanguineo.Equals(GrupoSanguineo.A_Negativo)).Sum(x => x.CantidadDonada).ToString();
                    break;
                case 2:
                    cpbProgresoAlmacen.Text = "B+";
                    cpbProgresoAlmacen.Value = donaciones.Where(x => x.GrupoSanguineo.Equals(GrupoSanguineo.B_Positivo)).Sum(x => x.CantidadDonada);
                    lblTotal.Text = donaciones.Where(x => x.GrupoSanguineo.Equals(GrupoSanguineo.B_Positivo)).Sum(x => x.CantidadDonada).ToString();
                    break;
                case 3:
                    cpbProgresoAlmacen.Text = "B-";
                    cpbProgresoAlmacen.Value = donaciones.Where(x => x.GrupoSanguineo.Equals(GrupoSanguineo.B_Negativo)).Sum(x => x.CantidadDonada);
                    lblTotal.Text = donaciones.Where(x => x.GrupoSanguineo.Equals(GrupoSanguineo.B_Negativo)).Sum(x => x.CantidadDonada).ToString();
                    break;
                case 4:
                    cpbProgresoAlmacen.Text = "AB+";
                    cpbProgresoAlmacen.Value = donaciones.Where(x => x.GrupoSanguineo.Equals(GrupoSanguineo.AB_Positivo)).Sum(x => x.CantidadDonada);
                    lblTotal.Text = donaciones.Where(x => x.GrupoSanguineo.Equals(GrupoSanguineo.AB_Positivo)).Sum(x => x.CantidadDonada).ToString();
                    break;
                case 5:
                    cpbProgresoAlmacen.Text = "AB-";
                    cpbProgresoAlmacen.Value = donaciones.Where(x => x.GrupoSanguineo.Equals(GrupoSanguineo.AB_Negativo)).Sum(x => x.CantidadDonada);
                    lblTotal.Text = donaciones.Where(x => x.GrupoSanguineo.Equals(GrupoSanguineo.AB_Negativo)).Sum(x => x.CantidadDonada).ToString();
                    break;
                case 6:
                    cpbProgresoAlmacen.Text = "O+";
                    cpbProgresoAlmacen.Value = donaciones.Where(x => x.GrupoSanguineo.Equals(GrupoSanguineo.O_Positivo)).Sum(x => x.CantidadDonada);
                    lblTotal.Text = donaciones.Where(x => x.GrupoSanguineo.Equals(GrupoSanguineo.O_Positivo)).Sum(x => x.CantidadDonada).ToString();
                    break;
                case 7:
                    cpbProgresoAlmacen.Text = "O-";
                    cpbProgresoAlmacen.Value = donaciones.Where(x => x.GrupoSanguineo.Equals(GrupoSanguineo.O_Negativo)).Sum(x => x.CantidadDonada);
                    lblTotal.Text = donaciones.Where(x => x.GrupoSanguineo.Equals(GrupoSanguineo.O_Negativo)).Sum(x => x.CantidadDonada).ToString();
                    break;
            }
        }

        private void cpbProgresoAlmacen_Click(object sender, EventArgs e)
        {

        }
    }
}
