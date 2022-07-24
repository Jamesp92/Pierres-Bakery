namespace PierresBakery.Models
{
  public class Bread
  {
    private static double _Price = 5;
    public int Quantity {get; set;}
    public double _Discount;

    public static double Price
    {
      get {return _Price;}
      set {_Price = value;}
    }
    
    public Bread (int quantity)
    {
      _Price = Price;
      Quantity = quantity;
      _Discount = 0;

    }

    public double BreadCost()
    {
     double breadTotal = 0;
     for (int i = 0; i <= Quantity; i ++)
     {
      if (i == 0)
      {
        breadTotal += 0;
      }
      if (i % 3 == 0)
      {
        breadTotal += _Price * _Discount;
      }
      else
      {
        breadTotal += _Price;
      }
     }
      return breadTotal;
    }
  }
}


