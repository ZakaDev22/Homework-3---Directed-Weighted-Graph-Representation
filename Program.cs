using System;
using System.Collections.Generic;

namespace Homework_3___Directed_Weighted_Graph_Representation
{
    internal class Program
    {
        public class listInformation
        {
            public string Name { get; set; }

            public byte weight { get; set; }

            public listInformation()
            {
                Name = string.Empty;
                this.weight = 0;
            }

            public listInformation(string name, byte weight)
            {
                Name = name;
                this.weight = weight;
            }
        }



        public class GraphAdjacencylist
        {
            public string AdjacencyName { get; set; }
            public List<listInformation> listInformation { get; set; }

            public GraphAdjacencylist(string CurrentVertex, List<listInformation> list)
            {
                AdjacencyName = CurrentVertex;
                listInformation = list;
            }


        }

        public static void MatrixSolution()
        {
            string[] Names = { "X", "Y", "Z", "W" };

            int[,] Matrix =
            {
                {0,6,4,0 },
                {0,0,0,1},
                {0,0,0,3 },
                {0,0,0,0}
            };

            Console.WriteLine();

            Console.WriteLine("\t" + string.Join("\t", Names));

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                Console.Write($"{Names[i]}\t");

                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write(Matrix[i, j] + "\t");
                }

                Console.WriteLine();
            }

        }

        public static void ListSolution()
        {
            List<GraphAdjacencylist> List = new List<GraphAdjacencylist>();

            GraphAdjacencylist X = new GraphAdjacencylist("X", new List<listInformation>
            {
                new listInformation("Y",6),
                new listInformation ("Z",4)
            });

            GraphAdjacencylist Y = new GraphAdjacencylist("Y", new List<listInformation>
            {
                new listInformation("W",1)
            });

            GraphAdjacencylist Z = new GraphAdjacencylist("Z", new List<listInformation>
            {
                new listInformation("W",3)
            });

            GraphAdjacencylist W = new GraphAdjacencylist("W", new List<listInformation>());


            List.Add(X);
            List.Add(Y);
            List.Add(Z);
            List.Add(W);



            foreach (var item in List)
            {
                Console.WriteLine($"\t {item.AdjacencyName}  Result : \n");
                foreach (var conn in item.listInformation)
                {
                    Console.WriteLine($" {item.AdjacencyName} ---> {conn.Name} -> weight ({conn.weight})");
                }

                Console.WriteLine("\n");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\t Matrix Solution : \n\n");
            MatrixSolution();

            Console.WriteLine("\n\n\t List Solution : \n\n");
            ListSolution();


            Console.ReadKey();
        }
    }
}
