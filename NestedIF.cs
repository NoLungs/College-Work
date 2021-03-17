using System;

class MainClass {
  public static void Main (string[] args) {
    
    //Variables
    double a, b, c, d, y;

    Console.Write("Enter the first number: ");
    a = Double.Parse(Console.ReadLine());
    Console.Write("Enter the second number: ");
    b = Double.Parse(Console.ReadLine());

    c = a % 2;
    d = b / 5;
    y = 0;

    if ( a >= b) {
      y = 1;
    } else if (a < b) {
      if (d > c && a > 2){
        y = 2;
      } else if (d < c || a < 2){
        if (d * c > a / b){
          if (d * c > 10) {
            y = 4;
          } else {
            y = 3;
         }
        } else {
          y = 5;
        }
      }
    Console.WriteLine(y);
  }
 }
}
