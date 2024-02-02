using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace Lab3App
{
    public abstract class Treasure : Collectable
    {
        // Fields
        public int Score;

        // Constructor calls base class
        public Treasure(string description, int score) : base(description)
        {
            Score = score;
        }

        // Update the total score
        public void updateTotalScore()
        {
            Board.TotalScore += Score;
            Console.WriteLine("Total Score is updated to: " + Board.TotalScore);
        }

        // Add this object to the list, and update the total score
        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            updateTotalScore();
        }
    }
}
