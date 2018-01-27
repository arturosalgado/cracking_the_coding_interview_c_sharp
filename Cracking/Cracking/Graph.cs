using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracking
{
    class Graph
    {

        public int[,] adjacency_matrix;
        public Vertex[] vertices;
        private Stack<int> stack = new Stack<int>();
        public int vertexCount = 0;
        public Graph(int VERTICES = 20) {

            vertices = new Vertex[VERTICES];
            adjacency_matrix = new int[VERTICES, VERTICES];


        }
        public void addVertex(string label) {
            vertices[vertexCount] = new Vertex(label);
            vertexCount++;
        }

        public void addEdge(int start, int end)
        {
            adjacency_matrix[start, end] = 1;
            adjacency_matrix[end, start] = 1;

        }
        public void showVertex(int v)
        {
            Console.WriteLine("V {0} ", vertices[v].label);

        }

        public void dsf() {

            vertices[0].visited = true;
            showVertex(0);

            stack.Push(0);
            while (stack.Count > 0) {

                int v = getAdjUnvisitedVertex(stack.Peek());
                if (v == -1)
                {
                    stack.Pop();
                }
                else {

                    vertices[v].visited = true;
                    showVertex(v);
                    stack.Push(v);
                }
            }

            for (int i = 0; i < vertexCount; i++) {
                vertices[i].visited = false;
            }

        }

        public int getAdjUnvisitedVertex(int v) {
            for (int i = 0; i < vertexCount; i++) {
                if (adjacency_matrix[v, i] == 1 && vertices[i].visited == false)
                    return i;

            }
            return -1;
        }


    }
}
