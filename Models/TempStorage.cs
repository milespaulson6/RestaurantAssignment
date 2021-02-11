using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAssignment.Models
{
    public static class TempStorage
    {
        private static List<UserList> applications = new List<UserList>();

        public static IEnumerable<UserList> Applications => applications;

        public static void AddApplication(UserList application)
        {
            applications.Add(application);

        }

    }
}
