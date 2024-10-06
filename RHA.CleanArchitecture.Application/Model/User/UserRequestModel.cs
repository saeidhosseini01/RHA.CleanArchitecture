using Microsoft.Win32.SafeHandles;
using RHA.CleanArchitecture.Application.Common.UserCommon;
using RHA.CleanArchitecture.Application.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHA.CleanArchitecture.Application.Model.User
{
    public class UserRequestModel: AggregateRoot<Guid>
    {
        public Name Name { get; private set; }
        public Family Family { get; private set; }
        public UserRequestModel(string name, string family)
        {
                Name =new Name(name);
            Family=new Family(family);
        }
    }
}
