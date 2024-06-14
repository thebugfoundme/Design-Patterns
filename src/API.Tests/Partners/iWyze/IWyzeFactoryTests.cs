using API.Interfaces;
using API.Partners.iWyze;
using FluentAssertions;

namespace API.Tests.Partners.iWyze
{
    internal class IWyzeFactoryTests
    {
        private IInsuranceFactory CreateFactory()
        {
            return new IWyzeInsuranceFactory();
        }

        [Test]
        public void ShouldCreateIWyzeAutoInsurance()
        {
            // arrange            
            IInsuranceFactory factory = CreateFactory();

            // act
            var actual = factory.CreateAutoInsurance();

            // assert            
            actual.Should().BeOfType<IWyzeAutoInsurance>();
        }

        [Test]
        public void ShouldCreateIWyzeHomeInsurance()
        {
            // arrange            
            IInsuranceFactory factory = CreateFactory();

            // act
            var actual = factory.CreateHomeInsurance();

            // assert            
            actual.Should().BeOfType<IWyzeHomeInsurance>();
        }

        [Test]
        public void ShouldCreateIWyzeLifeInsurance()
        {
            // arrange            
            IInsuranceFactory factory = CreateFactory();

            // act
            var actual = factory.CreateLifeInsurance();

            // assert            
            actual.Should().BeOfType<IWyzeLifeInsurance>();
        }

        [Test]
        public void ShouldCreateIWyzeTravelInsurance()
        {
            // arrange            
            IInsuranceFactory factory = CreateFactory();

            // act
            var actual = factory.CreateTravelInsurance();

            // assert            
            actual.Should().BeOfType<IWyzeTravelInsurance>();
        }
    }
}
