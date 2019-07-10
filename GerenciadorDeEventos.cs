using System;
using System.Collections.Generic;
using System.Text;

namespace StateMachine
{
    public class GerenciadorDeEventos : IGerenciadorDeEventos
    {
        Evento evento = new Evento();

        public void NovoEvento()
        {
            if (evento.Id == null)
            {
                evento.Estado = EnumEstado.NO;
            }
            else if(evento.Estado == EnumEstado.NO)
            {
                PrepararEnvio();
            }
        }

        public void PrepararEnvio()
        {
            if (evento.Estado == EnumEstado.NO)
            {
                evento.Estado = EnumEstado.AE;
            }else if(evento.Estado == EnumEstado.AE)
            {
                EnviarEvento();
            }
        }

        public void EnviarEvento()
        {
            switch (evento.Estado)
            {
                case EnumEstado.AE:
                    evento.Estado = EnumEstado.EV;
                    break;

            }
            if (evento.Estado == EnumEstado.AE)
            {
                evento.Estado = EnumEstado.EV;
            }
            else if(evento.Estado == EnumEstado.EV)
            {
                if(evento.Estado == EnumEstado.RE)
                {
                    ApontarErro();
                }else if(evento.Estado == EnumEstado.RS)
                {
                    ApontarRecebimento();
                }
                
            }
        }

        public void ApontarErro()
        {
            if (evento.Estado == EnumEstado.EV)
            {
                evento.Estado = EnumEstado.RE;
            }
            else
            {
                ApontarRecebimento();
            }
        }

        public void ApontarRecebimento()
        {
            if (evento.Estado == EnumEstado.)
            {
                evento.Estado = EnumEstado.RE;
            }
            else
            {
                ApontarRecebimento();
            }
        }

        public void ReenviarEvento()
        {
            throw new NotImplementedException();
        }
    }
}
