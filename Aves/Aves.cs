namespace Aves;

public abstract class Aves
{
    public string Color { get; set; }
    public string Tipo { get; set; }
    public string Tamaño { get; set; }
    public string Alimentación { get; set; }
    public abstract string Volar();
    public abstract string Nadar();
    public abstract string Comer();
    public abstract string Correr();
    public abstract string Cantar();
    public abstract void SetTipo(string tipo);
}
