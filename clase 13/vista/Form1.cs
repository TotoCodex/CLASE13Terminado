
using entidades;

namespace vista
{
    public partial class Form1 : Form
    {
        public Guerrero guerrero;
        public Hacha hacha;
        public Espada espada;
        public Pistola pistola;
        public Arco arco;
        public Pota pota;
        public Escudo escudo;
        public Mapa mapa;
        public Cuchillo cuchillo;
        private string armaActual;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.guerrero = new Guerrero();
            this.hacha = new Hacha(15,100,"medio",2);
            this.espada = new Espada(10,90,"corto",3);
            this.pistola = new Pistola(25,100,"largo","9mm");
            this.arco = new Arco(20,100,"largo",100);
            this.pota = new Pota(10, "curacion");
            this.escudo = new Escudo("madera", "Escudon");
            this.mapa = new Mapa("Comun","Pepito Castle");
            this.cuchillo = new Cuchillo(100,"Daga");
        }

        private void btnEspada_Click(object sender, EventArgs e)
        {
            this.guerrero.CambiarArma(this.espada);
            this.lblArmaEquipada.Visible = true;
            this.armaActual = "Espada";
            this.lblArmaEquipada.Text = this.armaActual;
        }


        private void btnArco_Click(object sender, EventArgs e)
        {
            this.guerrero.CambiarArma(this.arco);
            this.lblArmaEquipada.Visible = true;
            this.armaActual = "Arco";
            this.lblArmaEquipada.Text = this.armaActual;
        }

        private void btnPistola_Click(object sender, EventArgs e)
        {
            this.guerrero.CambiarArma(this.pistola);
            this.lblArmaEquipada.Visible = true;
            this.armaActual = "Pïstola";
            this.lblArmaEquipada.Text = this.armaActual;
        }

        private void btnHacha_Click(object sender, EventArgs e)
        {
            guerrero.CambiarArma(this.hacha);
            this.lblArmaEquipada.Visible = true;
            this.armaActual = "Hacha";
            this.lblArmaEquipada.Text = this.armaActual;

        }

        private void btnAtacar_Click(object sender, EventArgs e)
        {
            this.lblAccion.Text = this.guerrero.AtacarConArma();
        }

        private void btnUsar_Click(object sender, EventArgs e)
        {
            this.lblUso.Text = this.guerrero.UsarItem();
            
        }

        private void btnPota_Click(object sender, EventArgs e)
        {
            this.guerrero.CambiarItem(this.pota);
            this.lblItemActual.Text = "Pota";

        }

        private void btnMapa_Click(object sender, EventArgs e)
        {
            this.guerrero.CambiarItem(this.mapa);
            this.lblItemActual.Text = "Mapa";
        }

        private void btnEscudo_Click(object sender, EventArgs e)
        {
            this.guerrero.CambiarItem(this.escudo);
            this.lblItemActual.Text = "Escudo";
        }

        private void btnCuchillo_Click(object sender, EventArgs e)
        {
            this.guerrero.CambiarItem(this.cuchillo);
            this.lblItemActual.Text = "Cuchillo";
        }

        private void btnAtCuchillo_Click(object sender, EventArgs e)
        {
            this.guerrero.CambiarArma(this.pistola);
            this.lblArmaEquipada.Visible = true;
            this.armaActual = "Cuchillo";
            this.lblArmaEquipada.Text = this.armaActual;
        }

        private void btnUsHACHA_Click(object sender, EventArgs e)
        {
            this.guerrero.CambiarItem(this.hacha);
            this.lblItemActual.Text = "Hacha";
            


        }
    }
}