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

namespace BancoDeSangre.Formularios
{
    public partial class FrmActualizar : Form
    {
        public IDonanteService DonanteService { get; set; }
        public FrmActualizar()
        {
            
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Donante donante = new Donante()
            {
                Id = Convert.ToInt32(txtId.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellidos.Text,
                Cedula = txtCedula.Text,
                Correo = txtCorreo.Text,
                FactorRH = (FactorRH)cmbFactorRH.SelectedIndex,
                EstadoCivil = (EstadoCivil)cmbEstadoCivil.SelectedIndex,
                FechaNacimiento = dtpFechaNacimiento.Value,
                GrupoSanguineo = (GrupoSanguineo)cmbGrupoSanguineo.SelectedIndex,
                Genero = (Genero)cmbGenero.SelectedIndex,
                Telefono = txtTelefono.Text,
                Ocupacion = txtOcupacion.Text
            };

            DonanteService.Update(donante);
            Dispose();
        }

        private void FrmActualizar_Load(object sender, EventArgs e)
        {
            cmbGrupoSanguineo.Items.AddRange(Enum.GetValues(typeof(GrupoSanguineo)).Cast<object>().ToArray());
            cmbGenero.Items.AddRange(Enum.GetValues(typeof(Genero)).Cast<object>().ToArray());
            cmbEstadoCivil.Items.AddRange(Enum.GetValues(typeof(EstadoCivil)).Cast<object>().ToArray());
            cmbFactorRH.Items.AddRange(Enum.GetValues(typeof(FactorRH)).Cast<object>().ToArray());
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
