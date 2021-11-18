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
using System.Text.RegularExpressions;
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
            if (cmbEstadoCivil.SelectedIndex == -1)
            {
                MessageBox.Show("Error, todos los campos son necesarios", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbFactorRH.SelectedIndex == -1)
            {
                MessageBox.Show("Error, todos los campos son necesarios", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Error, todos los campos son necesarios", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbGrupoSanguineo.SelectedIndex == -1)
            {
                MessageBox.Show("Error, todos los campos son necesarios", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string patronCedula = @"\A[0-9]{3}(\-)[0-9]{6}(\-)[0-9]{4}[A-Z]\Z";
            if (!Regex.IsMatch(txtCedula.Text, patronCedula))
            {
                MessageBox.Show("Error, cédula ingresada invalida", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string patronTelefono = @"\A[0-9]{7,10}\z";
            if (!Regex.IsMatch(txtTelefono.Text, patronTelefono))
            {
                MessageBox.Show("Error, telefono ingresado invalido", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellidos.Text) || string.IsNullOrEmpty(txtCedula.Text)
                || string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtOcupacion.Text) || string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Error, se requieren de todos los campos", "Mensaje de Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
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
