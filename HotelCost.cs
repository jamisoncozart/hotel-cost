using System;

class HotelCost
{
  static void Main()
  {
    Console.WriteLine("What season will you be booking your stay with us? (winter, spring, summer, fall)");
    string season = Console.ReadLine();
    
    Console.WriteLine("Will you be booking on a weekend, or a weekday?");
    string dayOfWeek = Console.ReadLine();

    bool summer = season == "summer";
    bool weekend = dayOfWeek == "weekend";

    if(summer && weekend)
    {
      Console.WriteLine("Your stay is going to be REALLY expensive!");
    }
    else if(summer || weekend)
    {
      Console.WriteLine("Your stay is going to be expensive!");
    }
    else
    {
      Console.WriteLine("Your stay is going to be cheap!");
    }
  }
}