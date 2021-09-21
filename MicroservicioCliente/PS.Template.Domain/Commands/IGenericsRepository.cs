namespace PS.Template.Domain.Commands
{
    public interface IGenericsRepository
    {
        public void Add<T>(T entity) where T : class;
    }
}
