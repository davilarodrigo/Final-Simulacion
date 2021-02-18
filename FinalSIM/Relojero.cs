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

            if (Estado==Estados.Libre)
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
            int tiempoReparacion = GeneradorDistribuciones.UniformeAB(controlador.MinTiempoReparacion, controlador.MaxTiempoReparacion, out rnd);
            iteracion.rndTiempoReparacion = rnd.ToString();
            iteracion.tiempoReparacion = tiempoReparacion.ToString();
            Evento FinReparacion = new Evento(Evento.Tipos.FinReparacion, tiempoReparacion + controlador.HoraActual);
            controlador.AgregarEvento(FinReparacion);
        }

        public void RetirarReloj(Iteracion iteracion)
        {
            if (RelojesListos > 0)
            {
                if (controlador.clienteRetiraCualquierReloj)
                {
                    iteracion.relojEstaDisponible = "SI";
                    RelojesListos--;
                }
                else
                {
                    List<bool> relojes = new List<bool>();

                    for (int i = 0; i < RelojesListos; i++)
                    {
                        relojes.Add(true);
                    }

                    if (Estado == Estados.Ocupado)
                    {
                        //solo si esta ocupado hay relojes esperando
                        //si esta libre, no hay relojes esperando, sino estaria ocupado
                        for (int i = 0; i < RelojesPorReparar; i++)
                        {
                            relojes.Add(false);
                        }
                    }

                    Random random = new Random();
                    int index = random.Next(relojes.Count);
                    bool relojTerminado = (relojes[index]);


                    if (relojTerminado)
                    {
                        iteracion.relojEstaDisponible = "SI";
                        RelojesListos--;
                    }
                    else
                    {
                        iteracion.relojEstaDisponible = "NO";
                        controlador.relojesNoTerminadosATiempo++;
                    }

                }
            }
            else
            {
                iteracion.relojEstaDisponible = "NO";
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
            if (Estado == Estados.Ocupado)
            {//si el relojero esta ocupado, entonces hay por lo 
             //menos un reloj en el negocio (en el cual esta 
            //trabajando el relojero)
                return true;
            }

            //si el relojero esta desocupado, hay que ver si hay
            //relojes listos a ser retirados, si no, no hay ninguno

            if (RelojesListos > 0)
            {
                return true;
            }

            return false;
        }


    }
}
