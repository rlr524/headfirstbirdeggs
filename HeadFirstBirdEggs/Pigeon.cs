﻿namespace HeadFirstBirdEggs;

internal class Pigeon : Bird
{
    public override Egg[] LayEggs(int numberOfEggs)
    {
        Egg[] eggs = new Egg[numberOfEggs];
        for (int i = 0; i < numberOfEggs; i++)
        {
            eggs[i] = new Egg(Bird.Randomizer.NextDouble() * 2 + 1, "white");
        }

        return eggs;
    }
}