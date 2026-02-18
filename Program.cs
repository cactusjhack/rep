// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Universidades universidad1 = new Universidades();
var universidad2 = new Universidades();

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
    private int id = 0;
    private string nombre = "";
    private DateTime fecha = DateTime.Now;
    private bool activa = true;
    private List<Sedes> sedes;

    public Universidades() { }

    public int Id
    {
        get { return this.Id; }
        set { this.id = value; }

    }
    public String Nombre
    {
        get { return this.Nombre; }
    }
    public string Dir { get; set; }
}
