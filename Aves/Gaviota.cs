namespace Aves;

public class Gaviota : Aves
{
    public override string Volar()
    {
        return "Estoy volando...";
    }
    public override string Nadar()
    {
        return "No puedo nadar...";
    }
    public override string Comer()
    {
        return "Estoy comiendo...";
    }
    public override string Correr()
    {
        return "Estoy corriendo...";
    }
    public override string Cantar()
    {
        return "No me sé ninguna canción...";
    }
    public override void SetTipo(string tipo)
    {
        Tipo = tipo;
    }
}
