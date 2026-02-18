Console.WriteLine("Clase 17/02/2026");
Universidades universidad = new Universidades()
{
    nombre = "ITM",
    activa = false,
};

universidad.id = 1;
var temp = universidad.id;

universidad.sedes = new List<Sedes>();
universidad.sedes.Add(new Sedes() { Id = 1, Nombre = "Fraternidad" });
universidad.sedes.Add(new Sedes() { Id = 2, Nombre = "Robledo" });
universidad.sedes.Add(new Sedes() { Id = 3, Nombre = "La Floresta" });
universidad.sedes.Add(new Sedes() { Id = 4, Nombre = "CATA" });
universidad.sedes.Add(new Sedes() { Id = 5, Nombre = "Castilla" });
universidad.sedes.Add(new Sedes() { Id = 6, Nombre = "Prado" });

foreach (var elemento in universidad.sedes)
{
    Console.WriteLine("id:" + elemento.Id + "," + " Nombre:" + elemento.Nombre);
}
public class Sedes
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public decimal Capacidad { get; set; }
    public int Universidad { get; set; }

    public Universidades _Universidad { get; set; }
}

public class Universidades
{
    public int id = 0;
    public string nombre = "";
    public DateTime fecha = DateTime.Now;
    public bool activa = true;
    public List<Sedes> sedes;

    public Universidades() { }

    public int Id
    {
        get { return this.id; }
        set { this.id = value; }

    }
    public String Nombre
    {
        get { return this.nombre; }
    }
}
