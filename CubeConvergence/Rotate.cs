using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;

namespace CubeConvergence
{
    class Rotate
    {

        private string[,] _original;
        private string[,] _result;
        private int _size;

        // Accept a two dimensional array.
        public void Store(string[,] urStore)
        {
            if (urStore.GetLength(0) != urStore.GetLength(1))
            {
                throw new Exception("Size mismatch in Rotate");
            }
            _size = urStore.GetLength(0);

            _original = urStore;

        }

        // Might not be needed...
        protected IEnumerable<string> Send()
        {
            string[] result = new string[_size^2];

            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {
                    result[i*j] = _original[i, j];
                }
            }

            foreach (string s in result)
            {
                yield return s;
            }

        }

        // Turn a two d array right.
        public string[,] RightTurn(string[,] urSource)
        {
         string[,] result = new string[_size,_size];


            // i and j used to get initial values from urSource
            int i = 0;
            int j;

            // Start at top right.
            for (int y = (_size - 1); y >= 0; y--)
            {
                
                j = 0;
                for (int x = 0; x < _size; x++)
                {
                    result[x, y] = urSource[i, j];
                    j++;
                }
                i++;
            }

            return result;
        }




        /*
        // Rotates a 2D odd string 90 degrees clockwise
        public string[,] TwoDStringClockwise(string[,] urString)
        {
            // Determine the size of the input cube.
            int size = urString.GetLength(0);

            if (size != urString.GetLength(1))
            {
                throw new Exception("TwoDString entry is not a cube!");
            }

            // xy coodrinates
            // TODO review this code.
            /*
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    urString[y, x] = urString[size - y - 1, x];
                }
            }
            return urString;
        

            // http://bit.ly/2bXnLVa
            string[,] myString = new string[size, size];

            for (int i = size - 1; i >= 0; --i)
            {
                for (int j = 0; j < size; ++j)
                {
                    myString[j, size - 1 - i] = urString[i, j];
                }
            }

            return myString;

    */

    }
        
    

}
