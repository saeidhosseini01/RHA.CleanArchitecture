using RHA.CleanArchitecture.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHA.CleanArchitecture.Application.Common.UserCommon
{
    public class ValueMustNotBeEmptyOrNull : IBusinessRule
    {
        private readonly string _value;
        public ValueMustNotBeEmptyOrNull(string value)
        {
                _value = value;
        }
        public string Message => throw new NotImplementedException();

        public bool HasValidRule()
        {
           var valid=string.IsNullOrEmpty(_value);
            return valid;
        }
    }
}
