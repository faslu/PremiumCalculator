using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PremiumCalculatorWebAPI.Domain.Model;
using PremiumCalculatorWebAPI.Domain.Services;


namespace PremiumCalculatorWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PremiumController : ControllerBase
    {
        private readonly IPremiumService _premiumService;
        public PremiumController(IPremiumService premiumService)
        {
            _premiumService = premiumService;
        }

        // GET api/premium
        [HttpGet]
        public async Task<double?> CalculatePremium([FromQuery] int age, [FromQuery] double amount, [FromQuery] string occupation)
        {
            //if (premiumData == null) { throw new ArgumentNullException(nameof(premiumData), "premium Input is empty"); }
            //if (premium.Age == null) { throw new ArgumentNullException(nameof(premium.Age), "premium Input is empty"); } Needs to revisit this
            //if (premium.CoverAmount==null){ throw new ArgumentNullException(nameof(premium.CoverAmount), "CoverAmount Input is empty"); } Needs to revisit this
            // if (premium.ProfFactor==null){ throw new ArgumentNullException(nameof(premium.ProfFactor), "Professional factor Input is empty"); } Needs to revisit this

            var premiumResult = await _premiumService.CalculatePremium(age, amount, occupation);
            return premiumResult.MonthlyAmount;
        }


        [HttpGet("[action]")]
        public int Get()
        {
            return 1;
        }
    }
}