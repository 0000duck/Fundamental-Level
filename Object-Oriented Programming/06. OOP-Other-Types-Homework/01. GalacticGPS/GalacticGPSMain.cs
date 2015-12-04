using System;

namespace _01.GalacticGPS
{
    class GalacticGPSMain
    {
        static void Main(string[] args)
        {
            Location home = new Location(18.037986, 28.870097, Planet.Earth);
            Console.WriteLine(home);
        }
    }
}
