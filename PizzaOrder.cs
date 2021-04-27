using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

class MainClass {
  public static void Main (string[] args) {
    
	//Inputs
	string CustomerName, CustomerAddress, Delivery, CustomerNumber1;
	int QtyPizza, ToppingList1;
  long CustomerNumber, CustomerName1;
	double ToppingsPrice = 0, Cost = 0;
  int Count = 1;
  int i = 0;
  //Cost Variables
  double SmallCost = 3.25, MedCost = 5.50, LarCost = 7.15, CostOfPizza = 0, TotalCost = 0; 
	
  //Customer Name
  CustomerNameLoop:
	Console.Write("What is the customers name? ");
	CustomerName = Console.ReadLine();
  if (Int64.TryParse(CustomerName, out CustomerName1)) {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Invalid Input.");
      Console.ForegroundColor = ConsoleColor.White;
      goto CustomerNameLoop;
  }
  //Customer Address
	Console.Write("What is the customers address?: ");
	CustomerAddress = Console.ReadLine();
  //Customer Phone Number
  PhoneNumLoop:
	Console.Write("What is the customers phone number?: ");
	CustomerNumber1 = (Console.ReadLine());
  if (!Int64.TryParse(CustomerNumber1, out CustomerNumber)) {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Invalid Input.");
      Console.ForegroundColor = ConsoleColor.White;
      goto PhoneNumLoop;
    } else {
      if (CustomerNumber1.Length != 11) {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid Input.");
        Console.ForegroundColor = ConsoleColor.White;
        goto PhoneNumLoop;
    }
  }
  //Quantity of pizzas being ordered.
	QtyPizzaLoop:
	Console.Write("How many pizzas are the customer ordering?: ");
	QtyPizza = Int32.Parse(Console.ReadLine());
	if (QtyPizza > 6) {
    Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("Invalid Input! Please enter a value below 6.");
    Console.ForegroundColor = ConsoleColor.White;
		goto QtyPizzaLoop;
	}

  //Declaring Arrays.
  string[] PizzaList = new string[QtyPizza];
  string[] ToppingList = new string[QtyPizza];

  //Pizza Array
  do {
    PizzaSizeLoop:
    Console.Write("What size pizza would the customer like?(small, medium or large): ");
    PizzaList[i] = Console.ReadLine();
    if (PizzaList[i] == "small" || PizzaList[i] == "medium" || PizzaList[i] == "large") {
      Console.WriteLine("");
    } else {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Invalid Input!");
      Console.WriteLine("Please enter either small, medium or large");
      Console.ForegroundColor = ConsoleColor.White;
      goto PizzaSizeLoop;
    }

    //Toppings
    QtyToppingsLoop:
    Console.Write("How many extra toppings does the customer want?: ");
    ToppingList[i] = Console.ReadLine();
    if (ToppingList[i] == "1") {
      ToppingsPrice = 0.75;
    } else if (ToppingList[i] == "2") {
      ToppingsPrice = 1.25;
    } else if (ToppingList[i] == "3") {
      ToppingsPrice = 2.00;
      
    } else if (Int32.TryParse(ToppingList[i], out ToppingList1)) { 
      if (ToppingList1 >= 4) {
        ToppingsPrice = 2.50;
      }
    } else if (ToppingList[i] == "0") {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Invalid Input!");
      Console.ForegroundColor = ConsoleColor.White;
	  	goto QtyToppingsLoop;
    }

    //Cost of pizza
    if (PizzaList[i] == "small") {
      CostOfPizza = SmallCost + ToppingsPrice;
      CostOfPizza = Math.Round(CostOfPizza, 2);
      TotalCost = TotalCost + CostOfPizza;
      TotalCost = Math.Round(TotalCost, 2);
    } else if (PizzaList[i] == "medium") {
      CostOfPizza = MedCost + ToppingsPrice;
      CostOfPizza = Math.Round(CostOfPizza, 2);
      TotalCost = TotalCost + CostOfPizza;
      TotalCost = Math.Round(TotalCost, 2);
    } else if (PizzaList[i] == "large") {
      CostOfPizza = LarCost + ToppingsPrice;
      CostOfPizza = Math.Round(CostOfPizza, 2);
      TotalCost = TotalCost + CostOfPizza;
      TotalCost = Math.Round(TotalCost, 2);
    }
    i++;
    QtyPizza--;
  
   } while (Count <= QtyPizza);
	//Asking if customer wants delivery
  DeliveryLoop:
	Console.Write("Does the customer want delivery?: ");
	Delivery = Console.ReadLine();
  Delivery = Delivery.ToLower();
  if (Delivery == "yes " || Delivery == "y") {
    Console.WriteLine("The cost for delivery is £2.50");
    TotalCost = TotalCost + 2.50;
  } else if (Delivery == "no" || Delivery == "n"){
    TotalCost = TotalCost + 0;
  } else {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Invalid input!");
    Console.WriteLine("Please enter either yes or no.");
    Console.ForegroundColor = ConsoleColor.White;
    goto DeliveryLoop;
  }

  //Recipt
  Console.Clear();
  Console.WriteLine("Complete bill: ");
  Console.WriteLine("Name: " + CustomerName);
  Console.WriteLine("Address: " + CustomerAddress);
  Console.WriteLine("Phone Number: " + CustomerNumber);
  var itemtopping = PizzaList[i].Zip(ToppingList, (n, w) => new {Number = n, Word = w});
  foreach (var item in itemtopping) {
    Console.WriteLine(item.Number + " pizza and " + item.Word + " toppings! ");
  }
  Cost = TotalCost;
  if (TotalCost > 20) {
    Cost = (TotalCost / 100) * 90;
    Cost = Math.Round(Cost, 2);
    Console.WriteLine("Your discount is: £" + (TotalCost - Cost));
    if (Delivery == "yes " || Delivery == "y") {
      Console.WriteLine("Delivery Cost: £2.50");
    }
    Console.WriteLine("Total Cost: £" + Cost);
  } else {
    if (Delivery == "yes " || Delivery == "y") {
      Console.WriteLine("Delivery Cost: £2.50");
    }
    Console.WriteLine("Total Cost: £" + Cost);
    
  }
  }
}