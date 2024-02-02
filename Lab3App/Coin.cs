using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class Coin : Treasure
    {
        // Fields
        public int Value;

        // Constructor calls base class constructor, and set fields not in base class
        public Coin(string description, int score, int value) : base(description, score)
        {
            Value = value;
        }

        // Display coin info to user
        public override void Display()
        {
            Console.WriteLine("Coin " + Description + " is displayed");
        }

        // Update the total value
        public void updateTotalValue()
        {
            Board.TotalValue += Value;
            Console.WriteLine("Total Value is updated to: " + Board.TotalValue);
        }

        // Add the coin to the list
        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            updateTotalValue();
        }
    }
}
