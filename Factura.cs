using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseSieteEjercicioSiete
{
    class Factura
    {
        //Sobrecarga de metodos: Crear metodos de igual nombre que reciban distintos tipos de parametros.

        public DateTime Fecha;
        public int Numero;
        public float Importe;

        public Factura()
        {
            this.Fecha = DateTime.Now;
        }

        public Factura(int numero, float importe):this()
        {
            this.Numero = numero;
            this.Importe = importe;
        }

        public Factura(float importe, int numero):this(numero, importe)
        {

        }

        public Factura(DateTime FechaFecha)
        { }

        public Factura(int nume)
        { }

        public Factura(float impo)
        { }

        public Factura(DateTime FechaFe, int Numer)
        { }

        public static float operator +(Factura FacturaUno, Factura FacturaDos)
        {
            float resultado = FacturaUno + FacturaDos;

            return resultado;
        }

        public static bool operator !=(Factura FacturaUno, Factura FacturaDos)
        {
            return !(FacturaUno == FacturaDos);
        }

        public static bool operator ==(Factura FacturaUno, Factura FacturaDos)
        {
            bool resultado = FacturaUno == FacturaDos;
            return resultado;
        }

        public static float operator -(Factura FacturaUno, Cheque ChequeUno)
        {
            float resultado = FacturaUno.Importe - ChequeUno.Importe;

            return resultado;
        }

        public static Cheque operator +(Cheque ChequeUno, Factura FacturaUno)
        {
            return new Cheque(ChequeUno.Importe + FacturaUno.Importe);
        }
    }
}
