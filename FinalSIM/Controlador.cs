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

        private List<Evento> ProximosEventos = new List<Evento>();
        private List<Iteracion> iteraciones = new List<Iteracion>();
        enum Eventos { Compra, Retiro, Entrega, FinReparacion }
        public int HoraActual { get; internal set; } = 0;

        public List<Iteracion> EjercutarSimulacion()
        {
            AgregarEvento(new Evento(Evento.Tipos.Inicio, 0));
            AgregarEvento(new Evento(Evento.Tipos.FinSimulacion, minutosDeSimulacion));
                        
            while (HoraActual < minutosDeSimulacion)
            {
                Evento evento = ObtenerProximoEvento();

                HoraActual = evento.HoraDelEvento;
                Iteracion iteracion = new Iteracion()
                {
                    evento = evento.Tipo.ToString(),
                    hora = HoraActual
                };

                switch (evento.Tipo)
                {
                    case Evento.Tipos.LlegadaCliente:
                        GenerarProximaLlegada(iteracion);
                        break;
                    case Evento.Tipos.FinReparacion:
                        break;
                    case Evento.Tipos.FinAtencionCliente:
                        break;
                    case Evento.Tipos.Inicio:
                        GenerarProximaLlegada(iteracion);
                        break;
                    case Evento.Tipos.FinSimulacion:
                        break;
                }

                CargarHorasDeProximosEventosEnIteracion(iteracion);
                iteraciones.Add(iteracion);
            }

            return iteraciones;

        }

        private void CargarHorasDeProximosEventosEnIteracion(Iteracion iteracion)
        {
            //esta funcion asume que en la lista de proximos eventos hay solo uno de cada tipo
            //si ese no es el caso funciona igual, pero es menos eficiente

            for (int i = ProximosEventos.Count - 1; i >= 0; i--)
            {
                switch (ProximosEventos[i].Tipo)
                {
                    case Evento.Tipos.LlegadaCliente:
                        iteracion.proximaLlegada = ProximosEventos[i].HoraDelEvento.ToString();
                        break;
                    case Evento.Tipos.FinReparacion:
                        iteracion.proximoFinReparacion = ProximosEventos[i].HoraDelEvento.ToString();
                        break;
                    case Evento.Tipos.FinAtencionCliente:
                        iteracion.proximoFinAtencion = ProximosEventos[i].HoraDelEvento.ToString();
                        break;
                }
            }
        }


        private Evento ObtenerProximoEvento()
        {
            Evento evento = ProximosEventos[0];
            ProximosEventos.RemoveAt(0);
            return evento;
        }

        private void GenerarProximaLlegada(Iteracion iteracion)
        {
            double rnd;
            int tiempoLlegada = GeneradorDistribuciones.UniformeAB(MinTiempoLlegadaCliente, MaxTiempoLlegadaCliente, out rnd);
            Evento Llegada = new Evento(Evento.Tipos.LlegadaCliente, tiempoLlegada + HoraActual);
            AgregarEvento(Llegada);

            iteracion.randomLlegada = rnd.ToString();
            iteracion.tiempoLlegada = tiempoLlegada.ToString();
        }

        void AgregarEvento(Evento evento)
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

    }



}

