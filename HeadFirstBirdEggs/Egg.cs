// HeadFirstBirdEggs
// HeadFirstBirdEggs
// Egg.cs
// Created: 05 07 2023
// Author: Rob Ranf (robranf)
// (C) 2023 Emiya Consulting, LLC

namespace HeadFirstBirdEggs;

public class Egg
{
    public double Size { get; private set; }
    public string Color { get; private set; }

    public Egg(double size, string color)
    {
        Size = size;
        Color = color;
    }

    public string Description
    {
        get
        {
            return $"A {Size:0.0}cm {Color} egg";
        }
    }
}