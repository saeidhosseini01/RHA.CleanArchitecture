using RHA.CleanArchitecture.Application.Services;

namespace RHA.CleanArchitecture.Application.Common.UserCommon
{
    public class NameLengthMustLessThanTen : IBusinessRule
    {
        private readonly string _value;
        public NameLengthMustLessThanTen(string value)
        {
            _value = value;
        }
        public string Message => throw new NotImplementedException();

        public bool HasValidRule()
        {
            var valid = _value.Length > 10;
            return valid;
        }
    }
}
