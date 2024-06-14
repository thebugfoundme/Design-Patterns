using API.Interfaces;

namespace API.ViewModels
{
    public class PartnerInsuranceOfferings
    {
        public IAutoInsurance AutoInsurance { get; set; }
        public IHomeInsurance HomeInsurance { get; set; }
        public ILifeInsurance LifeInsurance { get; set; }
        public ITravelInsurance TravelInsurance { get; set; }
    }
}
