using System;

class Triangle
{
  public static void TrianglePieces(int side1, int side2, int side3)
  {
    if ((side1 + side2 < side3) || (side1 + side3 < side2) || (side2 + side3 < side1))
    {
      Console.WriteLine("Invalid triangle!");
    }
    else if (side1 == side2 && side2 == side3 && side1 == side3)
    {
      Console.WriteLine("Equilateral");
    }
    else if (side1 == side2 || side1 == side3 || side2 == side3)
    {
      Console.WriteLine("Isosceles");
    }
    else if (side1 != side2 && side2 != side3 && side1 != side3)
    {
      Console.WriteLine("Scalene");
    }
  }
  public static void Main()
  {
   Console.WriteLine("Enter Side 1 Length: ");
   int side1 = int.Parse(Console.ReadLine());
   Console.WriteLine("Enter Side 2 Length: ");
   int side2 = int.Parse(Console.ReadLine());
   Console.WriteLine("Enter Side 3 Length: ");
   int side3 = int.Parse(Console.ReadLine());
   TrianglePieces(side1, side2, side3);
  }
}

