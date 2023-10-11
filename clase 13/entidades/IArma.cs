using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public interface IArma // se implementa no se hereda, permite AGRUPAR COMPORTAMIENTOS
    {
        public string Atacar();
    }
}
