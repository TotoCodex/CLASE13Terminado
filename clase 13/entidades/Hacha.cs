using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Hacha: Arma, IItem
    {
        public int cantidadHojas;

        public Hacha(int daño, int durabilidad, string alcance, int cantidadHojas):base (daño,durabilidad,alcance)
        {
            this.cantidadHojas = cantidadHojas;
        }

        public override string Atacar()
        {
            return "waaachaaazzzz";
        }

        public string Usar()
        {
            return "Talando...";
        }
    }
}
