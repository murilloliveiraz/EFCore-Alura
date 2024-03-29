using ScreenSound.Banco;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Service<Artista> service)
    {
        Console.WriteLine("Tchau tchau :)");
    }
}
