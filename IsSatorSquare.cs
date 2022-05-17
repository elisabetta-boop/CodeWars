// A Discovery
// One fine day while ploughing the fields, Farmer Arepo found a stone tablet with symbols carved on it... he knew such artifacts may show a message in four directions, so he wisely kept it and resumed turning the soil. He found more tablets, but with crops to sow he had no time to decipher them.
// Your Task
// Please help Farmer Arepo by inspecting each tablet to discern whether or not it shows a Sator Square!
// The Square
// is a two-dimentional palindrome (made from words of equal length)
// observes four symmetries: identity, 180-degree rotation, and two diagonal reflections
// can be read:
// left-to-right (across)
// top-to-bottom (down)
// bottom-to-top (up)
// right-to-left (reverse)
// can be rotated 180 degrees and all words still read in all directions
// is exemplified here in how to read a word ("TUBA") in the four ways:
// Some Details
// tablet (square) dimensions range from 2x2 to 33x33 inclusive
// characters range from ascii ordinals 33 to 126 inclusive
// tablets may contain characters that look similar yet are different
// you are not permitted to mutate the input
// Input
// public static bool IsSatorSquare(char[,] Tablet)
// //  a two-dimentional array of characters (2 <= n <= 33)
// Output
// true or false  //  whether or not the tablet is a sator square

using System;
using System.Linq;
using System.Collections.Generic;

namespace Kata
{
  class Solution
  {
    
    private static List<List<string>> words = new List<List<string>>();
    
    public static bool IsSatorSquare(char[,] tablet)
    {
      words.Clear();
      Up(tablet);
      Right(tablet);
      Down(tablet);
      Left(tablet);
      foreach (List<string> list in words)
      {
        foreach (string word in list)
          if (!words.All(x => x.Contains(word)))
            return false;
      }
      return true;
    }
    
    private static void Up (char[,] tablet)
    {
      List<string> up = new List<string>();
      for (int col = tablet.GetLength(1) - 1; col >= 0; col--)
      {
        string word = string.Empty;
        for (int row = tablet.GetLength(0) - 1; row >= 0; row--) word += tablet[row, col];
        up.Add(word);
      }
      words.Add(up);
    }
    
    private static void Right (char[,] tablet)
    {
      List<string> right = new List<string>();
      for (int row = 0; row < tablet.GetLength(0); row++)
      {
        string word = string.Empty;
        for (int col = 0; col < tablet.GetLength(1); col++) word += tablet[row, col];
        right.Add(word);
      }
      words.Add(right);
    }
    
    private static void Down (char[,] tablet)
    {
      List<string> down = new List<string>();
      for (int col = 0; col < tablet.GetLength(1); col++)
      {
        string word = string.Empty;
        for (int row = 0; row < tablet.GetLength(0); row++) word += tablet[row, col];
        down.Add(word);
      }
      words.Add(down);
    }
    
    private static void Left (char[,] tablet)
    {
      List<string> left = new List<string>();
      for (int row = tablet.GetLength(0) - 1; row >= 0; row--)
      {
        string word = string.Empty;
        for (int col = tablet.GetLength(1) - 1; col >= 0; col--) word += tablet[row, col];
        left.Add(word);
      }
      words.Add(left);
   
    }
  }
}