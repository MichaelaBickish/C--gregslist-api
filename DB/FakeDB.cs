using System.Collections.Generic;
using cars.Models;

namespace cars.DB
{
  public static class FakeDB
  {
    public static List<Car> Cars { get; set; } = new List<Car>(){
        new Car("Jeep", "Liberty", 2008, 3900, "https://cars.usnews.com/static/images/Auto/izmo/291027/2008_jeep_liberty_angularfront.jpg", "beep beep, jeep")
    };
  }
}