using ApiDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiDemo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ShirtController: ControllerBase
{
    [HttpGet]
    public string GetShirts()
    {
        return "Reading all shirts";
        
    }

    
    [HttpGet("{id}")]
    
    public string GetShirtsById(int id, [FromHeader(Name = "color")]string color)
    {
        return $"You are reading shirt {id} with color: {color}";
    }
    
    [HttpPost]
    public string CreateShirt([FromBody]Shirt shirt)
    {
        return $"Creating shirts {shirt.Color}";
    }

    [HttpPut("{id}")]
    public string UpdateShirtsById(int id)
    {
        return $"updating shirt {id}";
    }

    [HttpDelete ("{id}")]
    public string DeleteShirt(int id)
    {
        return $"Shirts is deleted {id}";
    }
    
    

}