using API.Interfaces;
using API.Partners.CapitalLegacy;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Tests.Partners.CapitalLegacy
{
    internal class CapitalLegacyFactoryTests
    {
        private IInsuranceFactory CreateFactory()
        {
            return new CapitalLegacyInsuranceFactory();
        }

        [Test]
        public void ShouldCreateCapitalLegacyAutoInsurance()
        {
            // arrange            
            IInsuranceFactory factory = CreateFactory();

            // act
            var actual = factory.CreateAutoInsurance();

            // assert            
            actual.Should().BeOfType<CapitalLegacyAutoInsurance>();
        }

        [Test]
        public void ShouldCreateCapitalLegacyHomeInsurance()
        {
            // arrange            
            IInsuranceFactory factory = CreateFactory();

            // act
            var actual = factory.CreateHomeInsurance();

            // assert            
            actual.Should().BeOfType<CapitalLegacyHomeInsurance>();
        }        

        [Test]
        public void ShouldCreateCapitalLegacyLifeInsurance()
        {
            // arrange            
            IInsuranceFactory factory = CreateFactory();

            // act
            var actual = factory.CreateLifeInsurance();

            // assert            
            actual.Should().BeOfType<CapitalLegacyLifeInsurance>();
        }

        [Test]
        public void ShouldCreateCapitalLegacyTravelInsurance()
        {
            // arrange            
            IInsuranceFactory factory = CreateFactory();

            // act
            var actual = factory.CreateTravelInsurance();

            // assert            
            actual.Should().BeOfType<CapitalLegacyTravelInsurance>();
        }
    }
}
