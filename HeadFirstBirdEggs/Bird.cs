// HeadFirstBirdEggs
// HeadFirstBirdEggs
// Bird.cs
// Created: 05 07 2023
// Author: Rob Ranf (robranf)
// (C) 2023 Emiya Consulting, LLC

using System;

namespace HeadFirstBirdEggs;

public class Bird
{
    private static Random Randomizer = new Random();

    public virtual Egg[] LayEggs()
    {
        Console.Error.WriteLine("Bird.LayEggs should never get called");
        return new Egg[0];
    }
}