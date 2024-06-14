using API.Interfaces;

namespace API.Partners.CapitalLegacy
{
    public class CapitalLegacyTravelInsurance : ITravelInsurance
    {
        public string GetDescription()
        {
            return "Home Insurance provided by Capital Legacy";
        }
    }
}
