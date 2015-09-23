using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.NightLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, SortedSet<string>>> performances = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();

            string input = Console.ReadLine();

            while(input != "END")
            {
                string[] cityVenuePerformer = input.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string city = cityVenuePerformer[0];
                string venue = cityVenuePerformer[1];
                string performer = cityVenuePerformer[2];

                if (!performances.ContainsKey(city))
                {
                    performances[city] = new SortedDictionary<string, SortedSet<string>>();
                }
                if(!performances.ContainsKey(venue))
                {
                    performances[city][venue] = new SortedSet<string>();
                }
                if (!performances.ContainsKey(performer))
                {
                    performances[city][venue].Add(performer);
                }

                input = Console.ReadLine();
            }

            foreach (var city in performances)
            {
                Console.WriteLine($"\r\n{city.Key}");
                foreach (var venue in city.Value)
                {
                    Console.WriteLine("->{0}: {1}", venue.Key, string.Join(", ",venue.Value));
                }
            }
        }
    }
}
