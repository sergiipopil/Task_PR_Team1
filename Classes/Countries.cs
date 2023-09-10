using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_PR_Team1.Classes
{
    internal class Countries
    {

        public string NameCountry { get; set; }
        public string CapitalCountry { get; set; }

        public Countries(string nameCountry, string capitalCountry)
        {
            NameCountry = nameCountry;
            CapitalCountry = capitalCountry;
        }

        public void GiveCountry(string nameCountry, string capitalCountry)
        {
            Console.WriteLine($"Your favorite country is {nameCountry} and capital this country is {capitalCountry}!");
        }
    }
}
