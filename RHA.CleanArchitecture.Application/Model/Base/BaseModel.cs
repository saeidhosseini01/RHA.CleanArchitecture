using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHA.CleanArchitecture.Application.Model.Base
{


    public interface IBaseModel
    {
        Guid RowGuid { get; }
    }
    public interface IBaseModel<T> : IBaseModel
    {
        T Id { get; set; }
    }

    public abstract class BaseModel<T> : IBaseModel<T>
    {
        public Guid RowGuid { get; set; }

        public T Id { get; set; }
    }
    public abstract class BaseModel : BaseModel<long>
    {

    }
}
