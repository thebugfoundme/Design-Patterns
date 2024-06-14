using API.Interfaces;
using System.Runtime.InteropServices;

namespace API.Partners.CapitalLegacy
{
    public class CapitalLegacyHomeInsurance : IHomeInsurance
    {
        public string GetDescription()
        {
            return "Home Insurance provided by Capital Legacy";
        }
    }
}
