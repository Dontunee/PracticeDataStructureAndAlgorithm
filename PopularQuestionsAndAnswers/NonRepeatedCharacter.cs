using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers
{
    public static class NonRepeatedCharacter
    {
        public static char Find(string characters)
        {
            var map = new Dictionary<char, int>();
            foreach (var item in characters)
            {
                if (map.ContainsKey(item))
                {
                    var value = map.GetValueOrDefault(item);
                    map.Remove(item);
                    map.Add(item, ++value);
                }
                else
                {
                    map.Add(item, 1);
                }
            }

            return map.FirstOrDefault(x => x.Value == 1).Key;
            /*
             create a dictionary of char and int key value pair
             loop over the string
            if dict is empty
            add the first one to the dictionary
            else check if it contains the value about to add 
            if it does increase count
            else add new position
            disctionary. first where the value is 1
             */
        }
    }

    public static class RepeatedCharacter
    {
        public static char Find(string characters)
        {
            /*create an hashset
             *check it doesnt contain value 
             *add each item to an hashset
             if it contains value return the value T
             */
            var hash = new HashSet<char>();
            foreach (var item in characters)
            {
                if(!hash.Contains(item))
                {
                    hash.Add(item);
                }
                else
                {
                    return item;
                }
            }
            return '0';

        }
    }
}
