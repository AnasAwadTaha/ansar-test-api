using ansar_group_task.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ansar_group_task.Data.Repositores
{
    public class RegisterRepository : IGenericRepository<Register>
    {
        private readonly ApplicationDbContext _dbContext;
        public RegisterRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Delete(int Id)
        {
            var Entity = _dbContext.Set<Register>().Find(Id);
            _dbContext.Remove(Entity);
            Save();
            Save();
        }
        public Register Get(int id)
        {
            var Entity = _dbContext.Set<Register>().Find(id);
            return Entity;
        }
        public IEnumerable<Register> GetAll()
        {
            return _dbContext.Set<Register>().ToList();
        }
        public void Insert(Register entity)
        {
            _dbContext.Set<Register>().Add(entity);
            Save();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
        public void Update(int Id, Register entity)
        {
            var OldEntity = Get(Id);
            if (OldEntity != null)
            {
                Delete(Id);
                Insert(entity);
            }
            else return;
        }
        public Register Find(string register)
        {
            return _dbContext.Set<Register>().Where(n =>n.Username == register).FirstOrDefault();
        }
    }
}
