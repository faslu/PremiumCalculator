using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PremiumCalculatorWebAPI.Domain.Model;

namespace PremiumCalculatorWebAPI.Domain.Services
{
    public interface IPremiumService
    {
       Task<PremiumResult> CalculatePremium(int Age, double Amount, string occupation);
    }
}
