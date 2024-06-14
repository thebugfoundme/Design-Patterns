using API.Interfaces;
using API.Partners.CapitalLegacy;

namespace API.Partners.iWyze
{
    public class IWyzeInsuranceFactory : IInsuranceFactory
    {
        public IPartner Partner => new IWyze();

        public IAutoInsurance CreateAutoInsurance()
        {
            return new IWyzeAutoInsurance();
        }

        public IHomeInsurance CreateHomeInsurance()
        {
            return new IWyzeHomeInsurance();
        }

        public ILifeInsurance CreateLifeInsurance()
        {
            return new IWyzeLifeInsurance();
        }

        public ITravelInsurance CreateTravelInsurance()
        {
            return new IWyzeTravelInsurance();
        }
    }
}
