// Write a function that will check if two given characters are the same case.
// If either of the characters is not a letter, return -1
// If both characters are the same case, return 1
// If both characters are letters, but not the same case, return 0
// Examples
// 'a' and 'g' returns 1
// 'A' and 'C' returns 1
// 'b' and 'G' returns 0
// 'B' and 'g' returns 0
// '0' and '?' returns -1

using System.Linq;

public class Kata {
  public static int SameCase(char a, char b) {
    
    if (!char.IsLetter(a) || !char.IsLetter(b))
      return -1;
    return char.IsLower(a) == char.IsLower(b) ? 1 : 0;
  }
}