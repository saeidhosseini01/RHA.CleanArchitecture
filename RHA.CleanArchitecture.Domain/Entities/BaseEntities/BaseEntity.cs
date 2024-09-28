using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHA.CleanArchitecture.Domain.Entities.BaseEntities
{


    public interface IBaseEntity
    {
        public long Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public Guid RowGuid { get; set; }
        void Deleted();
    }

}
