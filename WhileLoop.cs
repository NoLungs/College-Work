using System;

class MainClass {
  public static void Main (string[] args) {
    
    //Variables
    
    double number, loop, iterations;
    loop = 1;
    Console.Write("How many times do you want to run the program?: ");
    iterations = Double.Parse(Console.ReadLine());

    while (loop <= iterations) {
      Console.Write("Enter a number: ");
      number = Double.Parse(Console.ReadLine());

      if (number % 2 != 0) {
        Console.WriteLine(number + " is an odd number! \n");
      } else {
        Console.WriteLine(number + " is an even number! \n");
      }
      loop = loop + 1;
    } 
    
  }
}
