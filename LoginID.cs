using System;

class MainClass {
  public static void Main (string[] args) {
    
    //Variables
    string lastname, loginid1;
    int randomnumber, loginid2;

    //Input
    Console.Write("Enter your last name: ");
    lastname = Console.ReadLine();

    //String Length
    int length = lastname.Length;

    if (length <=3) {
      //Random Integer
      Random rnd = new Random();
      randomnumber = rnd.Next(100, 999);

      //Making Login ID
      loginid1 = lastname.ToLower();
      loginid2 = randomnumber;
      Console.Write("Your LoginID is: " + loginid1 + loginid2);
    } else {
      //Random Integer
    Random rnd = new Random();
    randomnumber = rnd.Next(100, 999);
    
    //Making Login ID
    loginid1 = lastname.Substring(0, 4).ToLower();
    loginid2 = randomnumber;
    Console.Write("Your LoginID is: " + loginid1 + loginid2);

    }

  }
}
