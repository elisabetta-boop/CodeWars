// Welcome. In this kata, you are asked to square every digit of a number and concatenate them.
// For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1.
// Note: The function accepts an integer and returns an integer

using System;
using System.Linq;


public class Kata
{
  public static int SquareDigits(int n)
  {
  
    int result = 0;
    int places = 0;

    
    while(n > 0)
    {
        
        int digit = n % 10;

        
        int square = digit * digit; 

       
        result += (int)Math.Pow(10,places) * square;    

        
        places += square > 10 ? 2 : 1;  

       
        n /= 10;
    }

    return result;
  }
  }