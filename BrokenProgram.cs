using System;

class MainClass {
  public static void Main (string[] args) {
    double a, b, c, d;

    a = Double.Parse(Console.ReadLine());
    b = Double.Parse(Console.ReadLine());
    c = Double.Parse(Console.ReadLine());

    if (a > 10) {
	    if (c < 2000) {
		    d = (a + b + c) / 12;
		    Console.WriteLine("The resule is: " + d);
	    } else {
		    Console.WriteLine("Error!");
	    }
    } else {
	    Console.WriteLine("Error!");
    }
}
}
