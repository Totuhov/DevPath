
using System.ComponentModel.DataAnnotations;

namespace DevPath.Web.Data.Entities;
public class LeaveApplication{
    
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string UserId { get; set; } = null!;

    public ApplicationUser ApplicationUser { get; set; } = null!;
}
