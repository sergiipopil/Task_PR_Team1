using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_PR_Team1.Classes
{
    internal class PersonalInfo
    {
        private string _name;
        private string _surname;

        public PersonalInfo(string name, string surname) { 
            _name= name;
            _surname= surname;
        }
        public string GetUserInfo() {
            var fullName = $"Full user name: {_name} {_surname}";
            return fullName;
        }
    }
}
