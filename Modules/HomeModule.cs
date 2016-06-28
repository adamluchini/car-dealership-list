using Nancy;
using CarDealership.Objects;
using System.Collections.Generic;

namespace CarDealership
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["list_form.cshtml"];
      Get["car_inventory"] = _ => {
        List<Car> allCars = Car.GetAll();
        return View ["car_inventory.cshtml", allCars];
      };
      Post["/car_inventory"] = _ => {
        Car newCar = new Car
        (
        Request.Form["new-make"],
        Request.Form["new-model"],
        Request.Form["new-mileage"],
        Request.Form["new-price"]
        );
        newCar.Save();
        return View["car_inventory.cshtml", newCar];
      };
    }
  }
}
