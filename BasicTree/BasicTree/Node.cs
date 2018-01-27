using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicTree
{
    class Node
    {

        public Node left { set; get; }
        public Node right { set; get; }
        public int  Value { set; get; }
        public Node(int v)
        {
            Value = v;
        }


        public override string ToString()
        {
            return ""+Value;
        }

      


    }
}
