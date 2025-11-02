namespace MyFirstMvc.Data.Repositories
{
    public interface IRepository<TEntity>
    {
        IList<TEntity> GetAll();
    }
}
