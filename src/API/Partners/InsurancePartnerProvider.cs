using API.Interfaces;

namespace API.Partners
{
    public class InsurancePartnerProvider(IEnumerable<IInsuranceFactory> insuranceFactories)
    {
        private readonly IEnumerable<IInsuranceFactory> _insuranceFactories = insuranceFactories;

        public IInsuranceFactory GetPartnerInsuranceFactory(string partner)
        {
            var result = _insuranceFactories.FirstOrDefault(x => x.Partner.Slug.Equals(partner));

            return result ?? throw new InvalidDataException("Partner does not exist");
        }
    }
}
