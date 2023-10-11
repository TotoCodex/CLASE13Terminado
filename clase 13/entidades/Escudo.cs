using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Escudo : Item
    {
        public string material;

        public Escudo(string material, string nombre): base(nombre)
        {
            this.material = material;
        }
        public override string Usar()
        {
            return "Daño bloqueado";
        }
    }
}
