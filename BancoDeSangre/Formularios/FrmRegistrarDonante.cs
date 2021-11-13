using AppCore.Interfaces;
using AppCore.Services;
using Domain.Entities;
using Domain.Enums;
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
    public partial class FrmRegistrarDonante : Form
    {
        public DonanteModel donanteModel { get; set; }
        public FrmRegistrarDonante()
        {
            InitializeComponent();
        }

        private void FrmRegistrarDonante_Load(object sender, EventArgs e)
        {
            cmbGrupoSanguineo.Items.AddRange(Enum.GetValues(typeof(GrupoSanguineo)).Cast<object>().ToArray());
            cmbGenero.Items.AddRange(Enum.GetValues(typeof(Genero)).Cast<object>().ToArray());
            cmbEstadoCivil.Items.AddRange(Enum.GetValues(typeof(EstadoCivil)).Cast<object>().ToArray());
            cmbFactorRH.Items.AddRange(Enum.GetValues(typeof(FactorRH)).Cast<object>().ToArray());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Donante donante = new Donante()
            //    {
            //        Id = donanteModel.GetLastId() + 1,
            //        Nombre = txtNombre.Text,
            //        Apellido = txtApellidos.Text,
            //        Cedula = txtCedula.Text,
            //        Correo = txtCorreo.Text,
            //        FactorRH = (FactorRH)cmbFactorRH.SelectedIndex,
            //        EstadoCivil = (EstadoCivil)cmbEstadoCivil.SelectedIndex,
            //        FechaNacimiento = dtpFechaNacimiento.Value,
            //        GrupoSanguineo = (GrupoSanguineo)cmbGrupoSanguineo.SelectedIndex,
            //        Genero = (Genero)cmbGenero.SelectedIndex,
            //        Telefono = txtTelefono.Text,
            //        Ocupacion = txtOcupacion.Text,
            //    };

            //    donanteModel.Create(donante);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error: {ex}");
            //}
            Donante donante = new Donante()
            {
                Id = donanteModel.GetLastId() + 1,
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
                Ocupacion = txtOcupacion.Text,
            };

            donanteModel.Create(donante);

            Dispose();
        }
    }
}
