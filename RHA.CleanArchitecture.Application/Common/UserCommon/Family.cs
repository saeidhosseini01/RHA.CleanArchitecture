using RHA.CleanArchitecture.Application.Model.Base;

namespace RHA.CleanArchitecture.Application.Common.UserCommon
{
    public class Family : ValueObject
    {
        private readonly string _name;
        public string value => _name;
        public Family(string name)
        {

            checkValue(new ValueMustNotBeEmptyOrNull(name));
            checkValue(new NameLengthMustLessThanTen(name));
            _name = name;
        }
    }
}
