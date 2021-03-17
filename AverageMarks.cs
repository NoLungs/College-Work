using System;

class MainClass {
  public static void Main (string[] args) {
    
    //Variables
    double total, loop, iterations, value, marks;
    loop = 1;
    total = 0;

    Console.Write("How many grades do you want to enter?: ");
    iterations = Double.Parse(Console.ReadLine());
    Console.Write("How many marks was this exam out of?: ");
    marks = Double.Parse(Console.ReadLine());

    if (iterations <= 0) {
      Console.WriteLine("0 is an invalid input!");
    } else if (iterations >= 1){
    while (loop <= iterations) {
        Console.Write("Enter grade value " + loop + "(out of " + marks + "): ");
        value = Double.Parse(Console.ReadLine());
        if (value > marks) {
          Console.WriteLine("The mark which you entered is too high!");
          
        } else {
        total = total + value;
        loop++;
        }
    }
    }
    total = total / iterations;
    Console.WriteLine("The average grade for this exam was: " + total);
  
  }
}
