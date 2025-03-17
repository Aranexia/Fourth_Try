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
            Account acc = new Account();
            acc.Name = "Имя";
            acc.Number =  1;
            acc.Summ = 12.12;
        }
    }

    class Account
    {
    
        public string Name { get; set; }

        public int Number { get; set; }

        public double Summ { get; set; }
    
    }
}
