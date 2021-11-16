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
        public DonanteRepository donanteRepository { get; set; }
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
    }
}
