using System.ComponentModel.DataAnnotations;

namespace net_pers_fin.Models;

public class user
{
    public int id { get ; set; }
    public string first { get ; set; }
    public string last { get ; set; }
    public int active { get ; set; }
    public int verified { get ; set; }
    public DateTime createdon { get ; set; }
    public DateTime lastlogin { get ; set; }
}