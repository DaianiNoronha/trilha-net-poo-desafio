namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imai, string memoria)
            : base(numero, modelo, imai, memoria)
        {
            // Nenhum código adicional necessário no construtor da classe filha
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no smartphone Nokia.");
        }
    }
}