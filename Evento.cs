using System;
using System.Collections.Generic;
using System.Text;

namespace StateMachine
{
    public class Evento
    {
        public string Id { get; set; }
        public EnumEstado Estado { get; set; }
    }
}
