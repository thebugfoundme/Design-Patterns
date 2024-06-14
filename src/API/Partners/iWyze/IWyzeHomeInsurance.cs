using API.Interfaces;
using System.Runtime.InteropServices;

namespace API.Partners.iWyze
{
    public class IWyzeHomeInsurance : IHomeInsurance
    {
        public string GetDescription()
        {
            return "Home Insurance provided by iWyze";
        }
    }
}
