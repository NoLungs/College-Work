using System;

class MainClass {
  public static void Main (string[] args) {
    string s, s_reversed;

    Console.Write("Enter a word with four letters: ");
    s = Console.ReadLine();

    s_reversed = "" + s[3] + s[2] + s[1] + s[0];

    Console.WriteLine(s_reversed);
  }
}
