namespace MyFirstMvc.Data.Repositories
{
    public interface IRepository<TEntity, TEntityDto>
    {
        IList<TEntity> GetAll();

        void Create(TEntityDto entityDto);
    }
}
