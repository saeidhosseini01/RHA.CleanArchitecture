using RHA.CleanArchitecture.Application.Services;

namespace RHA.CleanArchitecture.Application.Model.Base
{
    public abstract class ValueObject
    {
        protected static void checkValue(IBusinessRule rule)
        {
            if (!rule.HasValidRule())
            {
                throw  new ArgumentNullException(nameof(rule));
            }
            
        }
    }
   
}
