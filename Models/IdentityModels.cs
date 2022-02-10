using AS_SIT_Connect_Web_App.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AS_SIT_Connect_Web_App.Models
{
    //public class IdentityModels : IdentityUser
    //{
    //    public IdentityModels() : base()
    //    {
    //        UserUsedPassword = new List<UsedPassword>();
    //    }

    //    public virtual IList<UsedPassword> UserUsedPassword { get; set; }
    //}

    //public class UsedPassword
    //{
    //    public UsedPassword()
    //    {
    //        CreatedDate = DateTimeOffset.Now;
    //    }

    //    [Key, Column(Order = 6)]
    //    public string HashPassword { get; set; }
    //    public DateTimeOffset CreatedDate { get; set; }

    //    [Key, Column(Order = 0)]
    //    public string UserID { get; set; }
    //    public virtual ApplicationUser AppUser { get; set; }
    //}
}
