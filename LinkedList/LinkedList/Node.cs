using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
    class Node
    {
        public string name = "Regular Node";
        public int Value { get; set; }
        public Node Next { get; set; }

        public override string ToString()
        {
            if (this == null)
                return "NULL";
            else
            {
                return "Val " + this.Value + " Next " + this.Next + "Name :" + this.name+"\n"; 
            }
        }
    }
}
