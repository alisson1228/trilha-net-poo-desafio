namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            _modelo = modelo;
            _imei = imei;
            _memoria = memoria;
        }

        private string _modelo;
        private string _imei;
        private int _memoria;
        public string Numero { get; set; } 
        public string Modelo => _modelo;
        public string IMEI => _imei;
        public int Memoria => _memoria;

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void SobreDispositivo()
        {
            Console.WriteLine($"Numero: {Numero}\nModelo: {_modelo}\nIMEI: {_imei}\nMemoria: {_memoria}");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}