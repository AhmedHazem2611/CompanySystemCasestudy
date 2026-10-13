namespace CompanySystem.Repos
{
    public interface IGenericRepo<T> where T : class
    {
        public Task Add(T item);
        public void Update(T item);
        public void Delete(T item);
        public Task<T> GetById(int Id);
        public Task<IEnumerable<T>> GetAll();
    }
}
