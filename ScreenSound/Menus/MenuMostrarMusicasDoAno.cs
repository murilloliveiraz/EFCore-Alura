using ScreenSound.Banco;
using ScreenSound.Modelos;

namespace ScreenSound.Menus
{
    internal class MenuMostrarMusicasDoAno : Menu
    {
        public override void Executar(Service<Artista> service)
        {
            ExibirTituloDaOpcao("Exibir detalhes do artista");
            Console.Write("Digite o ano que Deseja conhecer as músicas: ");
            int ano = int.Parse(Console.ReadLine()!);
            var musicaService = new Service<Musica>(new ScreenSoundContext());
            var musicas = musicaService.GetAllBy(m => m.AnoDeLancamento == ano);
            if (musicas.Count() > 0)
            {
                Console.WriteLine("\nDiscografia:");
                foreach (var musica in musicas)
                {
                    musica.ExibirFichaTecnica();
                }
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nNenhuma musica lançada n {ano} foi encontrado!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
