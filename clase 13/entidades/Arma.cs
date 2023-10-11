using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public abstract class Arma: IArma
    {
        public int daño;
        public int durabilidad;
        public string alcance;

        public Arma(int daño, int durabilidad, string alcance)
        {
            this.daño = daño;
            this.durabilidad = durabilidad;
            this.alcance = alcance;
        }

        public abstract string Atacar();
    }
}
