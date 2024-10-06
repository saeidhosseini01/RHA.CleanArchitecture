using RHA.CleanArchitecture.Application.Model.Base;

namespace RHA.CleanArchitecture.Application.Common.UserCommon
{
    public class Name : ValueObject
    {
        private readonly string _name;
        public string value=>_name;
        public Name(string name)
        {

            checkValue(new ValueMustNotBeEmptyOrNull(name));
            checkValue(new NameLengthMustLessThanTen(name));
            _name= name;
        }
    }
}
