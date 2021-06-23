using System;
using System.Collections.Generic;
using System.Text;
using PremiumCalculatorWebAPI.Controllers;
using  Microsoft.VisualStudio.TestTools.UnitTesting;
using PremiumCalculatorWebAPI.Domain.Services;

namespace PremiumCalculatorWebAPI.Tests.Services
{
    [TestClass]
    class PremiumCalculatorServiceTest
    {
        
        private static double GetPremium(int age, double amount, string occupation)
        {
            var service = new PremiumController(new PremiumService());
            var result = service.CalculatePremium(age, amount, occupation);
            return Convert.ToDouble(result.Result);
        }
        
        [TestMethod]
        public void CalculatePremium_with_Null_Inputs()
        {
            try
            {
                var result = GetPremium(0, 0, null);
                Assert.Fail();
            }
            catch { 
            
            }
        }

        public void CalculatePremium_with_Invalide_Occupation()
        {
            try
            {
                var result = GetPremium(0, 0, "Testoccupation");
            }
            catch { }
        }

    }
}
