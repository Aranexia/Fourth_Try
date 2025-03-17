using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account("Имя",1,12.2);
        }
    }

    class Account
    {
    
        public string Name { get; set; }

        public int Number { get; set; }

        public double Summ { get; set; }

        public Account(string name, int number, double summ) {
        Name = name;
        Number = number;
        Summ = summ;
        }
    
    }
}
