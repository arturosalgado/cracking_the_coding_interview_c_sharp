﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph
{
    class Vertex
    {



        public Vertex(string label)
        {
            this.label = label;
        }

        public bool visited = false;
        public string label = "";


        public override string ToString()
        {
            return this.label;
        }

    }
}
