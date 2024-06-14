using API.Partners;

namespace API.Interfaces
{
    public interface IInsuranceFactory
    {
        IPartner Partner { get; }
        IHomeInsurance CreateHomeInsurance();
        IAutoInsurance CreateAutoInsurance();
        ILifeInsurance CreateLifeInsurance();
        ITravelInsurance CreateTravelInsurance();
    }
}
