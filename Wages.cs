using System;

class MainClass {
  public static void Main (string[] args) {
    
    //Variables
    double pay, payandhalf, hoursworked, payandhalfhours, totalpay, payandhalftotal, paytotal, paytax;

    pay = 12.50;
    payandhalf = 18.75;

    //Input
    Console.Write("How many hours did you work this week?: ");
    hoursworked = Double.Parse(Console.ReadLine());
    
    //how much moni
    if (hoursworked <=37) {
      totalpay = hoursworked * pay;
      Console.WriteLine("Your pay without tax taken is: £" + totalpay);
      //ew tax
      paytax = totalpay - (totalpay * 0.25);
      Console.WriteLine("Your pay with tax taken is: £" + paytax);
    }else if (hoursworked >37) {
      payandhalfhours = hoursworked - 37;
      payandhalftotal = payandhalfhours *payandhalf;
      paytotal = 37 * pay;
      totalpay = paytotal + payandhalftotal;
      Console.WriteLine("Your pay without tax taken is: £" + totalpay);
      //ew tax
      paytax = totalpay - (totalpay * 0.25);
      Console.WriteLine("Your pay with tax taken is: £" + paytax);
    }
  }
}
