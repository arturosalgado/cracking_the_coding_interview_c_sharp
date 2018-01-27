using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeLoopTraverse
{
    class Node
    {

        public Node left{get; set;}
        public Node right { get; set; }
        public int Value { get; set; }

        public Node() { }

        public Node(int v)
        {
            this.Value = v;

        }



    }
}
