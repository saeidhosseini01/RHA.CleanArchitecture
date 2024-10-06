using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHA.CleanArchitecture.Application.Model.Base
{







    public abstract class AggregateRoot<TKey>
    {
        TKey ID { get; set; }
        public DateTime  CreateAt { get; set; }
        public DateTime?  ModifiedAt { get; set; }
        public int CreateBy { get; set; }
        public int? ModifiedBy { get; set; }
    }
   
}
