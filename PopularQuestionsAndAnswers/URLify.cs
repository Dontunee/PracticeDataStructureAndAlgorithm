using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers
{
    public static class URLify
    {
        public static string Solution(string input)
        {
            return input.Trim().Replace(" ", "%20");
        }
    }
}
