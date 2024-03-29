using ScreenSound.Modelos;

namespace ScreenSound.Banco
{
    internal class ArtistaCRUD : Service<Artista>
    {
        public ArtistaCRUD(ScreenSoundContext context): base(context) { }
    }
}
