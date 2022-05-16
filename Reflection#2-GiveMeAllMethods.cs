// Now, we can go deeper.
// You get an object and should return the names of all(!) methods, that you found for the object.
// The code of this object:
// using System;
// public class Refl 
// {
//   static void Main(string[] args) 
//   { 
//     Console.WriteLine(new Refl().Output());
//     Console.WriteLine(new Refl().AddInts(1,2));
//   } 
//   public string Output()
//   {
//     return "Test-Output";
//   }
//   public int AddInts[n](int i1, int i2) 
//   {
//     return i1 + i2;
//   }
// }
// For using random, the Name of the AddInts-Methods has an additonal number at the end. For null return an empty string array!
// Have fun coding it and please don't forget to vote and rank this kata! :-)



using System;
using System.Reflection;
using System.Linq;
using System.Runtime.Serialization;

public static class Reflection
{
  public static string[] GetMethodNames(object TestObject)
  { 
            if (TestObject == null) return new string[0];
            Type type = TestObject.GetType();
            MethodInfo[] methods = TestObject.GetType().GetRuntimeMethods().ToArray();
            string[] result = new string[methods.Length];
            int n = 0; 
            foreach(MethodInfo p in methods)
            {
                result[n] = p.Name.ToString();
                n++; 
            }
            return result;
  }
}