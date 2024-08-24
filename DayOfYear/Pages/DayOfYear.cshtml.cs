using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace DayOfYear.Pages
{
    public class DayOfYearModel : PageModel
    {
        public int DayOfYear { get; set; }
        public DateTime CurrentDateTime { get; set; }
        public char RandomLetter { get; set; }

        public void OnGet()
        {
            DayOfYear = DateTime.Today.DayOfYear;
            CurrentDateTime = DateTime.Now;
            RandomLetter = GenerateRandomLetter();
        }

        private char GenerateRandomLetter()
        {
            Random random = new Random();
            int num = random.Next(0, 26); 
            return (char)('A' + num); 
        }
    }
}
