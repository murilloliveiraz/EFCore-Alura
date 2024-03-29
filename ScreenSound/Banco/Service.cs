using ScreenSound.Modelos;

namespace ScreenSound.Banco
{
    internal class Service<T> where T : class
    {
        protected readonly ScreenSoundContext context;

        public Service(ScreenSoundContext context)
        {
            this.context = context;
        }
        public IEnumerable<T> Get()
        {
            return context.Set<T>().ToList();
        }

        public T? GetBy(Func<T, bool> condicao)
        {
            return context.Set<T>().FirstOrDefault(condicao);
        }
        public IEnumerable<T> GetAllBy(Func<T, bool> condicao)
        {
            return context.Set<T>().Where(condicao);
        }

        public void Create(T element)
        {
            context.Set<T>().Add(element);
            context.SaveChanges();
        }

        public void Update(T element)
        {
            context.Set<T>().Update(element);
            context.SaveChanges();
        }

        public void Delete(T element)
        {
            context.Set<T>().Remove(element);
            context.SaveChanges();
        }
    }
}
