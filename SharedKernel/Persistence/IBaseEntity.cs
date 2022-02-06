using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedKernel.Persistence
{
    public interface IBaseEntity<T> where T : Type
    {
        public T Id { get; set; }
    }
}
