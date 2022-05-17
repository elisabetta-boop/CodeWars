// You will be given the number of angles of a shape with equal sides and angles, and you need to return the number of its sides, and the measure of the interior angles.
// Should the number be equal or less than 2, return:
// "this will be a line segment or a dot"
// Otherwise return the result in the following format:
// "This shape has s sides and each angle measures d"
// (replace s with number of sides and d with the measure of the interior angles).
// Angle measure should be floored to the nearest integer.
// Number of sides will be tested from 0 to 180.
// Have Fun!

using System;

public static class Kata
{
  public static string DescribeTheShape(int angles)
  {
    //throw new NotImplementedException();
    string line = "this will be a line segment or a dot";
    if (angles <=2)
     {
      return line;
    }
    else
      {
      int sides = angles;
      int sumAnglesAll = (sides -2)*180;
      int angleRayj = sumAnglesAll / angles;
      string polygon = "This shape has " + sides +" sides and each angle measures " + angleRayj;
      return polygon;
      
    }
    
  }
}