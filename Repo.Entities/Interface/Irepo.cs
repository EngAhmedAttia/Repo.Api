using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Entities.Interface
{
    public interface Irepo<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
