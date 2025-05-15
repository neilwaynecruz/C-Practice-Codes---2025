namespace Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // enums = special "class" that contains a set of named integer constants.
            //         Use enums when you have values that you know wil not change,
            //        To get the integer value from an item, you must explicitly conver to an int

            //        name  = integer

            //Console.WriteLine(Planets.EARTH + " is planet number " + (int)Planets.EARTH);

            string planetName = RadiusPlanets.EARTH.ToString(); // this will convert the enum to a string
            int radiusOfPlanet = (int)RadiusPlanets.EARTH; // this will convert the enum to an int

            Console.WriteLine("Planet: " + planetName);
            Console.WriteLine("Radius: "+ radiusOfPlanet + " km");
            Console.WriteLine($"The volume of {planetName}: {Volume(RadiusPlanets.EARTH)} km^3");  // planetName is string , so it will be converted to a string,
                                                                                                     // Volume(RadiusPlanets.EARTH) will return a double value

        }

        public static double Volume(RadiusPlanets radius)
        {
            double vol = (4.0/3.0) * Math.PI * Math.Pow((int)radius, 3);
            return vol;
        }
    }

    public enum Planets 
    {
        MERCURY = 1,
        VENUS = 2,
        EARTH = 3,
        MARS = 4,
        JUPITER = 5,
        SATURN = 6,
        URANUS = 7,
        NEPTUNE = 8,
        PLUTO = 9,
    }

    public enum RadiusPlanets 
    {
        MERCURY = 2439,
        VENUS = 6052,
        EARTH = 6371,
        MARS = 3389,
        JUPITER = 69911,
        SATURN = 58232,
        URANUS = 25362,
        NEPTUNE = 24622,
        PLUTO = 1188
    }

}
