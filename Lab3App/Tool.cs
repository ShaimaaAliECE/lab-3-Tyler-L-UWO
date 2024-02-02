using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public abstract class Tool : Collectable
    {
        // Constructor calls base class constructor
        public Tool(string description) : base(description) { }

        // 'Use' this object (prompt the user), to be implemeted in child classes
        public abstract void DoAction();

        // Add this object to the list, and 'Use' this object by calling DoAction()
        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            DoAction();
        }
    }
}
