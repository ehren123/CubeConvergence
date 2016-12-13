using System;

namespace CubeConvergence
{
    class CubeModel: IEquatable<CubeModel>
    {
        // Store a _size.
        private int _size;
        public int Size { get { return _size;  } }

        // Temporary variable for a row or columne, seperate varaible for clairty.
        private string[] row;
        private string[] col;


        // Initialize 2d string comparator.
        TwoDStringEquals twoDStringEquals =  new TwoDStringEquals();

        /*
         * 
         * BEGIN VARIABLES TO STORE EACH CUBE SUFACE
         * 
         */
        
        // green
        private string[,] frontSurface;
        public string[,] FrontSurface { get { return frontSurface; } set { frontSurface = value; } }  // green

        // orange
        private string[,] leftSurface;
        public string[,] LeftSurface { get { return leftSurface; } set { leftSurface = value; } } 

        // red
        private string[,] rightSurface;
        public string[,] RightSurface { get { return rightSurface; } set { rightSurface = value; } } 

        // yellow
        private string[,] backSurface;
        public string[,] BackSurface { get { return backSurface; } set { backSurface =value; } } 

        // white
        private string[,] topSurface;
        public string[,] TopSurface { get { return topSurface; } set { topSurface = value ; } } 

        // blue
        private string[,] bottomSurface;
        public string[,] BottomSurface { get { return bottomSurface; } set { bottomSurface = value; } }


        /*
         * 
         * END VARIABLES TO STORE EACH CUBE SUFACE
         * 
         */

        /*
         * 
         * BEGIN LOGIC FOR GETTING AND SETTING THE TOP ROW
         * 
         */

        public string[] TopRowFront
        {
            get
            {
                // Set the _size variable.
                try
                {
                    _size = frontSurface.GetLength(0);
                }
                catch (Exception e)
                {
                    throw new Exception("Invalid _size on cube get" + " " + e);
                }

                // Initialize the row variable.
                row = new string[_size];

                // Get values the top row of front surface
                for (int x = 0; x < _size; x++)
                {
                    row[x] = frontSurface[x, 0];
                }

                return row;

            }

            set
            {
                // Set _size variable with existing surface.
                try
                {
                    _size = frontSurface.GetLength(0);
                } 
                catch (Exception e)
                {
                    throw new Exception("Invalid _size on cube set" + " " + e);
                }

                // Ensure that row is correct _size, else throw an exception.
                if (value.Length != _size) throw new Exception("CubeModel row set input _size mispatch");

                // Set the top row of cube
                for (int x = 0; x < _size; x++)
                {
                    frontSurface[x, 0] = value[x];
                }
                
            }

        }

        public string[] TopRowRight
        {
            get
            {
                // Set the _size variable.
                try
                {
                    _size = rightSurface.GetLength(0);
                } 
                catch (Exception e)
                {
                    throw new Exception("Invalid _size on cube get" + " " + e);
                }

                // Initialize the row variable.
                row = new string[_size];

                // Get values the top row of front surface
                for (int x = 0; x < _size; x++)
                {
                    row[x] = rightSurface[x, 0];
                }

                return row;

            }
            set
            {
                // Set _size variable with existing surface.
                try
                {
                    _size = rightSurface.GetLength(0);
                } 
                catch (Exception e)
                {
                    throw new Exception("Invalid _size on cube set" + " " + e);
                }

                // Ensure that row is correct _size, else throw an exception.
                if (value.Length != _size) throw new Exception("CubeModel row set input _size mispatch");

                // Set the top row of cube
                for (int x = 0; x < _size; x++)
                {
                    rightSurface[x, 0] = value[x];

                }
            }
        }

        public string[] TopRowBack
        {
            get
            {
                // Set the _size variable.
                try
                {
                    _size = backSurface.GetLength(0);
                } 
                catch (Exception e)
                {
                    throw new Exception("Invalid _size on cube get" + " " + e);
                }

                // Initialize the row variable.
                row = new string[_size];

                // Get values the top row of front surface
                for (int x = 0; x < _size; x++)
                {
                    row[x] = backSurface[x, 0];
                }

                return row;

            }
            set
            {
                // Set _size variable with existing surface.
                try
                {
                    _size = backSurface.GetLength(0);
                } 
                catch (Exception e)
                {
                    throw new Exception("Invalid _size on cube set" + " " + e);
                }

                // Ensure that row is correct _size, else throw an exception.
                if (value.Length != _size) throw new Exception("CubeModel row set input _size mispatch");

                // Set the top row of cube
                for (int x = 0; x < _size; x++)
                {
                    backSurface[x, 0] = value[x];

                }
            }
        }

