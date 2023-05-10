// HeadFirstBirdEggsCL
// BrokenEgg.cs
// Created: 05 09 2023
// Author: Rob Ranf (robranf)
// (C) 2023 Emiya Consulting, LLC

namespace HeadFirstBirdEggsCL;

public class BrokenEgg : Egg
{
    public BrokenEgg(double size, string color) : base(size, color)
    {
        Console.WriteLine("A bird laid a broken egg");
    }
}
