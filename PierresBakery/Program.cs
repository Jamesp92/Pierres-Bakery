using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("welcome");
      Menu();
    }
      public static void Menu()
      {

      Console.WriteLine("welcome to Pierres Bakery!");
      Console.WriteLine("would you like to order pastry or bread?");
      string pastryOrBread =  Console.ReadLine().ToLower();
      
      if (pastryOrBread == "pastry")
      {
        Console.WriteLine( "we have a great deal on pastries !");
        Console.WriteLine( " 1 pastry is $2 , 3 for $5 , 4 for $7, 5 for $9 or 6 for $10 ! ");
        int pastryAmount = int.Parse(Console.ReadLine());
        Pastry PastryOrder = new Pastry(pastryAmount);
        Console.WriteLine("Great!" + " " + PastryOrder.Quantity + " " + "pastries" + " " + "will be $" + PastryOrder.PastryCost());
        Console.WriteLine("would you like to buy anything else ? Y/N?");
        string nextStep = (Console.ReadLine().ToLower());

        if (nextStep == "y")
        {
          Menu();
        }

      }
      else if (pastryOrBread =="bread")
        {
          Console.WriteLine(" We have the best deals on bread in the city !");
          Console.WriteLine("each loaf of bread is $" + Bread.Price + " " + " if you buy 2 you get one free !");
         int breadAmount = int.Parse(Console.ReadLine());
        Bread BreadOrder = new Bread(breadAmount);
        Console.WriteLine("Great!" + " " + BreadOrder.Quantity + " " + "loaves" + " " + "will be $" + BreadOrder.BreadCost());
        Console.WriteLine("would you like to buy anything else ? Y/N?");
        string nextStep = (Console.ReadLine().ToLower());
        if (nextStep == "y")
        {
          Menu();
        }
      }
     }
  }
}