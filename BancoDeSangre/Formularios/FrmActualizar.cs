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
        public FrmConsultar FrmConsultar { get; set; }
        public IDonanteService DonanteService { get; set; }
        public FrmActualizar()
        {
            
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Donante donante = new Donante()
            {
                Id = FrmConsultar.donanteActualizar.Id,
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

            DonanteService.Actualizar(donante);
            Dispose();
        }

        private void FrmActualizar_Load(object sender, EventArgs e)
        {
            cmbGrupoSanguineo.Items.AddRange(Enum.GetValues(typeof(GrupoSanguineo)).Cast<object>().ToArray());
            cmbGenero.Items.AddRange(Enum.GetValues(typeof(Genero)).Cast<object>().ToArray());
            cmbEstadoCivil.Items.AddRange(Enum.GetValues(typeof(EstadoCivil)).Cast<object>().ToArray());
            cmbFactorRH.Items.AddRange(Enum.GetValues(typeof(FactorRH)).Cast<object>().ToArray());

            txtNombre.Text = FrmConsultar.donanteActualizar.Nombre;
            txtApellidos.Text = FrmConsultar.donanteActualizar.Apellido;
            txtCedula.Text = FrmConsultar.donanteActualizar.Cedula;
            txtCorreo.Text = FrmConsultar.donanteActualizar.Correo;
            txtOcupacion.Text = FrmConsultar.donanteActualizar.Ocupacion;
            txtTelefono.Text = FrmConsultar.donanteActualizar.Telefono;
            cmbGrupoSanguineo.SelectedIndex = (int)FrmConsultar.donanteActualizar.GrupoSanguineo;
            cmbGenero.SelectedIndex = (int)FrmConsultar.donanteActualizar.Genero;
            cmbFactorRH.SelectedIndex = (int)FrmConsultar.donanteActualizar.FactorRH;
            cmbEstadoCivil.SelectedIndex = (int)FrmConsultar.donanteActualizar.EstadoCivil;
        }
    }
}
