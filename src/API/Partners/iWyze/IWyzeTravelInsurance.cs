using API.Interfaces;

namespace API.Partners.iWyze
{
    public class IWyzeTravelInsurance : ITravelInsurance
    {
        public string GetDescription()
        {
            return "Home Insurance provided by iWyze";
        }
    }
}
