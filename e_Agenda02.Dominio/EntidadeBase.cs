using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda02.Dominio
{
    public abstract class EntidadeBase
    {
        public int Numero { get; set; }
        public abstract string Validar();
    }
}
