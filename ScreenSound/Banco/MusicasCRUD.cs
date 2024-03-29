using ScreenSound.Modelos;

namespace ScreenSound.Banco
{
    internal class MusicasCRUD : Service<Musica>
    {
        public MusicasCRUD(ScreenSoundContext context): base(context) { }
    }
}
