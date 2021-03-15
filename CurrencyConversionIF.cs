using System;

class MainClass {
  public static void Main (string[] args) {
    
    //Variables
    double eur, usd, jpy, nzd, transferamount, moneygiven, loop, currency;

    eur = 1.17;
    usd = 1.39;
    jpy = 150.74;
    nzd = 1.94;
    loop = 1;

    while (loop == 1) {
      Console.Write("How much money do you want to transfer?: ");
      transferamount = Double.Parse(Console.ReadLine());
      if (transferamount > 4000 || transferamount <= 0) {
        Console.WriteLine("The amount entered is invalid!");
        loop = 1;
      } else {
        Console.Write("What currency would you like to transfer to? \n 1. Convert GBP to Euro (EUR) \n 2. Convert GBP to US Dollars (USD) \n 3. Convert GBP to Japanese Yen (JPY) \n 4. Convert GBP to New Zealand Dollars (NZD): ");
        currency = Double.Parse(Console.ReadLine());
        if (currency == 1) {
          moneygiven = transferamount * eur;
          moneygiven = Math.Round(moneygiven, 2);
          Console.WriteLine("You will recieve €" + moneygiven);
          loop = 0;
        } else if (currency == 2) {
          moneygiven = transferamount * usd;
          moneygiven = Math.Round(moneygiven, 2);
          Console.WriteLine("You will recieve $" + moneygiven);
          loop = 0;
        } else if (currency == 3) {
          moneygiven = transferamount * jpy;
          moneygiven = Math.Round(moneygiven, 2);
          Console.WriteLine("You will recieve ¥" + moneygiven);
          loop = 0;
        } else if (currency == 4) {
          moneygiven = transferamount * nzd;
          moneygiven = Math.Round(moneygiven, 2);
          Console.WriteLine("You will recieve $" + moneygiven);
          loop = 0;
        } else {
          Console.WriteLine("The currency entered is invalid!");
          loop = 1;
        }
        }
      }
    }
  }
