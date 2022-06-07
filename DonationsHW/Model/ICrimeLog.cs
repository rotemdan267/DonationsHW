using System;

namespace DonationsHW.Model
{
    public interface ICrimeLog
    {
        int Amount { get; set; }
        int CompanyId { get; set; }
        DateTime DateOfDonation { get; set; }
        string Family { get; set; }
        int Generousity { get; set; }
        string Name { get; set; }
        int TotalOfAllDonations { get; set; }

        void AddToTotal(int amount);
        int GetTotalOfAllDonations();
    }
}