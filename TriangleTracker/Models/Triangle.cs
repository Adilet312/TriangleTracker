using System;

namespace Triangles
{
  public class Triangle
  {
    public int side1 { get; set; }
    public int side2 { get; set; }
    public int side3 { get; set; }
    public Triangle(int side1, int side2, int side3)
    {
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }
    public bool IsTriangle()
    {
        if(side1 + side2 > side3 && side2 + side3 > side1 && side1 + side3 > side2)
        {
            return true;
        }
        return false;
    }
    public bool IsEquilateral()
    {
      if(side1 == side2 && side2 == side3)
      {
          return true;
      }
      return false;
    }
    public bool IsIsosceles()
    {
        if((side1 == side2 || side1 == side3 || side2 == side3) && !IsEquilateral())
        {
            return true;
        }
        return false;
    }
    public bool IsScalene()
    {
        if (!IsEquilateral() && !IsIsosceles() && IsTriangle())
        {
            return true;
        }
        return false;
    }
    public string PrintTriangle()
    {
        return " " + side1 + " " + side2 + " " + side3;
    }
  }
}