        public string[] TopRowLeft
        {
            get
            {
                // Set the _size variable.
                try
                {
                    _size = leftSurface.GetLength(0);
                } 
                catch (Exception e)
                {
                    throw new Exception("Invalid _size on cube get" + " " + e);
                }

                // Initialize the row variable.
                row = new string[_size];

                // Get values the top row of front surface
                for (int x = 0; x < _size; x++)
                {
                    row[x] = leftSurface[x, 0];
                }

                return row;

            }
            set
            {
                // Set _size variable with existing surface.
                try
                {
                    _size = leftSurface.GetLength(0);
                } 
                catch (Exception e)
                {
                    throw new Exception("Invalid _size on cube set" + " " + e);
                }

                // Ensure that row is correct _size, else throw an exception.
                if (value.Length != _size) throw new Exception("CubeModel row set input _size mispatch");

                // Set the top row of cube
                for (int x = 0; x < _size; x++)
                {
                    leftSurface[x, 0] = value[x];

                }
            }
        }

        /*
         * 
         * END LOGIC FOR GETTING AND SETTING THE TOP ROW
         * 
         */


        /*
         * 
         * BEGIN LOGIC FOR GETTING AND SETTING THE RIGHT COLUMN ROW
         * 
         */

        public string[] RightColumnFront
        {
            get
            {
                // Set the _size variable.
                try
                {
                    _size = frontSurface.GetLength(0);
                } 
                catch (Exception e)
                {
                    throw new Exception("Invalid _size on cube get" + " " + e);
                }

                // Initialize the row variable.
                col = new string[_size];

                // Get values the top row of front surface
                for (int y = 0; y < _size; y++)
                {
                    col[y] = frontSurface[_size - 1, y];
                }

                return col;
            }
            set
            {
                // Set _size variable with existing surface.
                try
                {
                    _size = frontSurface.GetLength(0);
                } 
                catch (Exception e)
                {
                    throw new Exception("Invalid _size on cube set" + " " + e);
                }

                // Ensure that row is correct _size, else throw an exception.
                if (value.Length != _size) throw new Exception("CubeModel row set input _size mispatch");

                // Set the top row of cube.
                for (int y = 0; y < _size; y++)
                {
                    frontSurface[_size - 1, y] = value[y];
                }

            }
        }

        public string[] RightColumnTop
        {
            get
            {
                // Set the _size variable.
                try
                {
                    _size = topSurface.GetLength(0);
                } 
                catch (Exception e)
                {
                    throw new Exception("Invalid _size on cube get" + " " + e);
                }

                // Initialize the row variable.
                col = new string[_size];

                // Get values the top row of front surface.
                for (int y = 0; y < _size; y++)
                {
                    col[y] = topSurface[_size - 1, y];
                }

                return col;
            }
            set
            {
                // Set _size variable with existing surface.
                try
                {
                    _size = topSurface.GetLength(0);
                } 
                catch (Exception e)
                {
                    throw new Exception("Invalid _size on cube set" + " " + e);
                }

                // Ensure that row is correct _size, else throw an exception.
                if (value.Length != _size) throw new Exception("CubeModel row set input _size mispatch");

                // Set the top row of cube
                for (int y = 0; y < _size; y++)
                {
                   topSurface[_size - 1, y] = value[y];
                }

            }
        }

         public string[] RightColumnBack
        {
            get
            {
                // Set the _size variable.
                try
                {
                    _size = backSurface.GetLength(0);
                } 
                catch (Exception e)
                {
                    throw new Exception("Invalid _size on cube get" + " " + e);
                }

                // Initialize the row variable.
                col = new string[_size];

                // Get values the top row of front surface.
                for (int y = 0; y < _size; y++)
                {
                    col[y] = backSurface[_size - 1, y];
                }

                return col;
            }
            set
            {
                // Set _size variable with existing surface.
                try
                {
                    _size = backSurface.GetLength(0);
                } 
                catch (Exception e)
                {
                    throw new Exception("Invalid _size on cube set" + " " + e);
                }

                // Ensure that row is correct _size, else throw an exception.
                if (value.Length != _size) throw new Exception("CubeModel row set input _size mispatch");

                // Set the top row of cube.
                for (int y = 0; y < _size; y++)
                {
                    backSurface[_size - 1, y] = value[y];
                }

            }
        }

