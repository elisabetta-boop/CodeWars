// Write a function insert_dash(num) / insertDash(num) / InsertDash(int num) that will insert dashes ('-') between each two odd digits in num. For example: if num is 454793 the output should be 4547-9-3. Don't count zero as an odd digit.
// Note that the number will always be non-negative (>= 0).
// FUNDAMENTALSSTRINGSARRAYS

using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
  public static string InsertDash(int num)
  {

    string numero = num.ToString();
    string result_str = "";

    for (int i = 0; i < numero.Length-1 ; i++)
    {
      result_str += numero[i];
      if (numero[i] % 2 != 0 && numero[i+1]%2!=0 )
          result_str += "-";
    }
    result_str += numero[numero.Length-1];
    return result_str;
  }
}