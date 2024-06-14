using API.Interfaces;

namespace API.Partners.CapitalLegacy
{
    public class CapitalLegacyAutoInsurance : IAutoInsurance
    {
        public string GetDescription()
        {
            return "Auto Insurance provided by Capital Legacy";
        }
    }
}
