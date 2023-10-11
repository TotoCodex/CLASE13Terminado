using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Arco : Arma
    {
        public int cantidadFlechas;

        public Arco(int daño, int durabilidad, string alcance, int cantidadFlechas) : base(daño,durabilidad,alcance)
        {
            this.cantidadFlechas = cantidadFlechas;
        }

        public override string Atacar()
        {
            this.cantidadFlechas--;
            return "fushhhhh";
        }
    }
}
