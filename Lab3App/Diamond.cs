using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class Diamond : Treasure
    {
        // Constructor calls base class (parent class)
        public Diamond(string description, int score) : base(description, score) { }

        // Display implemented: prompt for user
        public override void Display()
        {
            Console.WriteLine("Diamond" + Description + " is displayed");
        }
    }
}
