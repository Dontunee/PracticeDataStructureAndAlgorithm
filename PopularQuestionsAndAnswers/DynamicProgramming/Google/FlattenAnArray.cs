using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers.DynamicProgramming.Google
{
    public class FlattenAnArray
    {
        public int[] NestedArray(dynamic input)
        {
            var flattened = new List<int>();
            NestedArray(input, flattened);
            return flattened.ToArray();
        }


        public void NestedArray(dynamic input, List<int> flattened )
        {
            if (input is null) return;
            if (input is int)
            {
                if (flattened is null) flattened = new List<int>();
                flattened.Add((int)input);
                NestedArray(null, flattened);
            }
            foreach (var item in input)
            {
                if (item is int)
                {
                    if (flattened is null) flattened = new List<int>();
                    flattened.Add((int)item);
                }
                else
                {
                    NestedArray(item, flattened);
                };
            }

        }
                
    }
}
