using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public abstract class Item: IItem
    {
        public string nombre;

        protected Item(string nombre)
        {
            this.nombre = nombre;
        }

        public abstract string Usar();
    }
}
