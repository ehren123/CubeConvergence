using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeConvergence
{
    class TwoDStringEquals
    {
        public bool Equals(string[,] firstString, string[,] secondString)
        {
            // If no mismatch found, result is true
            bool result = true;

            // Set size according to string size.
            int sizeX = firstString.GetLength(0);
            int sizeY = firstString.GetLength(1);

            if (secondString.GetLength(0) != sizeX || secondString.GetLength(1) != sizeY)
            {
                // Throw exception if strings are of different size.
                throw new Exception("Size mismatch in TwoDStringEquals entry.");
            }


            // Perform comparison
            for (int x = 0; x < sizeX; x++)
            {
                // No need to finish loop once false has been found.
                if (!result)
                {
                    break;
                }
                for (int y = 0; y < sizeY; y++)
                {
                    // If any results do no match result is false.
                    if (!firstString[x, y].Equals(secondString[x, y]))
                    {
                        result = false;
                        break;
                    }

                }
            }

            return result;
        }
    }
}
