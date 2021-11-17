using AppCore.Interfaces;
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
    public partial class FrmAlmacen : Form
    {
        public IDonanteService DonanteService { get; set; }
        public IDonacionService DonacionService { get; set; }
        public FrmAlmacen()
        {
            InitializeComponent();
        }


    }
}
