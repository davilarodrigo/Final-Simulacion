using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSIM
{
    class Evento
    {
        public enum Tipos { LlegadaCliente, FinReparacion, FinAtencionCliente, FinSimulacion}
        public Tipos Tipo { get; private set; }
        public int HoraDelEvento { get; internal set; }
        
        public Evento(Tipos tipoEvento, int hora)
        {
            Tipo = tipoEvento;
            HoraDelEvento = hora;
        }

    }



}
