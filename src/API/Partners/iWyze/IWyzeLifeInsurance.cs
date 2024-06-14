using API.Interfaces;

namespace API.Partners.iWyze
{
    public class IWyzeLifeInsurance : ILifeInsurance
    {
        public string GetDescription()
        {
            return "Life Insurance provided by iWyze";
        }
    }
}
