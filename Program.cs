using System;

namespace StateMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            ChavePrimaria chavePrimaria = new ChavePrimaria();

            Console.WriteLine("Digite o ID: ");
            chavePrimaria.IdEscrito = Console.ReadLine();
            Console.WriteLine("Digite o TR0: ");
            chavePrimaria.TR0 = Console.ReadLine();
            Console.WriteLine("R4010");
            chavePrimaria.CodigoDoEvento = Console.ReadLine();
            chavePrimaria.DataDeRegistro = DateTime.Now;
            Console.WriteLine("Competencia: ");
            chavePrimaria.Competencia = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("IDNumero");
            chavePrimaria.Id = int.Parse(Console.ReadLine());
            string dataLimpa = chavePrimaria.DataDeRegistro.ToString("yyyy/MM/dd");
            string horaLimpa = chavePrimaria.DataDeRegistro.ToString("HH:mm:ss");
            string competencia = chavePrimaria.Competencia.ToString("yyyy/MM");
            string PK = (
                chavePrimaria.IdEscrito + 
                chavePrimaria.TR0 + 
                chavePrimaria.CodigoDoEvento +
                dataLimpa +
                horaLimpa +
                competencia +
                chavePrimaria.Id);
            Console.Write(PK.Replace(":", "").Replace("/", "").Replace(" ", ""));
        }
    }
}
