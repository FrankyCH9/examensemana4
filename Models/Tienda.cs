public class Tienda
{
    public string _id { get; set; }
    public string dueño { get; set; }
    public string d_email { get; set; }
    public List<Clientes> clientes{ get; set; } // Agrega esta propiedad
}


public class Clientes {
    public string correo { get; set; }
    public string password { get; set; }
    public string pais { get; set; }
    public string _id { get; set; }
    // Agrega más propiedades según tu estructura de datos
}