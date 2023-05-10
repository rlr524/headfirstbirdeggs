using System;

namespace HeadFirstBirdEggsCL;

public class Bird
{
    public static Random Randomizer = new Random();

    public virtual Egg[] LayEggs(int numberOfEggs)
    {
        Console.Error.WriteLine("Bird.LayEggs should never get called");
        return Array.Empty<Egg>();
    }
}