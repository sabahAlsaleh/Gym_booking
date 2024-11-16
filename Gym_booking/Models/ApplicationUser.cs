﻿using Microsoft.AspNetCore.Identity;

namespace Gym_booking.Models
{

    public class ApplicationUser: IdentityUser
    {
        public ICollection<ApplicationUserGymClass> AttendedClasses { get; set; }

    }
}
