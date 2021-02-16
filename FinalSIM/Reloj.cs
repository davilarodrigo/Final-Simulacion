using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSIM
{
    class Reloj
    {
        public int Id { get ; internal set; }
        private static int ultimoId = 0;        

        public enum Estados { EsperandoReparacion, EnReparacion, Reparado}
        public Estados estado;

        public Reloj()
        {
            ultimoId++;
            Id = ultimoId;
            estado = Estados.EsperandoReparacion;
        }
    }
}
