using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSIM
{    
    class Relojero
    {
        public int RelojesListos { get; private set; } = 0;
        public int RelojesPorReparar { get; private set; } = 0;
        public enum Estados { Libre, Ocupado }
        public Estados Estado { get; internal set; } = Estados.Libre;

        public Relojero(Controlador controlador)
        {
            RelojesListos = controlador.relojesInicialmenteReparados;
        }

        public void AsignarNuevoRelojParaReparar(Iteracion iteracion)
        {
            if (RelojesPorReparar == 0)
            {
                Estado = Estados.Ocupado;
            }
            else
            {
                RelojesPorReparar++;
            }
        }

        public void FinalizarReparacion(Iteracion iteracion)
        {

        }

        public int TotalDeRelojesEnElNegocio()
        {
            if (Estado == Estados.Ocupado)
            {
                //en este caso, hay un reloj mas de lo que aparece en las colas (el que tiene el relojero)
                return 1 + RelojesListos + RelojesPorReparar;
            }
            else
            {
                return RelojesListos + RelojesPorReparar;
            }
        }

        public bool HayRelojesEnElNegocio()
        {
            return (HayRelojesEnReparacion() || HayRelojesListosParaRetirar());
        }

        public bool HayRelojesEnReparacion()
        {
            return (RelojesPorReparar != 0 || Estado==Estados.Ocupado);
        }

        public bool HayRelojesListosParaRetirar()
        {
            return (RelojesListos != 0);
        }


    }
}