         public string[] RightColumnBottom
         {
            get
            {                // Set the _size variable.
                try
                {
                    _size = bottomSurface.GetLength(0);
                } 
                catch (Exception e)
                {
                    throw new Exception("Invalid _size on cube get" + " " + e);
                }

                // Initialize the row variable.
                col = new string[_size];

                // Get values the top row of front surface
                for (int y = 0; y < _size; y++)
                {
                    col[y] = bottomSurface[_size - 1, y];
                }

                return col;
            }
             set
             {
                // Set _size variable with existing surface.
                try
                {
                    _size = bottomSurface.GetLength(0);
                } 
                catch (Exception e)
                {
                    throw new Exception("Invalid _size on cube set" + " " + e);
                }

                // Ensure that row is correct _size, else throw an exception.
                if (value.Length != _size) throw new Exception("CubeModel row set input _size mispatch");

                // Set the top row of cube
                for (int y = 0; y < _size; y++)
                {
                    bottomSurface[_size - 1, y] = value[y];
                }

             }
         }


        /*
         * 
         * END LOGIC FOR GETTING AND SETTING THE RIGHT COLUMN ROW
         * 
         */

        /*
        * 
        * BEGIN PRINTING METHODS
        * 
        * 
        */

        public void PrintFront()
        {
            _size = frontSurface.GetLength(0);
            for (int y = 0; y < _size; y++)
            {
                for (int x = 0; x < _size; x++)
                {
                    Console.Write(frontSurface[x, y] + "  ");
                }
                Console.WriteLine();
            }
        }

        public void PrintTop()
        {
            _size = topSurface.GetLength(0);
            for (int y = 0; y < _size; y++)
            {
                for (int x = 0; x < _size; x++)
                {
                    Console.Write(topSurface[x, y] + "  ");
                }
                Console.WriteLine();
            }
        }

        public void PrintBack()
        {
            _size = backSurface.GetLength(0);
            for (int y = 0; y < _size; y++)
            {
                for (int x = 0; x < _size; x++)
                {
                    Console.Write(backSurface[x, y] + "  ");
                }
                Console.WriteLine();
            }
        }

        public void PrintBottom()
        {
            _size = bottomSurface.GetLength(0);
            for (int y = 0; y < _size; y++)
            {
                for (int x = 0; x < _size; x++)
                {
                    Console.Write(bottomSurface[x, y] + "  ");
                }
                Console.WriteLine();
            }
        }

        public void PrintLeft()
        {
            _size = leftSurface.GetLength(0);
            for (int y = 0; y < _size; y++)
            {
                for (int x = 0; x < _size; x++)
                {
                    Console.Write(leftSurface[x, y] + "  ");
                }
                Console.WriteLine();
            }
        }

        public void PrintRight()
        {
            _size = frontSurface.GetLength(0);
            for (int y = 0; y < _size; y++)
            {
                for (int x = 0; x < _size; x++)
                {
                    Console.Write(rightSurface[x, y] + "  ");
                }
                Console.WriteLine();
            }
        }


        public void PrintAll()
        {
            // Front
            Console.WriteLine("PRINTING FRONT:");
            Console.WriteLine();
            PrintFront();
            Console.WriteLine();
            Console.WriteLine();

            // Right
            Console.WriteLine("PRINTING RIGHT:");
            Console.WriteLine();
            PrintRight();
            Console.WriteLine();
            Console.WriteLine();

            // Left
            Console.WriteLine("PRINTING LEFT:");
            Console.WriteLine();
            PrintLeft();
            Console.WriteLine();
            Console.WriteLine();

            // Top
            Console.WriteLine("PRINTING TOP:");
            Console.WriteLine();
            PrintTop();
            Console.WriteLine();
            Console.WriteLine();

            // Bottom
            Console.WriteLine("PRINTING BOTTOM:");
            Console.WriteLine();
            PrintFront();
            Console.WriteLine();
            Console.WriteLine();

            // Back
            Console.WriteLine("PRINTING BACK");
            Console.WriteLine();
            PrintBack();
            Console.WriteLine();
            Console.WriteLine();

        }
        /*
         * 
         * END PRINTING METHODS
         * 
         * 
         */


        public bool Equals(CubeModel other)
        {
            if( twoDStringEquals.Equals(FrontSurface, other.FrontSurface)
                && twoDStringEquals.Equals(BackSurface, other.BackSurface)
                && twoDStringEquals.Equals(RightSurface, other.RightSurface)
                && twoDStringEquals.Equals(LeftSurface, other.LeftSurface)
                && twoDStringEquals.Equals(TopSurface, other.TopSurface)
                && twoDStringEquals.Equals(BottomSurface, other.BottomSurface)
             )
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
