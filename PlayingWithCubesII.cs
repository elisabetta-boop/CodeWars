// Hey Codewarrior!
// You already implemented a Cube class, but now we need your help again! I'm talking about constructors. We don't have one. Let's code two: One taking an integer and one handling no given arguments!
// Also we got a problem with negative values. Correct the code so negative values will be switched to positive ones!
// The constructor taking no arguments should assign 0 to Cube's Side property.

using System;
public class Cube
{
  private int Side;
  
  //This cube needs your help. 
  //Define a constructor which takes one integer and assignes its value to 'Side'
  public Cube()
    {
    SetSide(0);
  }
  public Cube(int Side)
    {
      if (Side<0)
        {
        Side = Side*-1;
        
        }
      
    SetSide(Side);
  }
  public int GetSide()
  {
    return this.Side;
  }
  
  public void SetSide(int s)
  {
    this.Side = Math.Abs(s);
  }
}