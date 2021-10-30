using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers.DynamicProgramming.Google
{
    public class ValidAnagram
    {

        public bool isAnagram(string s , string t)
        {
            var listOfS = s.ToCharArray();
            var listOfT = t.ToCharArray();

            var array = new int[26];

            foreach (var item in listOfS)
            {
                array[item - 'a'] += 1;
            }
            foreach (var item in listOfT)
            {
                array[item - 'a'] -= 1;
            }

            foreach (var item in array)
            {
                if (item != 0)
                    return false;
            }

            return true;

        }
    }
}
