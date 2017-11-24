using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * return only name with four letter
 */ 
namespace Friend_or_Foe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
            Friend_or_Foe.Library.Friend_or_Foe.ReturnFriend(names).ToList().ForEach(Console.WriteLine);

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}
