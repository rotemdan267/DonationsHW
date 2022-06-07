using DonationsHW.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DonationsHW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonationController : ControllerBase
    {
        IDonation _donation;
        ICrimeLog _log;
        public DonationController(IDonation donation, ICrimeLog log)
        {
            _donation = donation;
            _log = log;
        }

        [HttpPost("give/{name}/{family}")]
        public IActionResult Donate([FromRoute] string name, [FromRoute] string family,
           [FromQuery] int amount, [FromQuery] int companyId,
           [FromBody] DateObject dateObject)
        {
            _donation.AddToTotal(amount);
            _log.AddToTotal(amount);

            Donation donation = new Donation()
            {
                Name = name,
                Family = family,
                Amount = amount,
                CompanyId = companyId,
                DateOfDonation = dateObject.DateOfDonation,
                Generousity = dateObject.Generousity
            };

            donation.TotalOfAllDonations = _donation.GetTotalOfAllDonations();

            return Ok(new { Donation = donation, CrimeTotalOfAllDonations = _log.GetTotalOfAllDonations() });
        }
    }
}
