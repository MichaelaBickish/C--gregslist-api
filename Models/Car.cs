using System;
using System.ComponentModel.DataAnnotations;

namespace cars.Models
{
  public class Car
  {
    //make, model, year, price, imgUrl, description
    public Car(string make, string model, int year, int price, string imgUrl, string description)
    {

      Id = Guid.NewGuid().ToString();
      Make = make;
      Model = model;
      Year = year;
      Price = price;
      ImgUrl = imgUrl;
      Description = description;

    }
    public string Make { get; set; }
    public string Model { get; set; }

    [Range(1920, 2021)]
    public int Year { get; set; }

    [Range(0, int.MaxValue)]
    public int Price { get; set; }

    public string ImgUrl { get; set; }

    public string Description { get; set; }

    public string Id { get; set; }


  }
}