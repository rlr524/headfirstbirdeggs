﻿namespace HeadFirstBirdEggsCL;

public class Pigeon : Bird
{
    public override Egg[] LayEggs(int numberOfEggs)
    {
        Egg[] eggs = new Egg[numberOfEggs];
        for (int i = 0; i < numberOfEggs; i++)
        {
            // eggs[i] = new Egg(Bird.Randomizer.NextDouble() * 2 + 1, "white");
            if (Bird.Randomizer.Next(4) == 0)
            {
                eggs[i] = new BrokenEgg(Bird.Randomizer.NextDouble() * 2 + 1, "white");
            }
            else
            {
                eggs[i] = new Egg(Bird.Randomizer.NextDouble() * 2 + 1, "white");
            }
        }

        return eggs;
    }
}