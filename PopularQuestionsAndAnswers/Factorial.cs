using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers
{
    public static class Factorial
    {

        public static int Solve(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * Solve(number - 1);
        }
    }
}
