// An isogram is a word that has no repeating letters, consecutive or non-consecutive. Implement a function that determines whether a string that contains only letters is an isogram. Assume the empty string is an isogram. Ignore letter case.
// Example: (Input --> Output)
// "Dermatoglyphics" --> true
// "aba" --> false
// "moOse" --> false (ignore letter case)

using System;

public class Kata
{
  public static bool IsIsogram(string str) 
  {
    str = str.ToLower();
    for(int i = 0; i <str.Length;i++){
      for(int j = i+1; j <(str.Length); j++){
        if(str[i] == str[j] ) return false;
      }
    }
    return true;
    }
  }