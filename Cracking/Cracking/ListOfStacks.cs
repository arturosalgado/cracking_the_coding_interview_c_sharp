using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracking
{
    public class ListOfStacks
    {
        List<Stack<int>> stack_list = new List<Stack<int>>();
        int capacity_per_stack = 2;
        public ListOfStacks(int capacity) {
            this.capacity_per_stack = capacity;
        }

        public int Pop() {
            Stack<int>  current = getCurrentStack();
            if (current == null) {
                throw new Exception();
            }
            int value = current.Pop();
            // if this stack is empty, remove it from the list
            if (current.Count == 0) {
                Console.WriteLine("removing stack");
                stack_list.RemoveAt(stack_list.Count-1);
            }
            return value;
        }

        public void Push(int value) {

            Stack<int> current = getCurrentStack();
            if (current!=null && current.Count < capacity_per_stack) {
                current.Push(value);
            }
            else
            {
                Console.WriteLine("created a new stack");
                current = new Stack<int>(capacity_per_stack);
                current.Push(value);
                stack_list.Add(current);
            }
            

        }

        private Stack<int> getCurrentStack() {

            if (stack_list.Count == 0)
                return null;
            return  stack_list[stack_list.Count - 1];
            
        }

    }
}
