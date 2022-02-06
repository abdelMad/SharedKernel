using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedKernel.Persistence
{
    public interface IAuditibleEntity<T,AuditorType> : IBaseEntity<T> where T : Type
    {
        DateTime CreateDate { get; set; }
        DateTime UpdateDate { get; set; }

        AuditorType CreatedBy { get; set; }
        AuditorType UpdatedBy { get; set; }


    }
}
