using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL.EF
{
    public class BatchRepository
    {
        private readonly AppDbContext _context;

        public BatchRepository()
        {
            _context = new AppDbContext();
        }

        public IEnumerable<Batch> GetAll()
        {
            return _context.Batches.ToList();
        }

        public Batch GetById(int id)
        {
            return _context.Batches.Find(id);
        }

        public void Add(Batch batch)
        {
            _context.Batches.Add(batch);
            _context.SaveChanges();
        }

        public void Update(Batch batch)
        {
            _context.Batches.Update(batch);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var batch = _context.Batches.Find(id);
            if (batch != null)
            {
                _context.Batches.Remove(batch);
                _context.SaveChanges();
            }
        }
    }
}
