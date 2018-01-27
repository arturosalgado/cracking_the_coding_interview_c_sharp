using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {

            Graph g = new Graph();
            g.AddVertex("A");
            g.AddVertex("B");
            g.AddVertex("C");
            g.AddVertex("D");
            g.AddVertex("E");
            g.AddVertex("F");
            g.AddVertex("G");
            g.AddVertex("H");

         
            g.AddEdge("A","B");
            g.AddEdge("A","D");
            g.AddEdge("A","G");

            g.AddEdge("B", "A");
            g.AddEdge("B", "E");
            g.AddEdge("B", "F");

            g.AddEdge("C", "H");
            g.AddEdge("C", "F");

            g.AddEdge("D", "A");
            g.AddEdge("D", "F");

            g.AddEdge("E", "B");
            g.AddEdge("E", "G");

            g.AddEdge("F", "B");
            g.AddEdge("F", "C");
            g.AddEdge("F", "D");


            g.AddEdge("G", "E");
            g.AddEdge("G", "A");


            g.AddEdge("H", "C");
            





            int ad = g.GetAdjUnvisitedVertex(3);
            Console.WriteLine("{0}",ad);
            g.showMatrix();

            Console.WriteLine("");
            //g.dsf();
            g.beathsearchfirst();

            Console.WriteLine("");

            g.showMatrix();

            Console.ReadKey();
        }
    }
}
