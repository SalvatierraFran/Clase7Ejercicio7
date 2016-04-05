using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseSieteEjercicioSiete
{
    class Dato
    {
        public int Numero;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Factura Factura1 = new Factura(20, 50.60f);

            Factura Factura2 = new Factura(50.60f, 20);

            //float resultado = Factura1 + Factura2;

            /*if (Factura1 == Factura2)
            {
                Console.Write("Tienen el mismo importe");
            }*/

            //Dato A = new Dato();
            //Dato B = new Dato();

            //A.Numero = 22;
            //B.Numero = 30;

            //A = B;

            //A.Numero = 10;

            float resultado = Factura1.Importe + Factura2.Importe;

            if (Factura1.Importe == Factura2.Importe)
            {
                Console.Write("Tienen el mismo importe");
            }

            Cheque UnCheque = new Cheque(150.50f);

            float ResultadoCheque = Factura1.Importe - UnCheque.Importe;

            UnCheque.Importe = UnCheque.Importe + Factura1.Importe;

            UnCheque = UnCheque + Factura1;

            Console.ReadKey();
        }
    }
}
