using System;

namespace CubeConvergence
{
    class Program
    {
        static void Main(string[] args)
        {
           Test1();
            Console.ReadLine();
        }

        static void TestTopRotate()
        {
            Cube cube = new Cube();

            cube.TurnRightClockwise();
            cube.CubeModel.PrintTop();

            Console.WriteLine();
            cube.TurnTopClockwise();

            cube.CubeModel.PrintTop();

            Console.WriteLine();
            cube.TurnTopClockwise();

            cube.CubeModel.PrintTop();


        }

        static void TestRowGet()
        {
            Cube cube = new Cube();
            cube.CubeModel.PrintAll();


            // Front
            Console.WriteLine("FRONT/n");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(cube.CubeModel.TopRowFront[i]);
            }
            Console.WriteLine();
            Console.WriteLine();

            // Left
            Console.WriteLine("LEFT/n");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(cube.CubeModel.TopRowLeft[i]);
            }
            Console.WriteLine();
            Console.WriteLine();

            // Back
            Console.WriteLine("BACK/n");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(cube.CubeModel.TopRowBack[i]);
            }
            Console.WriteLine();
            Console.WriteLine();

            // Right
            Console.WriteLine("RIGHT/n");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(cube.CubeModel.TopRowRight[i]);
            }
            Console.WriteLine();
            Console.WriteLine();




        }


        static void Test1()
        {
            Cube cube = new Cube();
            cube.CubeModel.PrintAll();
            cube.TurnTopClockwise();

            Console.WriteLine("/n/n TURNED TOP CLOCKWISE /n/n");

            cube.CubeModel.PrintAll();

            cube.TurnRightClockwise();

            Console.WriteLine("/n/n TURNED RIGHT CLOCKWISE /n/n");

            cube.CubeModel.PrintAll();
        }


        // Functional program
        static void Run()
        {

            Cube cube = new Cube(3);
            Cube cubeCompare = new Cube(3);

            do
            {
                cube.TurnTopClockwise();
                cube.TurnRightClockwise();
                Console.WriteLine();
                
            } while (cube.Equals(cubeCompare));

            Console.WriteLine(cube.Interations);

            Console.ReadLine();
        }
    }
}
