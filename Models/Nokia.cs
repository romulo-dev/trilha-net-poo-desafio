namespace DesafioPOO.Models
{
    
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string sistemaOperacional,
        string modelo, string imei, int memoria) : base(numero, "Symbian", modelo, imei, memoria)
        {
            

        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no Sistema Operacional {this.SistemaOperacional}");
        }
    }
}