using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers
{
    public class IsUnique
    {
        public bool IsUniqueSolution(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;
            var letters = new int[26];
            foreach (var item in input)
            {
                var itemNumber = item - 'a';
                letters[itemNumber]++;
            }

            var getGreaterThan1 = letters.FirstOrDefault(c => c > 1);
            return getGreaterThan1 != 0;
        }
    }
}
