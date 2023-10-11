using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Mapa : Item
    {
        public string rareza;

        public Mapa(string rareza, string nombre): base(nombre)
        {
            this.rareza = rareza;
        }

        public override string Usar()
        {
            return $"Estas viendo {base.nombre}";
        }
    }
}
