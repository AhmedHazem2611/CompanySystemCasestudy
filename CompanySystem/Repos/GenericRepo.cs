
using CompanySystem.Models;
using Microsoft.EntityFrameworkCore;

namespace CompanySystem.Repos
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly AppDbContext context;
        public GenericRepo(AppDbContext context)
        {
            this.context = context;
        }
        public async Task Add(T item)
        {
            await context.Set<T>().AddAsync(item);
        }

        public void Delete(T item)
        {
            context.Set<T>().Remove(item);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int Id)
        {
            return await context.Set<T>().FindAsync(Id);
        }

        public void Update(T item)
        {
            context.Set<T>().Update(item);  
        }
    }
}
