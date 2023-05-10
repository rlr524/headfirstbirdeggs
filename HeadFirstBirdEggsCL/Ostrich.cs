﻿namespace HeadFirstBirdEggsCL;

public class Ostrich : Bird
{ 
    public override Egg[] LayEggs(int numberOfEggs)
    {
        Egg[] eggs = new Egg[numberOfEggs];
        for (int i = 0; i < numberOfEggs; i++)
        {
            eggs[i] = new Egg(Bird.Randomizer.NextDouble() + 12, "speckled");
        }
        return eggs;
    }
}