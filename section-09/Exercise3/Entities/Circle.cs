using Exercise3.Entities.Enums;

namespace Exercise3.Entities;
using System;
using Exercise3.Entities.Enums;

class Circle : Shape
{
    public double Radius { get; set; }


    
    public Circle(double radius, Color color) :base(color)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}