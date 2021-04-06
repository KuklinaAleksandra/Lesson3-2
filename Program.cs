using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matrix = {{"Ivanov", "233221"},
                { "Petrov", "233221"},
            { "Sidorov", "233221"},
            { "Ivanova", "233221"},
            { "Petrova", "233221"} };

            

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)


                    Console.Write(matrix[i, j] + "  ");
                Console.WriteLine();
            }

            Console.ReadKey();
        }


    }
    }

