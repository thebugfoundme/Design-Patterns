namespace API.Interfaces
{
    public interface IInsurance
    {
        string GetDescription();
        string Description => GetDescription();
    }
}
