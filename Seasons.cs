using System;

class MainClass {
  public static void Main (string[] args) {
    
    //Variables
    int Month, loop;

    loop = 1;
    //If Statement
    while (loop == 1) {
      //User Input
    Console.Write("What month of the year is it?(1-12): ");
    Month = int.Parse(Console.ReadLine());
    if (Month == 1 || Month == 2 || Month == 12) {
      Console.WriteLine("The season is: Winter!");
      loop = 0;
    } else if (Month == 3 || Month == 4 || Month == 5) {
      Console.WriteLine("The season is: Spring!");
      loop = 0;
    } else if (Month == 6 || Month == 7 || Month == 8) {
      Console.WriteLine("The season is: Summer!");
      loop = 0;
    } else if (Month == 9 || Month == 10 || Month == 11) {
      Console.WriteLine("The season is: Autumn!");
      loop = 0;
    } else {
      Console.WriteLine("That is an invalid Month!");
      loop = 1;
    }
    }
}
}