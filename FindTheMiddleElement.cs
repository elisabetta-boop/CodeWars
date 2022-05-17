// As a part of this Kata, you need to create a function that when provided with a triplet, returns the index of the numerical element that lies between the other two elements.
// The input to the function will be an array of three distinct numbers (Haskell: a tuple).
// For example:
// gimme([2, 3, 1]) => 0
// 2 is the number that fits between 1 and 3 and the index of 2 in the input array is 0.
// Another example (just to make sure it is clear):
// gimme([5, 10, 14]) => 1
// 10 is the number that fits between 5 and 14 and the index of 10 in the input array is 1.
// FUNDAMENTALSARRAYS

public class Kata
{
  public static int Gimme(double[] inputArray)
  {
    // Implement this function
    double result = 0 ;
    bool found = new bool();
    
    for(int i = 0; i < inputArray.Length-2; i++)
      {
        if (inputArray[i] < inputArray[i+1] && inputArray[i] > inputArray[i+2] || inputArray[i] > inputArray[i+1] && inputArray[i] < inputArray[i+2])
          {
          result = i;
          found = true;
        }
      }
    
    for(int i = 1; i < inputArray.Length-1; i++)
      {
        if (inputArray[i] < inputArray[i+1] && inputArray[i] > inputArray[i-1] || inputArray[i] > inputArray[i+1] && inputArray[i] < inputArray[i-1])
          {
          result = i;
          found = true;
        }
      
      }
    if(found != true)
      {
      result = 2;
    }

 
    int resultInt = (int)result;
    return resultInt; 
    }
  }