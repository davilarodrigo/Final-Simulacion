using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSIM
{
    class Controlador
    {        
        public int MinTiempoLlegadaCliente = 13;
        public int MaxTiempoLlegadaCliente = 17;
        public int MinTiempoAtencionCompra = 6;
        public int MaxTiempoAtencionCompra = 10;
        public int MinTiempoAtencionEntregasYRetiros = 6;
        public int MaxTiempoAtencionEntregasYRetiros = 10;
        public int MinTiempoReparacion = 18;
        public int MaxTiempoReparacion = 22;
        public int minutosDeSimulacion = 720;

        enum Eventos { Compra, Retiro, Entrega, FinReparacion }
        public int HoraActual { get; internal set; } = 0;

        public List<Iteracion> EjercutarSimulacion()
        {
            AgregarEvento(new Evento(Evento.Tipos.FinSimulacion, minutosDeSimulacion));

            List<Iteracion> iteraciones = new List<Iteracion>();
            iteraciones.Add(new Iteracion()
            {
                evento = "Inicio",
                hora = 0
            });

            GenerarProximaLlegada();

            while (HoraActual < minutosDeSimulacion)
            {
                Evento evento = ObtenerProximoEvento();
                HoraActual = evento.HoraDelEvento;

                iteraciones.Add(new Iteracion()
                {
                    evento = evento.Tipo.ToString(),
                    hora = HoraActual
                });
            }

            return iteraciones;

        }

        private Evento ObtenerProximoEvento()
        {
            Evento evento = ProximosEventos[0];
            ProximosEventos.RemoveAt(0);
            return evento;
        }


        private void GenerarProximaLlegada()
        {
            int tiempoLlegada = GeneradorDistribuciones.UniformeAB(MinTiempoLlegadaCliente, MaxTiempoLlegadaCliente);
            Evento Llegada = new Evento(Evento.Tipos.LlegadaCliente, tiempoLlegada+HoraActual);
            AgregarEvento(Llegada);
        }

        private void AgregarEvento(Evento evento)
        {
            foreach (var item in ProximosEventos)
            {
                if (evento.HoraDelEvento < item.HoraDelEvento)
                {
                    int index = ProximosEventos.IndexOf(item);
                    ProximosEventos.Insert(index, evento);
                    return;
                }
            }
            //los eventos que se agreguen aca en realidad no van a llegar nunca, porque antes se va a dar el fin de la simulacion
            ProximosEventos.Add(evento);
        }

        private List<Evento> ProximosEventos = new List<Evento>();

        public void main()
        {

        }
    }
}
