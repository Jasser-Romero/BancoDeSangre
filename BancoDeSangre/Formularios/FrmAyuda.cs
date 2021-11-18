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
    public partial class FrmAyuda : Form
    {
        public FrmAyuda()
        {
            InitializeComponent();
        }

        private void FrmAyuda_Load(object sender, EventArgs e)
        {
            rtbAyuda.Text = "Este programa, realiza la simulacion de un Banco de Sangre\n" +
                "Por su parte, este trae funciones principales como Registrar, Consultar, Almacenar y Donar\n" +
                "En el boton de Donantes, se registran los datos de la persona que va a donar\n" +
                "En el boton de Consultar, este contiene mas opciones, como filtrar por tipos de busqueda, como el ID, Nombre" +
                "Cedula y Grupos Sanguineos, ademas de mostrar la lista de donantes registrados, lo cual se pueden modificar, eliminar y" +
                "generar un reporte que se exporta a documento PDF\n" +
                "En el boton de Almacen se muestra las cantidades donadas segun el grupo sanguineo de cada persona\n" +
                "En el boton de Donaciones, se muestra la lista de los donantes registrados para luego seleccionarlo y escribir la " +
                "cantidad que haya donado, teniendo como cantidad maxima 500 ml";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
