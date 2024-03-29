namespace ScreenSound.Modelos; 

public class Artista 
{
    public virtual ICollection<Musica> Musicas { get; set; } = new List<Musica>();

    public Artista(string nome, string bio)
    {
        Nome = nome;
        Bio = bio;
        FotoPerfil = "https://s2-oglobo.glbimg.com/RGhnQBKhI5zrPBborlB2vpA8LiM=/0x217:1500x1516/888x0/smart/filters:strip_icc()/i.s3.glbimg.com/v1/AUTH_da025474c0c44edd99332dddb09cabe8/internal_photos/bs/2022/d/2/8ABViBQAuBfO8r2mIxRA/caetano-vale.jpg";
    }

    public string Nome { get; set; }
    public string FotoPerfil { get; set; }
    public string Bio { get; set; }
    public int Id { get; set; }

    public void AdicionarMusica(Musica musica)
    {
        Musicas.Add(musica);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia do artista {Nome}");
        foreach (var musica in Musicas)
        {
            Console.WriteLine($"Música: {musica.Nome} - Ano de Lançamento: {musica.AnoDeLancamento}");
        }
    }

    public override string ToString()
    {
        return $@"Id: {Id}
            Nome: {Nome}
            Foto de Perfil: {FotoPerfil}
            Bio: {Bio}";
    }
}