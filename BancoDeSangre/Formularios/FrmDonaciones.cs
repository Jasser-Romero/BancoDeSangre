using AppCore.Interfaces;
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
    public partial class FrmDonaciones : Form
    {
        public IDonanteService donanteRepository { get; set; }
        public IDonacionService donacionService { get; set; }
        public FrmDonaciones()
        {
            InitializeComponent();
        }

        private void FrmDonaciones_Load(object sender, EventArgs e)
        {
            dgvMostrarDonantes.DataSource = null;
            dgvMostrarDonantes.DataSource = donanteRepository.GetAll();
        }

        private void btnDonar_Click(object sender, EventArgs e)
        {
            List<Donacion> list = donacionService.GetAll();
            if (dgvMostrarDonantes.CurrentRow.Selected == false)
            {
                dgvMostrarDonantes.DataSource = donanteRepository.GetAll();
                MessageBox.Show("Seleccione a un donante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string nombre = dgvMostrarDonantes.CurrentRow.Cells[1].Value.ToString();
            string apellidos = dgvMostrarDonantes.CurrentRow.Cells[2].Value.ToString();

            GrupoSanguineo grupoSanguineo = (GrupoSanguineo)dgvMostrarDonantes.CurrentRow.Cells[9].Value;
            FactorRH factorRH = (FactorRH)dgvMostrarDonantes.CurrentRow.Cells[8].Value;

            Donacion donacion = new Donacion(nombre, apellidos, grupoSanguineo, factorRH)
            {
                CantidadDonada = (int)nudCantidadDonada.Value
            };
            Donacion temp = list?.Where(x => x.Nombre == nombre)?.FirstOrDefault();

            if(temp != null)
            {
                MessageBox.Show($"Error, el donante seleccionado ya ha donado","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            donacionService.Create(donacion);
            MessageBox.Show("Donacion realizada satisfactoriamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvMostrarDonantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int index = e.RowIndex;
            //txtNombre.Text = dgvMostrarDonantes.SelectedRows[index].Cells[1].Value.ToString();
            //txtApellidos.Text = dgvMostrarDonantes.SelectedRows[index].Cells[2].Value.ToString();
            //txtGrupoSanguineo.Text = dgvMostrarDonantes.SelectedRows[index].Cells[9].Value.ToString();
            //txtFactorRH.Text = dgvMostrarDonantes.SelectedRows[index].Cells[8].Value.ToString();
            
        }

        private void dgvMostrarDonantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //foreach (DataGridViewRow row in dgvMostrarDonantes.Rows)
            //{
            //    LimpiarCampos();
            //    txtNombre.Text = row.Cells[1].Value.ToString();
            //    txtApellidos.Text = row.Cells[2].Value.ToString();
            //    txtFactorRH.Text = row.Cells[8].Value.ToString();
            //    txtGrupoSanguineo.Text = row.Cells[9].Value.ToString();
            //}

            txtNombre.Text = dgvMostrarDonantes.CurrentRow.Cells[1].Value.ToString();
            txtApellidos.Text = dgvMostrarDonantes.CurrentRow.Cells[2].Value.ToString();
            txtFactorRH.Text = dgvMostrarDonantes.CurrentRow.Cells[8].Value.ToString();
            txtGrupoSanguineo.Text = dgvMostrarDonantes.CurrentRow.Cells[9].Value.ToString();
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtFactorRH.Text = "";
            txtGrupoSanguineo.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtFactorRH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGrupoSanguineo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
