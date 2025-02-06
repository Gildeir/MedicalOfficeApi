using MedicalOfficeApi.Context;
using MedicalOfficeApi.Repository.Interfaces;

namespace MedicalOfficeApi.Repository
{
    public class BaseRepository : IBaseRepository
    {
        private readonly MediaOfficeContext _context;

        public BaseRepository(MediaOfficeContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);

            _context.SaveChanges();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);

            _context.SaveChangesAsync();
        }
    }
}
