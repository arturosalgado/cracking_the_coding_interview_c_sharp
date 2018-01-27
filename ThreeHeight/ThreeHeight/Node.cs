using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThreeHeight
{
    class Node
    {

        public Node left { get; set; }

        public Node right { get; set; }

        public string Value {get; set;}

        public Node(string Value)
        {
            this.Value = Value;

        }
    }
}
