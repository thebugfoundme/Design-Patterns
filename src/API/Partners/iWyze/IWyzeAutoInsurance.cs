using API.Interfaces;

namespace API.Partners.iWyze
{
    public class IWyzeAutoInsurance : IAutoInsurance
    {
        public string GetDescription()
        {
            return "Auto Insurance provided by iWyze";
        }
    }
}
