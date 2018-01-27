using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracking
{
    class Vertex
    {
        public string label = "";
        public bool visited = false;

        public Vertex(string label, bool visited = false) {
            this.label = label;
            this.visited = visited;
        }

        public override string ToString()
        {
            return this.label;
        }

    }
}
