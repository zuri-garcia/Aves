using Aves;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("~ GAVIOTA ~ ");
        var gaviota = new Gaviota();
        gaviota.SetTipo("Aérea");
        Console.WriteLine(gaviota.Volar());
        Console.WriteLine(gaviota.Nadar());
        Console.WriteLine(gaviota.Comer()); 
        Console.WriteLine(gaviota.Correr());
        Console.WriteLine(gaviota.Cantar());

        Console.WriteLine("");
        Console.WriteLine("~ PINGÜINO ~ ");
        var pingüino = new Pinguino("Rojo");
        pingüino.SetTipo("Marino");
        Console.WriteLine(pingüino.Volar());
        Console.WriteLine(pingüino.Nadar());
        Console.WriteLine(pingüino.Comer());
        Console.WriteLine(pingüino.Correr());
        Console.WriteLine(pingüino.Cantar());
    }
}
