using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedKernel.Persistence
{
    public interface ISoftDeleteEntity<T>: IBaseEntity<T> where T : Type
    {
        bool IsDeleted { get; set; }
    }
}
