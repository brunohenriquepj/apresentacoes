using System;

namespace Solid.HandsOn.ConsoleApp.ISP.Impressora.Violacao
{
    public class ImpressoraMultiFuncional : IImpressora
    {
        public void Imprimir()
        {
            Console.WriteLine("Imprimindo...");
        }

        public void Digitalizar()
        {
            Console.WriteLine("Digitalizando...");
        }

        public void FazerCopia()
        {
            Console.WriteLine("Fazendo copia...");
        }
    }
}