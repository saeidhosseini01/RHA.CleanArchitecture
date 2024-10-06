namespace RHA.CleanArchitecture.Application.Services
{
    public interface IBusinessRule
    {
        bool HasValidRule();
        string Message { get; }
    }
}
