using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Validador.Models
{
    public class ValidadorBandeira
    {
        public string Bandeira { get; set; }

        public ValidadorBandeira(string bandeira)
        {
            Bandeira = bandeira;
        }

        public void Validador()
        {
            string visa = @"^4(\d{12}|\d{15}|\d{18})$";
            string master = @"^(5[1-5]\d{14}|2(2[2-9]\d{12}|[3-6]\d{13}|7(0\d{12}|1\d{12}|20\d{12})))$";
            string diners = @"^3(0[0-5]\d{11}|[68]\d{12})$";
            string amex = @"^3[47]\d{13}$";
            string discover = @"^(6011\d{12}|65\d{14}|64[4-9]\d{13})\d{0,3}$";
            string hiper = @"^(38\d{17}|60\d{14})$";
            string jcb = @"^35(2[8-9]\d{12}|[3-8]\d{13})$";
            string enroute = @"^2(149|014)\d{11}$";
            string aura = @"^(50\d{14})$";
            
            
            if(Regex.IsMatch(Bandeira,visa))
                Console.WriteLine("Visa");
            
            else if(Regex.IsMatch(Bandeira,master))
                Console.WriteLine("MaterCard");
            
            else if(Regex.IsMatch(Bandeira,diners))
                Console.WriteLine("Diners Club");

            else if(Regex.IsMatch(Bandeira,amex))
                Console.WriteLine("American Express");

            else if(Regex.IsMatch(Bandeira,discover))
                Console.WriteLine("Discover");

            else if(Regex.IsMatch(Bandeira,hiper))
                Console.WriteLine("HiperCard");

            else if(Regex.IsMatch(Bandeira,jcb))
                Console.WriteLine("JCB");

            else if(Regex.IsMatch(Bandeira,enroute))
                Console.WriteLine("EnRoute");

            else if(Regex.IsMatch(Bandeira,aura))
                Console.WriteLine("Aura");

            else
                Console.WriteLine("Cartão Desconhecido");
        }
    }
}




//    "Visa", new Regex(@"^4(\d{12}|\d{15}|\d{18})$"
//    "MasterCard", new Regex(@"^(5[1-5]\d{14}|2(2[2-9]\d{12}|[3-6]\d{13}|7(0\d{12}|1\d{12}|20\d{12})))$"
//    "Diners Club", new Regex(@"^3(0[0-5]\d{11}|[68]\d{12})$"
//    "American Express", new Regex(@"^3[47]\d{13}$"
//    "Discover", new Regex(@"^(6011\d{12}|65\d{14}|64[4-9]\d{13})\d{0,3}$"
//    "Hipercard", new Regex(@"^(38\d{17}|60\d{14})$"
//    "JCB", new Regex(@"^35(2[8-9]\d{12}|[3-8]\d{13})$"
//    "EnRoute", new Regex(@"^2(149|014)\d{11}$"
//    "Aura", new Regex(@"^(50\d{14})$"


