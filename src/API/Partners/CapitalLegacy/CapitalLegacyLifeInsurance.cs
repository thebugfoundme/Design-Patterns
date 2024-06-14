using API.Interfaces;

namespace API.Partners.CapitalLegacy
{
    public class CapitalLegacyLifeInsurance : ILifeInsurance
    {
        public string GetDescription()
        {
            return "Life Insurance provided by Capital Legacy";
        }
    }
}
