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
        Controlador controlador;

        public Relojero(Controlador controlador)
        {
            this.controlador = controlador;
            RelojesListos = controlador.relojesInicialmenteReparados;
        }

        public void AsignarNuevoRelojParaReparar(Iteracion iteracion)
        {
    
            if (RelojesPorReparar == 0)
            {
                Estado = Estados.Ocupado;
                ComenzarReparacion(iteracion);
            }
            else
            {
                RelojesPorReparar++;
            }
        }

        private void ComenzarReparacion(Iteracion iteracion)
        {            
            double rnd;
            int tiempoReparacion= GeneradorDistribuciones.UniformeAB(controlador.MinTiempoReparacion, controlador.MaxTiempoReparacion, out rnd);
            iteracion.rndTiempoReparacion = rnd.ToString();
            iteracion.tiempoReparacion= tiempoReparacion.ToString();
            Evento FinReparacion= new Evento(Evento.Tipos.FinReparacion, tiempoReparacion+ controlador.HoraActual);
            controlador.AgregarEvento(FinReparacion);
        }

        public void RetirarReloj(Iteracion iteracion)
        {
            if (RelojesListos > 0)
            {
                if (controlador.clienteRetiraCualquierReloj)
                {
                RelojesListos--;
                }
                else
                {
                    double rnd;
                    int totalRelojes = RelojesListos + RelojesPorReparar + 1;
                    int relojElegido = GeneradorDistribuciones.UniformeAB(0, totalRelojes, out rnd);

                    if (relojElegido < RelojesListos)
                    {                        //el reloj esta listo 
                        RelojesListos--;
                    }
                    else
                    {                        //el reloj no esta listo
                        controlador.relojesNoTerminadosATiempo++;
                    }

                    //aca hay una parte complicada
                }
            }
            else
            {
                controlador.relojesNoTerminadosATiempo++;
            }
        }

        public void FinalizarReparacion(Iteracion iteracion)
        {
            RelojesListos++;

            if (RelojesPorReparar == 0)
            {
                Estado = Estados.Libre;
            }
            else
            {
                RelojesPorReparar--;
                ComenzarReparacion(iteracion);
            }
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
