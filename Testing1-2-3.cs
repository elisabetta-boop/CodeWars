// Your team is writing a fancy new text editor and you've been tasked with implementing the line numbering.
// Write a function which takes a list of strings and returns each line prepended by the correct number.
// The numbering starts at 1. The format is n: string. Notice the colon and space in between.

using System.Collections.Generic;
public class LineNumbering 
{
    public static List<string> Number(List<string> lines) 
    {
        //your code goes here
      int n = 1;
      for(int i=0; i< lines.Count; i++)
        {
        lines[i] = n.ToString() + ": "+ lines[i];
        n++;
      }
        return lines;
    }
}