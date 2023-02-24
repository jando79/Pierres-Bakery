namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadNumber;
    
    public Bread(string stringBreadNumber)  
    {
      BreadNumber = int.Parse(stringBreadNumber);
    }

    public int BreadPrice()
    {
      int counter = 0;
      if (BreadNumber <= 2)
      {
       counter = BreadNumber*5;
      } else {
        counter = BreadNumber*5;
      for (int i=1; i < BreadNumber - 1; i+=3)
      {
        counter -= 5;
      }
      }
      return counter;
    }
  }

   public class Pastry
   {
     public int PastryNumber;
     public Pastry(string stringPastryNumber)
    {
       PastryNumber = int.Parse(stringPastryNumber);
    }

    public int PastryPrice()
    {
      int counter = 0;
      if (PastryNumber <= 2)
      {
       counter = PastryNumber*2;
      } else {
        counter = PastryNumber*2;
      for (int i=1; i < PastryNumber - 1; i+=4)
      {
        counter -= 2;
      }
      }
      return counter;
    }
  }
}