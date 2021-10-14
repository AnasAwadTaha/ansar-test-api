using ansar_group_task.Data.Model;
using ansar_group_task.Data.Repositores;
using ansar_group_task.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ansar_group_task.Services
{
    
    public class RegisterServices 
    {
        private readonly RegisterRepository _repository;
        public RegisterServices(RegisterRepository repository)
        {
            _repository = repository;
        }

        public Register Reqister(RegisterVM model)
        {
            var Entity = new Register()
            {
                Username = model.Username,
                Password = model.Password,
                Email = model.Email
            };
            _repository.Insert(Entity);
            return Entity;
        }
        public async Task<Register> Find(string register)
        {
            var _reqister = _repository.Find(register);
            
            return  _reqister;
        }

    }
}
