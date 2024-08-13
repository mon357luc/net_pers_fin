using System.ComponentModel.DataAnnotations;

namespace net_pers_fin.Models;

public class User
{
    public int Id { get ; set; }
    public required string First { get ; set; }
    public required string Last { get ; set; }
    public int Active { get ; set; } = 0;
    public int Verified { get ; set; } = 0;
    public DateTime Createdon { get ; set; }
    public DateTime? Lastlogin { get ; set; }
}