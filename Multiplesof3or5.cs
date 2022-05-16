// CodeWars
// Multiples of 3 or 5

// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

// Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in. Additionally, if the number is negative, return 0 (for languages that do have them).

// Note: If the number is a multiple of both 3 and 5, only count it once.


using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static int Solution(int value)
  {
    // Magic Happens'
    List<int> multiplesToAdd = new List<int>();
    int theCountMagic=0;
    
    if(value <= 0)
      {
      return 0;
    }
    else
      {
      for (int i = 1; i < value; i++)
      {
        theCountMagic= 0;
        if (i % 3 == 0 && i % 5 == 0)
          {
            multiplesToAdd.Add(i);
            theCountMagic++;
          }
        else if ( i % 3 == 0)
          {
            if(theCountMagic ==0)
              {
              multiplesToAdd.Add(i);
            }
          }
        else if (i % 5 == 0)
          {
            if(theCountMagic ==0)
              {
                multiplesToAdd.Add(i);
            }
          }           
      }  
    }
    IEnumerable<int> result= multiplesToAdd.Distinct();  //LINQ distinct function
    int sumTot = result.Sum();
    return sumTot;
  }
}