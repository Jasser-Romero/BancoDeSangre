using AppCore.Interfaces;
using AppCore.Services;
using Autofac;
using BancoDeSangre.Formularios;
using Domain.Interfaces;
using Infraestructure.Donantes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeSangre
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //TODO: Falta agregar el proceso

            var builder = new ContainerBuilder();

            builder.RegisterType<DonanteModel>().As<IDonanteRepository>();
            builder.RegisterType<DonanteService>().As<IDonanteService>();

            var container = builder.Build();

            //FrmMenuPrincipal frmMenu = new FrmMenuPrincipal(container.Resolve)
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
    }
}
