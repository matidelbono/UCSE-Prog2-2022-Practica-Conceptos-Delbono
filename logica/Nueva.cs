using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
   
    public static class ExtensionTexto
    {
        public static int RetornarCantidadPalabras(this string texto)
        {
            string letra;
            int palabras = 0;
            for (int i = 0; i < texto.Length; i++)
            {

                letra = texto.Substring(i, 1);
                if (letra == "" || letra == ".")
                {
                    palabras++;
                }
            }
            return palabras;
        }
    }

    public static class Extensiones
    {
        public static decimal RetornarDiferenciaEnMinutos(this DateTime f1, DateTime f2)
        {
            decimal DiferenciaEnSegundos = f1.Second - f2.Second;
            return DiferenciaEnSegundos / 60;
        }


        public static decimal CalcularPromedio(this List<int> Enteros)
        {
            int Sum = 0;
            int Cont = 0;
            decimal prom = 0;
            foreach (var item in Enteros)
            {
                Sum = Sum + item;
                Cont += 1;
            }
            prom = Sum / Cont;
            return prom;
        }
        public static int DevolverOperacion(this List<int> Enteros)
        {
            int SumaPares = 0;
            int RestaImpares = Enteros.Max();
            foreach (var item in Enteros)
            {
                if (item % 2 == 0)
                    SumaPares = SumaPares + item;
                else
                    RestaImpares = RestaImpares - item;
            }
            int multiplicacion = RestaImpares * SumaPares;
            return multiplicacion;
        }
        public static DateTime RetornarEnFormato(string fecha)
        {
            string formato = "dd/mm/yy";
            DateTime TextoEnFechaYHora = DateTime.ParseExact(fecha, formato, CultureInfo.InvariantCulture);
            return TextoEnFechaYHora;

        }
        public static string InvertirTexto(this string Texto)
        {
            char[] ArreglodeLetras = Texto.ToCharArray();
            Array.Reverse(ArreglodeLetras);
            return new string(ArreglodeLetras);
        }
        public static string SepararStringConChar(this string[] frase, char separador)
        {
            string FraseUnida = string.Join("separador", separador, frase);
            return FraseUnida;
        }
        public static bool EsCuit(this string CUIT, out string CUITLimpio)
        {
            const string RegexPatternToExtractNumbers = @"\d+";
            const string RegexPatternCuit = @"^(20|2[3-7]|30|3[3-4])(\d{8})(\d)$";
            CUITLimpio = string.Empty;
            Regex rx = new Regex(RegexPatternToExtractNumbers, RegexOptions.Compiled);
            var Matches = rx.Matches(CUIT);
            foreach (Match match in Matches)
            {

                CUITLimpio = string.Concat(CUITLimpio, match.Value);
            }
            rx = new Regex(RegexPatternCuit, RegexOptions.Compiled);
            return rx.Match(CUITLimpio).Success;

        }
        public static bool EsCorreo(this String Correo)
        {
            string Expresion;
            Expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(Correo, Expresion))
            {
                if (Regex.Replace(Correo, Expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static int RestaEnteros(this int n1, int n2)
        {
            return n2 - n1;
        }
    }
    public static class ConvertirGrados
    {
        public static double FarenheitACelsius(this double Farenheit)
        {
            double Celsius = Farenheit / 2.12;
            return Celsius;
        }
        public static double CelsiusAFarenheit(this double Celsius)
        {
            double Farenheit = Celsius * 2.12;
            return Farenheit;
        }
        

}
    public static class Rectangulo
    {
        public static int CalcularPerimetro(int Base, int Altura)
        {
            return (Base * 2) + (Altura * 2);
        }
        public static int CalcularArea (int Base, int Altura)
        {
            return Base * Altura;
        }
    }
}
