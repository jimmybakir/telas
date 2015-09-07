using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScadaTelas.Controlador;

namespace ScadaTelas
{
    public partial class CrearRecetaProceso : Form
    {
        FaconSvr.FaconServer servidor;
        public CrearRecetaProceso()
        {
            InitializeComponent();
        }

        private void CrearRecetaProceso_Load(object sender, EventArgs e)
        {
            servidor = ServidorFatek.CreateObject("FaconSvr.FaconServer");
            servidor.OpenProject(@"C:\Documents and Settings\Michael\Skrivebord\PLC\Fatek server\fatek1.fcs");
        }
    }
}
