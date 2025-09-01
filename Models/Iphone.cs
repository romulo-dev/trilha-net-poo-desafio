namespace DesafioPOO.Models
{
    
    public class Iphone : Smartphone
    {

        public Iphone(string numero, string sistemaOperacional,
        string modelo, string imei, int memoria) : base(numero, "IOS", modelo, imei, memoria)
        {
            

        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no Sistema Operacional IOS");
        }

        public void AcessarSiri()
        {
            Console.WriteLine("Siri ativada. Como posso ajudar?");
        }
    }
}