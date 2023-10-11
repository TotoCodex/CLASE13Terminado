using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Pistola : Arma
    {
        public string modelo;
        public int municion;

        public Pistola(int daño, int durabilidad, string alcance, string modelo):base(daño, durabilidad, alcance)
        {
            this.modelo = modelo;
            this.municion = 100;
        }

        public override string Atacar()
        {
            this.municion--;
            return "Pew pew";

        }
    }
}
