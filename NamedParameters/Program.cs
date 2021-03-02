using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameters
{
    class Program
    {
        static void GetCohortDetails(string Cohort, int Genc, string Mode, string Track, string Current)
        {
            Console.WriteLine($"It is {Cohort} with {Genc} GenCs undergoing training for {Track} thru {Mode}.The current module of training is {Current}");
        }
        static void Main(string[] args)
        {
            GetCohortDetails(Cohort: "ADM20DF003", Mode: "OBL", Genc: 21, Track: ".Net", Current: "C#Advance");
            Console.ReadLine();
        }

    }
}
