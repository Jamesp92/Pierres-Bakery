namespace PierresBakery.Models
{
  public class Bread
  {
    private static double _Price = 5;
    public int Quanity {get; set;}
    public double _Discount;

    public static double Price
    {
      get {return _Price;}
      set {_Price = value;}
    }
    
    public Bread (int quanity)
    {
      _Price = Price;
      Quanity = quanity;
      _Discount = 0;

    }

    public double BreadCost()
    {
     double breadTotal = 0;
     for (int i = 0; i <= Quanity; i ++)
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


