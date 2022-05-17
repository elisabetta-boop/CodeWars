// This time no story, no theory. The examples below show you how to write function accum:
// Examples:
// accum("abcd") -> "A-Bb-Ccc-Dddd"
// accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
// accum("cwAt") -> "C-Ww-Aaa-Tttt"
// The parameter of accum is a string which includes only letters from a..z and A..Z.

using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

public class Accumul 
{
  public static String Accum(string s) 
  {
  if(s.Length < 1) return "";

    StringBuilder sb = new StringBuilder();
    int count = 1;
    foreach(char c in s.ToLower())
      sb.Append(Char.ToUpper(c), 1)
        .Append(c, count++ - 1)
        .Append('-');
     
    return sb.ToString().TrimEnd('-');
  }
  }