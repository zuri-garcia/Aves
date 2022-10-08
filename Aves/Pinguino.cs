namespace Aves;
public class Pinguino : Aves
{
    public Pinguino (string color)
    {
        Color = color;
    }
    public override string Cantar()
    {
        return "No sé cantar...";
    }

    public override string Comer()
    {
        return "Estoy comiendo...";
    }

    public override string Correr()
    {
        return "Estoy corriendo...";
    }

    public override string Nadar()
    {
        return "Estoy nadando...";
    }

    public override void SetTipo(string tipo)
    {
        Tipo = tipo;
    }

    public override string Volar()
    {
        return "No sé volar...";
    }
}
