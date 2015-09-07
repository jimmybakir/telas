using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScadaTelas.Modelo
{
    public abstract class Funcion
    {
        public static int NIVELBAJO = 0, NIVELMEDIO = 1, NIVELALTO = 2;
        public static string MLLENAR="M200", MLLENADO="M204", MNIVELES="M203", MRECIRCULACION="M208";
        public static string RNIVEL = "R60", RTCIRCULACION = "R62"; 
        string nombre;
        int idFuncion;
        bool marcaPrincipal;
    }

    public class Llenar : Funcion
    {
        bool hNiveles = false, hRecirculacion = false;
        int VNivel = -1, tiempoRecirculacion = 0;
        public Llenar(bool habilitarLlenado, bool habilitarNivel, int nivel, bool habilitarRecirculacion, int tiempoRecirculacion)
        {
            this.hNiveles = habilitarNivel;
            this.VNivel = nivel;
            this.hRecirculacion = habilitarRecirculacion;
            this.tiempoRecirculacion = tiempoRecirculacion;
        }
        public bool validarNivel(int nivel)
        {
            if ((nivel >= 0) & (nivel <=3)){
                return true;
            }
            return false;
        }
    }
}
