using MongoDB.Bson.Serialization.Attributes;

public class AnimalesMongo {
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string? id { get; set; }
    public string Nombre_Cientifico { get; set;} = string.Empty;
    public string Nombre_Comun { get; set; } = string.Empty;
    public string Clase { get; set; } = string.Empty;
    public decimal Peso_Kg { get; set; }
    public bool Es_Carnivoro { get; set; }
    public string Habitat { get; set; } = string.Empty;
    public int Poblacion_Mundial { get; set; }
    public bool Es_Volador { get; set; }
}