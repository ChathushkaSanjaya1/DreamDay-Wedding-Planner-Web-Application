using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace DreamDay___Wedding_Planner_Web_Application.Areas.Identity.Data;

// Add profile data for application users by adding properties to the DreamDay_User class
public class DreamDay_User : IdentityUser
{
    public string Name { get; set; }
    public string City { get; set; }

    public int phone { get; set; }
}

