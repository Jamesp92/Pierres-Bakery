namespace PierresBakery.Models
{
  public class Pastry
  {
    private static double _Price = 2;
    public int Quantity {get; set;}
    private double _Discount;

    public static double Price
    {
      get {return _Price;}
      set {_Price = value;}
    }
   public Pastry (int quantity)
   {
      _Price = Price;
      Quantity = quantity;
      _Discount = 1;
   }
    public double PastryCost()
    {
      double pastryTotal = Quantity*2;
      for (int index = 1; index <= Quantity; index++)
      {
        if (index % 3 == 0)
        {
          pastryTotal -= _Discount;
        }
      }
      return pastryTotal;
    }
  } 
  }
