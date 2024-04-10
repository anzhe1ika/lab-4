using Lab4._1_27._03_;

class Program
{
    static void Main(string[] args)
    {
        City city1 = new City("Kyiv");
        City city2 = new City("Kharkiv");
        City city3 = new City("Lviv");

        District district1 = new District("District 1", new List<City> { city1 }, city1);
        District district2 = new District("District 2", new List<City> { city2 }, city2);
        District district3 = new District("District 3", new List<City> { city3 }, city3);

        Region region1 = new Region("Region 1", 28131, new List<District> { district1 });
        Region region2 = new Region("Region 2", 31418, new List<District> { district2 });
        Region region3 = new Region("Region 3", 21832, new List<District> { district3 });

        State ukraine = new State("Ukraine", city1, new List<Region> { region1, region2, region3 });

        ukraine.DisplayCapital();
        ukraine.DisplayNumberOfRegions();
        ukraine.DisplayArea();
        ukraine.DisplayRegionalCenters();

        Console.ReadKey();
    }
}