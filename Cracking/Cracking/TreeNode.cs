using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracking
{
    class TreeNode
    {

        public TreeNode left;
        public TreeNode right;
        public int value; 

        public TreeNode(int value)
        {
            this.value = value;

        }

        public override string ToString()
        {
            return ""+value+"";
        }

    }
}
