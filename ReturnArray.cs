using System;

public class ReturnArray {
   public static void Main() {
      Console.WriteLine(string.Join(" ", display()));
   }
   static string[] display() {
      string[] str = new string[4];

      str[0] = "My";
      str[1] = "name";
      str[2] = "is";
      str[3] = "Gaurav";
  
      return str;
   }
}