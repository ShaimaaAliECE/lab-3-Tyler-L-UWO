using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class Axe : Tool
    {
        // Constructor calls base class constructor
        public Axe(string description) : base(description){}

        // Display implemeted: prompt for user
        public override void Display()
        {
            Console.WriteLine("Axe " + Description + " is displayed");
        }

        // 'Use' this object (prompt the user)
        public override void DoAction()
        {
            Console.WriteLine("Axe is Used");
        }
    }
}
