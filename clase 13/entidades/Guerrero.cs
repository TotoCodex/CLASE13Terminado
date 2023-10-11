namespace entidades
{
    public class Guerrero
    {
        public IArma armaActual;
        public IItem itemEquipado;

        public string AtacarConArma()
        {
            return armaActual.Atacar();
        }

        public void CambiarArma(IArma armaNueva)
        {
            this.armaActual = armaNueva;
        }

        public string UsarItem()
        {
            return this.itemEquipado.Usar();
        }

        public void CambiarItem(IItem itemNuevo)
        {
            this.itemEquipado = itemNuevo;
        }
    }
}