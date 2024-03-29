namespace ScreenSound.Modelos;

public class Musica
{
    public Musica(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; set; }
    public int Id { get; set; }
    public int? AnoDeLancamento { get; set; }
    public virtual Artista? Artista { get; set; }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}, Ano de Lançamento: {AnoDeLancamento}");
      
    }

    public override string ToString()
    {
        return @$"Id: {Id}
        Nome: {Nome}";
    }
}