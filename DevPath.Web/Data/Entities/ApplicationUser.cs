using Microsoft.AspNetCore.Identity;

namespace DevPath.Web.Data.Entities;

public class ApplicationUser : IdentityUser
{
    public ICollection<LeaveApplication> Applications { get; set; } = new List<LeaveApplication>();
}
