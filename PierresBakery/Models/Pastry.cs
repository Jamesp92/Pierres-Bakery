namespace PierresBakery.Models
{
  public class Pastry
  {
    private static double _Price = 2;
    public int Quanity {get; set;}
    
    public static double Price
    {
      get {return _Price;}
      set {_Price = value;}
    }
   public Pastry (int quanity)
   {
      _Price = Price;
      Quanity = quanity;
   }
   public double PastryCost()
    {
     double pastryTotal = 0;
     for (int i = 0; i <= Quanity; i ++)
     {
      if (i == 0)
      {
        pastryTotal += 0;
      }
      else
      {
        pastryTotal += _Price;
      }
     }
      return pastryTotal;
    }
  }
}