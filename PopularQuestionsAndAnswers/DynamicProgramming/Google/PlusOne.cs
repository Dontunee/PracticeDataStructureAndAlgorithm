using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers.DynamicProgramming.Google
{
    public class PlusOne
    {
        public int[] Solution(int[] array )
        {
            int m = array.Length;

            for (int i = m - 1; i >= 0; --i )
            {
                if (array[i] != 9)
                {
                    array[i] += 1;
                    return array;
                }
                array[i] = 0;
            }

            var newDigits = new int[m + 1];
            newDigits[0] = 1;
            return newDigits;

        }
    }
}
