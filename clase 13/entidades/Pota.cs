using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Pota : Item
    {
        public int cantidadUsos;

        public Pota(int cantidadUsos, string nombre):base(nombre)
        {
            this.cantidadUsos = cantidadUsos;
        }

        public override string Usar()
        {
            this.cantidadUsos--;
            return "Se incremento la vida";
        }
    }
}
