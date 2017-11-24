using System;
using System.Linq;
using System.Collections.Generic;
/*
 * return only name with four letter
 */
namespace Friend_or_Foe.Library
{
    public class Friend_or_Foe
    {
        public static IEnumerable<string> ReturnFriend(string[] names)
        {
            //------------------------------------------
            /*List<string> result = new List<string>();
            foreach(string n in names)
            {
                if (n.Length == 4)
                    result.Add(n);
            }
            return result;*/

            //------------------------------------------
            /*foreach (string n in names)
            {
                if (n.Length == 4)
                        yield return n;// leniwe kolekcje
            }*/
            //------------------------------------------
            //return names.Where(n => n.Length == 4);
            //------------------------------------------
            return from name in names where name.Length == 4 select name;
        }
    }
        
}
