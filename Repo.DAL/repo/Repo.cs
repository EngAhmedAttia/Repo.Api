using Data;
using Repo.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.DAL.repo
{ 
    public class Repo<T> : Irepo<T> where T : class
    {
        protected private AppDbContext _context;

        public Repo(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<T> GetAll()
        {
           return _context.Set<T>().ToList();
        }
    }
}
