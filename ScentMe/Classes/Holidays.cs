using Microsoft.AspNetCore.Mvc.Diagnostics;

namespace ScentMe.Classes
{
    public static class Holidays
    {
        public static string GetEventUtcDateString(string eventName, int eventYear)
        {
            string midnight = "T00:00:00";
            object temp = DateTime.Now;

        // Seasons and Easter - (Date-time is Calculated)

        // Holidays - (Date is Fixed)
        switch (eventName)
            {
                case "NewYears":
                    {
                        return eventYear + "-01-01" + midnight;
                    }

                case "Valentines":
                    {
                        return eventYear + "-02-14" + midnight;
                    }
                case "Independence":
                    {
                        return eventYear + "-07-04" + midnight;
                    }
                case "Veterans":
                    {
                        return eventYear + "-11-11" + midnight;
                    }
                case "Halloween":
                    {
                        return eventYear + "-10-31" + midnight;
                    }
                case "Christmas":
                    {
                        return eventYear + "-12-25" + midnight;
                    }
                case "Lincoln":
                    {
                        return eventYear + "-02-12" + midnight;
                    }

                case "Washington":
                    {
                        return eventYear + "-02-22" + midnight;
                    }
                case "Jefferson":
                    {
                        return eventYear + "-04-13" + midnight;
                    }
                case "Army":
                    {
                        return eventYear + "-06-14" + midnight;
                    }
                case "AirForce":
                    {
                        return eventYear + "-09-18" + midnight;
                    }
                case "Navy":
                    {
                        return eventYear + "-10-13" + midnight;
                    }
                case "MarineCorp":
                    {
                        return eventYear + "-11-10" + midnight;
                    }
                case "NationalGuard":
                    {
                        return eventYear + "-12-13" + midnight;
                    }
            }             

        // Return a default Date if target Date not found (Shouldn't happen)
        
        return eventYear + "-03-31" + midnight;

        }

       
    }
}
