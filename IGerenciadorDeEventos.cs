using System;
using System.Collections.Generic;
using System.Text;

namespace StateMachine
{
    public interface IGeren5ciadorDeEventos
    {
        void NovoEvento();
        void PrepararEnvio();
        void EnviarEvento();
        void ApontarRecebimento();
        void ApontarErro();
        void ReenviarEvento();
    }
}
