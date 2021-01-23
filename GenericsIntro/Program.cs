using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     MyList<string> isimler = new MyList<string>();
        //     isimler.Add("abm");
        //     Console.WriteLine();
        // }
        static void Main(string[] args)
        {
            Dictionary<int, string> positions = new Dictionary<int, string>();
            positions.Add(1,"Point Guard");
            positions.Add(2,"Shooting Guard");
            positions.Add(3,"Small Forward");
            positions.Add(4,"Power Forward");
            positions.Add(5,"Center");
           
            foreach (var item in positions )
            {
              Console.WriteLine(item);  
            }

            MyDictionary<int, string> players = new MyDictionary<int, string>();
            players.Add(3,"3: R.J.Hunter");
            players.Add(1,"1: Travis Trice");
            players.Add(7,"2: Yiğit Arslan");
            players.Add(12,"4: Brock Motum");
            players.Add(19,"5: Johnathan Williams");

            Console.WriteLine(players.Length);
            Console.WriteLine("Players number,positions and name: ");
           foreach (var item in players.Numbers)
            {
                Console.WriteLine(item);
            }
            
            foreach (var item in players.Players)
            {
                Console.WriteLine(item); 
            }
        }
    }
}
