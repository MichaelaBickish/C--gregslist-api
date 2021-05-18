
using System;
using System.Collections.Generic;
using cars.DB;
using cars.Models;
using cars.Services;
using Microsoft.AspNetCore.Mvc;

namespace cars.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CarsController : ControllerBase
  {
    private readonly CarsService _service;
    public CarsController(CarsService service)
    {
      _service = service;
    }


    //Get
    [HttpGet]
    public ActionResult<IEnumerable<Car>> GetAll()
    {
      try
      {
        return Ok(FakeDB.Cars);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    //Get by ID
    [HttpGet("{id}")]
    public ActionResult<Car> GetById(string id)
    {
      try
      {
        Car found = _service.GetById(id);
        return Ok(found);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    //Post Create
    [HttpPost]
    public ActionResult<Car> Create([FromBody] Car newCar)
    {
      try
      {
        Car car = _service.Create(newCar);
        return Ok(car);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    //Put
    [HttpPut("{id}")]
    public ActionResult<Car> Edit([FromBody] Car editCar, string id)
    {
      try
      {
        editCar.Id = id;
        Car car = _service.Edit(editCar);
        return Ok(car);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    //Delete
    [HttpDelete("{id}")]
    public ActionResult<string> DeleteCar(string id)
    {
      try
      {
        _service.DeleteCar(id);
        return Ok("Deleted Successfully");
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }


}