using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeConvergence
{
    // Used for copying arrays
    class ArrayCopy
    {

        // Copy a two dimensional string
        public string[,] twoDString(string[,] urString)
        {
            string[,] myString = new string[urString.GetLength(0),urString.GetLength(1)];

            for (int i = 0; i < urString.Length; i++)
            {
                for (int j = 0; i < urString.Length; j++)
                {
                    myString[i,j] = string.Copy(urString[i,j]);
                }
            }
            return myString;
        }
    }
}
