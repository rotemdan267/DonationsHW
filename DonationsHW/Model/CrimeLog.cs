using System;

namespace DonationsHW.Model
{
    public class CrimeLog : ICrimeLog
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public int Amount { get; set; }
        public int CompanyId { get; set; }
        public DateTime DateOfDonation { get; set; }
        public int Generousity { get; set; }

        public int TotalOfAllDonations { get; set; }


        public void AddToTotal(int amount)
        {
            this.TotalOfAllDonations += amount;
        }

        public int GetTotalOfAllDonations()
        { // הפונקציה קצת מיותרת כי אפשר פשוט להחזיר את הפרופרטי
          // אבל בניתי בכל זאת כדי להיצמד להוראות של המשימה
            return this.TotalOfAllDonations;
        }
    }
}
