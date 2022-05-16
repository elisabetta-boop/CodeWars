// Imagine there's a big cube consisting of n3 n^3n 
// 3
//   small cubes. Calculate, how many small cubes are not visible from outside.
// For example, if we have a cube which has 4 cubes in a row, then the function should return 8, because there are 8 cubes inside our cube (2 cubes in each dimension)
using System;

public class Kata
{
  public static int NotVisibleCubes(int n)
  {
    // your code!
    return n>3?(n-2)*(n-2)*(n-2):n==3?1:0;
  }
}