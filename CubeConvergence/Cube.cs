using System;

namespace CubeConvergence
{

    // Accepts a cube of any size and perform operations on it.
    // Initial purpose is to count the number of iterations to converge if we perform clockwise permutations
    // on both top and right surface. Each permutation is one iteration.
    // Cube state is defined based on western cube as shown here: http://bit.ly/2b89cvD
    // We will define a surface as a string[,].
    // We will define a row or a column as a string[].

    class Cube: IEquatable<Cube>
    {
        // Pointer for rotate.
        private readonly Rotate rotate = new Rotate();

        // Cube Model
        private CubeModel cubeModel = new CubeModel();
        public CubeModel CubeModel { get { return cubeModel; } }


        private int size; // Defindes size of the cube

        // Temp values for row and col, seperate values for clarity
        private string[] row;
        private string[] col;

        // Comments indiate inditial state of a default cube.
        private string[,] frontSurface;  // green
        private string[,] leftSurface; // orange
        private string[,] rightSurface; // red
        private string[,] backSurface; // yellow
        private string[,] topSurface; // white
        private string[,] bottomSurface; // blue

        // Interator for permutations, each permutation counts as 1.
        public int Interations { get; set; }

        // Initialize a default cube given a size, default is 3.
        public Cube(int urSize = 3)
        {
            // Initialize iterator
            Interations = 0;

            size = urSize;

            frontSurface = new string[size,size];  // green
            leftSurface = new string[size, size]; // orange
            rightSurface = new string[size, size]; // red
            backSurface = new string[size, size]; // yellow
            topSurface = new string[size, size]; // white
            bottomSurface = new string[size, size]; // blue

            // Perform operation on each side
            // Front surface green
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    frontSurface[i,j] = "green";
                }
            }


            // Left surface orange
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    leftSurface[i,j] = "orange";
                }
            }

            // Right surface red
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    rightSurface[i,j] = "red";
                }
            }

            // Back surface yellow
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    backSurface[i,j] = "yellow";
                }
            }

            // Top surface white
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    topSurface[i,j] = "white";
                }
            }

            // Bottom surface blue
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    bottomSurface[i,j] = "blue";
                }
            }

            // Generate cubemodel
            cubeModel.BackSurface = backSurface;
            cubeModel.BottomSurface = bottomSurface;
            cubeModel.FrontSurface = frontSurface;
            cubeModel.RightSurface = rightSurface;
            cubeModel.TopSurface = topSurface;
            cubeModel.LeftSurface = leftSurface;

        }


        // Turn top
        // When we turn the top/right row/column we modify the top row/colum accordingly.
        // The top surface rotates, i.e., it's state stays the same but permutates by 90 degrees.
        public void TurnTopClockwise()
        {
            // Initialize a row this is needed to store the last side to get replaced.
            row = new string[cubeModel.Size];
            
            // Rotate the top surface.
            cubeModel.TopSurface = rotate.RightTurn(cubeModel.TopSurface);

            // Store the last row to be replaced.
            row = cubeModel.TopRowRight;
            // Replace each top row.
            cubeModel.TopRowRight = cubeModel.TopRowBack;
            cubeModel.TopRowBack = cubeModel.TopRowLeft;
            cubeModel.TopRowLeft = cubeModel.TopRowFront;
            cubeModel.TopRowFront = row;
            Interations++;
        }

        // Turn right
        public void TurnRightClockwise()
        {

            // Initialize a column this is needed to store the last side to get replaced.
            col = new string[cubeModel.Size];
            
            // Rotate right surface.
            cubeModel.RightSurface = rotate.RightTurn(cubeModel.RightSurface);

            col = cubeModel.RightColumnBottom;
            cubeModel.RightColumnBottom = cubeModel.RightColumnBack;
            cubeModel.RightColumnBack = cubeModel.RightColumnTop;
            cubeModel.RightColumnTop = cubeModel.RightColumnFront;
            cubeModel.RightColumnFront = col;
            Interations++;
        }

       

        // IEquatable
        public bool Equals(Cube other)
        {
            return CubeModel.Equals(other.CubeModel);
        }
    }
}
