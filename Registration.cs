using System;

class MainClass {
  public static void Main (string[] args) {

    //Variables
    double x, y;

    Console.Write("Enter number 1 : ");
    x = Double.Parse(Console.ReadLine());

    Console.Write("Enter number 2 : ");
    y = Double.Parse(Console.ReadLine());

    //AND
    if (x >= 0 && y >= 0) {
      Console.WriteLine("Both numbers entered are positive!");
    } else if (x < 0 && y < 0) {
      Console.WriteLine("Both numbers entered are negative!");
    } else if (x >= 0 && y <0) {
      Console.WriteLine("The 1st number entered is positive!");
    } else if (x < 0 && y >=0) {
      Console.WriteLine("The 2nd number entered is positive!");
    }

    /*//OR
    if (x >= 0 || y >= 0) {
      Console.WriteLine("One of the numbers entered is positive!");
    }*/
  }
}
