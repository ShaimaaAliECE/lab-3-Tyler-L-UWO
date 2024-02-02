using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public abstract class Collectable : Displayable
    {
        // Fields
        public string Description;
        public CollectionBoard Board;

        // Constructor
        public Collectable(string description)
        {
            Description = description;
        }

        // Display Information
        public abstract void Display();

        // Add object to the line, prompt the user
        public virtual void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine(Description + " Collected, Congrats!!!!");
        }
    }
}
