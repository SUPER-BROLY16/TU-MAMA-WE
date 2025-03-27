using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System.Data;

[ApiController]
[Route("conexion")]
public class Conexion : Controller{
    [HttpGet("mongo")]
    public IActionResult AnimalesMongoDB(){
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("COAHUILA");
        var collection = db.GetCollection<AnimalesMongo>("MIRADORES");

        var lista = collection.Find(FilterDefinition<AnimalesMongo>.Empty).ToList();
        return Ok(lista);
    }
}