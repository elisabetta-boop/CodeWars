// Usually when you buy something, you're asked whether your credit card number, phone number or answer to your most secret question is still correct. However, since someone could look over your shoulder, you don't want that shown on your screen. Instead, we mask it.
// Your task is to write a function maskify, which changes all but the last four characters into '#'.

public static class Kata
{
  // return masked string
  public static string Maskify(string cc)
  {
    char replacement = '#';

    char[] chars = cc.ToCharArray();
    
    for(int i = 0; i< chars.Length-4; i++)
      {
      chars[i] = replacement;
    }
        
    string str = new string(chars);
    return str;
 
    }
  }