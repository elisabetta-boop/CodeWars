// Define a method/function that removes from a given array of integers all the values contained in a second array.
// Examples (input -> output):
// * [1, 1, 2 ,3 ,1 ,2 ,3 ,4], [1, 3] -> [2, 2, 4]
// * [1, 1, 2 ,3 ,1 ,2 ,3 ,4, 4, 3 ,5, 6, 7, 2, 8], [1, 3, 4, 2] -> [5, 6 ,7 ,8]
// * [8, 2, 7, 2, 3, 4, 6, 5, 4, 4, 1, 2 , 3], [2, 4, 3] -> [8, 7, 6, 5, 1]

using System;
using System.Linq;

public class Kata
{
  public static int[] Remove(int[] integerList, int[] valuesList)
  {
    
    // your code here
    for(int i = 0; i < integerList.Length; i++)
      {
      for(int j= 0; j < valuesList.Length; j++)
        {
          if(integerList[i] == valuesList[j])
            integerList = integerList.Where(val => val != valuesList[j]).ToArray();
        
          
      }
    }
    return integerList;
  }
}