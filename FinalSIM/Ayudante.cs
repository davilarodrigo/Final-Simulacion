using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSIM
{
    class Ayudante
    {
        public enum Estados { Libre, Ocupado }
        public Estados Estado { get; internal set; } = Estados.Libre;
        private enum Propositos { Comprar, Encargar, Retirar }
        private Propositos PropositoDelCLiente { get; set; } //es del cliente que esta siendo atendido

        public string obtenerPropositoCliente()
        {
            if (Estado == Estados.Libre) return "";
            return PropositoDelCLiente.ToString();
        }

        public int clientesEnCola { get; internal set; } = 0;

        private Controlador controlador;
        public Relojero relojero;

        public Ayudante(Controlador controlador, Relojero relojero)
        {
            this.controlador = controlador;
            this.relojero = relojero;
        }

        private void DeterminarPropositoDelCliente(Iteracion iteracion)
        {
            int probCompra = controlador.porcentajeLlegadaComprador * 10;
            int probEncargo = controlador.porcentajeLlegadaEncargo * 10;
            int probRetiro = controlador.porcentajeLlegadaRetiro * 10;

            if (!relojero.HayRelojesEnElNegocio())
            {
                probRetiro = 0;
            }

            if(PropositoDelCLiente==Propositos.Encargar && relojero.RelojesListos == 0)
            {
                probRetiro =0;
            }

            double rnd;
            int probTotal = probRetiro + probCompra + probEncargo;
            int random = GeneradorDistribuciones.UniformeAB(0, probTotal, out rnd);

            iteracion.rndPropositoCliente = rnd + "";

            if (random < probRetiro)
            {
                PropositoDelCLiente = Propositos.Retirar;
                return;
            }

            if (random < probCompra + probRetiro)
            {
                PropositoDelCLiente = Propositos.Comprar;
                return;
            }
            PropositoDelCLiente = Propositos.Encargar;
        }

        public void FinalizarAtencionCliente(Iteracion iteracion)
        {
            switch (PropositoDelCLiente)
            {
                case Propositos.Encargar:
                    relojero.AsignarNuevoRelojParaReparar(iteracion);
                    break;
                case Propositos.Retirar:
                    relojero.RetirarReloj(iteracion);
                    break;
                case Propositos.Comprar:
                    //no hacer nada
                    break;
            }
            if (clientesEnCola == 0)
            {
                Estado = Estados.Libre;
            }
            else
            {                
                clientesEnCola--;
                comenzarAtencion(iteracion);
            }
        }

        private void comenzarAtencion(Iteracion iteracion)
        {
            DeterminarPropositoDelCliente(iteracion);
            iteracion.propositoCliente = PropositoDelCLiente.ToString();

            double rnd;
            int tiempoMin = 0;
            int tiempoMax = 0;

            switch (PropositoDelCLiente)
            {
                case Propositos.Comprar:
                    tiempoMin = controlador.MinTiempoCompra;
                    tiempoMax = controlador.MaxTiempoCompra;
                    break;
                case Propositos.Encargar:
                    tiempoMin = controlador.MinTiempoEncargos;
                    tiempoMax = controlador.MaxTiempoEncargos;
                    break;
                case Propositos.Retirar:
                    tiempoMin = controlador.MinTiempoRetiros;
                    tiempoMax = controlador.MaxTiempoRetiros;
                    break;
            }

            int tiempoAtencion = GeneradorDistribuciones.UniformeAB(tiempoMin, tiempoMax, out rnd);
            iteracion.rndTiempoAtencion = rnd.ToString();
            iteracion.tiempoAtencion = tiempoAtencion.ToString();
            Evento FinAtencion = new Evento(Evento.Tipos.FinAtencionCliente, tiempoAtencion + controlador.HoraActual);
            controlador.AgregarEvento(FinAtencion);
        }

        public void NuevoClienteEnCola(Iteracion iteracion)
        {
            if (Estado == Estados.Libre)
            {
                //comenzar a atender cliente
                Estado = Estados.Ocupado;
                comenzarAtencion(iteracion);
            }

            else
            {
                clientesEnCola++;
            }


        }
    }
}