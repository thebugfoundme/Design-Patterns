using API.Interfaces;

namespace API.Partners.CapitalLegacy
{
    public class CapitalLegacyInsuranceFactory : IInsuranceFactory
    {
        public IPartner Partner => new CapitalLegacy();

        public IAutoInsurance CreateAutoInsurance()
        {
            return new CapitalLegacyAutoInsurance();
        }

        public IHomeInsurance CreateHomeInsurance()
        {
            return new CapitalLegacyHomeInsurance();
        }

        public ILifeInsurance CreateLifeInsurance()
        {
            return new CapitalLegacyLifeInsurance();
        }

        public ITravelInsurance CreateTravelInsurance()
        {
            return new CapitalLegacyTravelInsurance();
        }
    }
}
