using System.Collections.Generic;
using DTO;
using DAL.EF;

namespace BLL
{
    public class BatchService
    {
        private readonly BatchRepository _repository;

        public BatchService()
        {
            _repository = new BatchRepository();
        }

        public IEnumerable<Batch> GetAll()
        {
            return _repository.GetAll();
        }

        public Batch GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Add(Batch batch)
        {
            _repository.Add(batch);
        }

        public void Update(Batch batch)
        {
            _repository.Update(batch);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
