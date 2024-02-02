using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class MagicWand : Tool
    {
        // Constructor calls base class constructor
        public MagicWand(string description) : base(description) { }

        // Display implemented: prompt for user
        public override void Display()
        {
            Console.WriteLine("MagicWand " + Description + " is displayed");
        }

        // 'Use' this object (prompt the user)
        public override void DoAction()
        {
            Console.WriteLine("MagicWand is used");
        }
    }
}
