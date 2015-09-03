using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaconSvr;

namespace ScadaTelas
{
    public partial class FormCrearProcesos : Form
    {
        protected Object Server;
        public FormCrearProcesos()
        {
            InitializeComponent();
        }

        private void FormCrearProcesos_Load(object sender, EventArgs e)
        {
            //Server = new FaconServerClass.OpenProject("");
            this.ocultarCubaPrincipal(false, false);
            this.ocultarCubaSecundaria(false, false);
        }
        // 
        // Controles de Cuba Primaria
        //
        private void ocultarCubaPrincipal(bool estado, bool estadoSecundarias)
        {
            this.CPLlenar.Enabled = estado;
            this.ocultarLlenar(estadoSecundarias);
            this.CPCalentar.Enabled = estado;
            this.ocultarCalentar(estadoSecundarias);
            this.CPEnfriar.Enabled = estado;
            this.ocultarEnfriar(estadoSecundarias);
            this.CPVaciar.Enabled = estado;
            this.ocultarVaciar(estadoSecundarias);
        }

        private void ocultarLlenar(bool estado)
        {
            this.CPLlenarNivel.Enabled = estado;
            this.CPLlenarTiempo.Enabled = estado;
        }

        private void ocultarCalentar(bool estado)
        {
            this.CPCalentarTemp.Enabled = estado;
            this.CPCaletarTiempo.Enabled = estado;
        }

        private void ocultarEnfriar(bool estado)
        {
            this.CPEnfriarTemp.Enabled = estado;
            this.CPEnfriarTiempo.Enabled = estado;
        }

        private void ocultarVaciar(bool estado)
        {
            this.CPVaciarTemp.Enabled = estado;
            this.CPVaciarTiempo.Enabled = estado;
        }

        private void CubaPrincipal_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CubaPrincipal.Checked)
            {
                this.ocultarCubaPrincipal(true, false);
            }
            else
            {
                this.ocultarCubaPrincipal(false, false);
            }
        }

        private void CPLlenar_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CPLlenar.Checked)
            {
                this.ocultarLlenar(true);
            }
            else
            {
                this.ocultarLlenar(false);
            }
        }

        private void CPCalentar_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CPCalentar.Checked)
            {
                this.ocultarCalentar(true);
            }
            else
            {
                this.ocultarCalentar(false);
            }
        }

        private void CPEnfriar_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CPEnfriar.Checked)
            {
                this.ocultarEnfriar(true);
            }
            else
            {
                this.ocultarEnfriar(false);
            }
        }

        private void CPVaciar_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CPVaciar.Checked)
            {
                this.ocultarVaciar(true);
            }
            else
            {
                this.ocultarVaciar(false);
            }
        }
        // 
        // Controles de Cubas Secundarias
        // 
        public void ocultarCubaSecundaria(bool estado, bool estadoSecundarias)
        {
            this.CSIntroduccion.Enabled = estado;
            this.ocultarIntroducionCubaSeundaria(estadoSecundarias);
            this.CSLavado.Enabled = estado;
            this.ocultarLavadoCubaSeundaria(estadoSecundarias);
            this.CSLlenado.Enabled = estado;
            this.ocultarLlenadoCubaSecundaria(estadoSecundarias);
        }

        private void ocultarIntroducionCubaSeundaria(bool estado)
        {
            this.CSIntroduccionTiempo.Enabled = estado;
            this.CSIntroduccionVolumen.Enabled = estado;
        }

        private void ocultarLavadoCubaSeundaria(bool estado)
        {
            this.CSLavadoCantidad.Enabled = estado;
            this.CSLavadoDescarga.Enabled = estado;
        }

        private void ocultarLlenadoCubaSecundaria(bool estado)
        {
            this.CSLlenadoMaquina.Enabled = estado;
            this.CSLlenadoRed.Enabled = estado;
        }

        private void Cuba1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Cuba1.Checked)
            {
                this.Cuba2.Enabled = false;
                this.ocultarCubaSecundaria(true, false);
            }
            else
            {
                this.Cuba2.Enabled = true;
                this.ocultarCubaSecundaria(false, false);
            }
        }

        private void Cuba2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Cuba2.Checked)
            {
                this.Cuba1.Enabled = false;
                this.ocultarCubaSecundaria(true, false);
            }
            else
            {
                this.Cuba1.Enabled = true;
                this.ocultarCubaSecundaria(false, false);
            }
        }

        private void CSLlenado_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CSLlenado.Checked)
            {
                this.ocultarLlenadoCubaSecundaria(true);
            }
            else
            {
                this.ocultarLlenadoCubaSecundaria(false);
            }
        }

        private void CSLavado_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CSLavado.Checked)
            {
                this.ocultarLavadoCubaSeundaria(true);
            }
            else
            {
                this.ocultarLavadoCubaSeundaria(false);
            }
        }

        private void CSIntroduccion_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CSLlenado.Checked)
            {
                this.ocultarLlenadoCubaSecundaria(true);
            }
            else
            {
                this.ocultarLlenadoCubaSecundaria(false);
            }
        }
    }
}
