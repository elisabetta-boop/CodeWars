// Take 2 strings s1 and s2 including only letters from ato z. Return a new sorted string, the longest possible, containing distinct letters - each taken only once - coming from s1 or s2.

// Examples:
// a = "xyaabbbccccdefww"
// b = "xxxxyyyyabklmopq"
// longest(a, b) -> "abcdefklmopqwxy"

// a = "abcdefghijklmnopqrstuvwxyz"
// longest(a, a) -> "abcdefghijklmnopqrstuvwxyz"

using System;
using System.Linq;
using System.Collections.Generic;

public class TwoToOne 
{
  
  public static string Longest (string s1, string s2) 
  {
    string longest = s1 + s2;
    
    return new string(longest.OrderBy(c => c).Distinct().ToArray());   
    }
  }