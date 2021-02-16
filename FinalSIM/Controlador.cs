using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSIM
{
    class Controlador
    {
        public int MinTiempoCompra = 6;
        public int MaxTiempoCompra = 10;
        public int MinTiempoEncargos = 3;
        public int MaxTiempoEncargos = 3;
        public int MinTiempoRetiros = 3;
        public int MaxTiempoRetiros = 3;

        public int MinTiempoLlegadaCliente = 13;
        public int MaxTiempoLlegadaCliente = 17;
        public int MinTiempoReparacion = 18;
        public int MaxTiempoReparacion = 22;

        public int porcentajeLlegadaComprador=45;
        public int porcentajeLlegadaEncargo=25;
        public int porcentajeLlegadaRetiro=30;

        public int minutosDeSimulacion = 720;
        public int relojesInicialmenteReparados = 5;

        public bool clienteRetiraCualquierReloj=true;

        public int relojesNoTerminadosATiempo=0;
        public int colaMaximaDeClientes = 0;

        Ayudante ayudante;
        Relojero relojero;

        private List<Evento> ProximosEventos = new List<Evento>();
        private List<Iteracion> iteraciones = new List<Iteracion>();
        enum Eventos { Compra, Retiro, Entrega, FinReparacion }
        public int HoraActual { get; set; } = 0;

        public List<Iteracion> EjercutarSimulacion()
        {
            AgregarEvento(new Evento(Evento.Tipos.Inicio, 0));
            AgregarEvento(new Evento(Evento.Tipos.FinSimulacion, minutosDeSimulacion));

            relojero = new Relojero(this);
            ayudante = new Ayudante(this,relojero);

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
                        ayudante.NuevoClienteEnCola(iteracion);
                        break;
                    case Evento.Tipos.FinReparacion:
                        relojero.FinalizarReparacion(iteracion);
                        break;
                    case Evento.Tipos.FinAtencionCliente:
                        ayudante.FinalizarAtencionCliente(iteracion);
                        break;
                    case Evento.Tipos.Inicio:
                        GenerarProximaLlegada(iteracion);
                        break;
                    case Evento.Tipos.FinSimulacion:
                        break;
                }

                CargarHorasDeProximosEventosEnIteracion(iteracion);
                iteracion.estadoAyudante = ayudante.Estado.ToString();
                iteracion.colaDeClientes = ayudante.clientesEnCola + "";

                if (colaMaximaDeClientes < ayudante.clientesEnCola)
                {
                    colaMaximaDeClientes = ayudante.clientesEnCola;
                }

                iteracion.estadoRelojero = relojero.Estado.ToString();
                iteracion.colaRelojesPorReparar = relojero.RelojesPorReparar + "";
                iteracion.colaRelojesListos= relojero.RelojesListos+ "";
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

        public void AgregarEvento(Evento evento)
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

