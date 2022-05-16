// Implement a function that accepts 3 integer values a, b, c. The function should return true if a triangle can be built with the sides of given length and false in any other case.
// (In this case, all triangles must have surface greater than 0 to be accepted).


public class Triangle
{
    public static bool IsTriangle(int a, int b, int c)
    {
      
      int firstSum = a+b;
      int secondSum = a+c;
      int thirdSum = b+c;
      
      if(firstSum > c && secondSum >b && thirdSum >a)
        return true;
      else
        return false;
    }
}