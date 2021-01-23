using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trips.Data.Models;

namespace Trips.Data
{
    public static class Data
    {
        public static List<Trip> Trips => allTrips;

        static List<Trip> allTrips = new List<Trip>()
        {
            new Trip()
            {
                Id=1,
                Name="Vienna Austraila",
                Description = "Vienna is one fine state",
                DateStarted = new DateTime(2017,01,20),
                DateCompleted = new DateTime(2020,02,13)
            },

            new Trip()
            {
                Id=2,
                
                Name="Nigeria",
                Description = "Crazy shit",
                DateStarted = new DateTime(2020, 05,10),
                DateCompleted = null
            },
            new Trip()
            {
                Id=3,
                Name="Austraila",
                Description = " fine state",
                DateStarted = new DateTime(2017,01,20),
                DateCompleted = null
            },
            new Trip()
            {
                Id=4,
                Name="America",
                Description = "Woke mofos",
                DateStarted = new DateTime(2021,01,20),
                DateCompleted = null
            },
            new Trip()
            {
                Id=5,
                Name="Twitter",
                Description = "fools on people",
                DateStarted = new DateTime(2019,01,20),
                DateCompleted = null
            },
            new Trip()
            {
                Id=6,
                Name="China",
                Description = "Home of chinese virus",
                DateStarted = new DateTime(2012,01,20),
                DateCompleted = null
            },
            new Trip()
            {
                Id=7,
                Name="Fafo",
                Description = "Fuck around and find out",
                DateStarted = new DateTime(2017,01,20),
                DateCompleted = null
            },
        };
    }
}
