using PremiumCalculatorWebAPI.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PremiumCalculatorWebAPI.Domain.Services
{
    public class PremiumService : IPremiumService
    {
        PremiumResult res = null;
        

       public PremiumService() { }
        public async Task<PremiumResult> CalculatePremium(int age, double amount, string occupation)
        {
            //Death Premium = (Death Cover amount *Occupation Rating Factor *Age) / 1000 * 12
            res = new PremiumResult();
            double profFactorRate = 0.00d;
            switch(occupation.ToLower())
            {
                case "doctor":

                    profFactorRate = ProfessionalFactorTypes.PROFESSIONAL;
                    break;

                case "cleaner":
                case "florist":

                    profFactorRate = ProfessionalFactorTypes.LIGHTMANUAL;
                    break;

                case "Farmer":
                case "mechanic":

                    profFactorRate = ProfessionalFactorTypes.HEAVYMANUAL;
                    break;

                case "author":

                    profFactorRate = ProfessionalFactorTypes.WHITECOLLOR;
                    break;

                default:

                    profFactorRate = ProfessionalFactorTypes.DEFAULT;
                    break;
            }
                        
            await Task.Run(() =>
            {
                res.MonthlyAmount = (amount * profFactorRate * age) / 1000 * 12;

            });
            return res;         
                       

        }

      
    }
}
 