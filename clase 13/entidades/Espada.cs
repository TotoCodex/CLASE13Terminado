using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Espada : Arma
    {
        public int filo;

        public Espada(int daño, int durabilidad, string alcance, int filo):base (daño,durabilidad,alcance)
        {
            this.filo = filo;
        }

        public override string Atacar()
        {
            this.durabilidad -= this.filo;
            return "zaaaaaaz";
        }
    }
}
