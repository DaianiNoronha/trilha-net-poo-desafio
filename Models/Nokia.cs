namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, string memoria)
            : base(numero, modelo, imei, memoria)
        {
            // Nenhum código adicional necessário no construtor da classe filha
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no smartphone Nokia.");
        }
    }
}