using AS_SIT_Connect_Web_App.Data;
using AS_SIT_Connect_Web_App.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AS_SIT_Connect_Web_App.IdentityExtensions
{
    //public class AppUserStore : UserStore<ApplicationUser>
    //{
    //    public AppUserStore(DbContext MyDbContext)
    //       : base(MyDbContext)
    //    {
    //    }

    //    public override async Task CreateAsync(ApplicationUser appuser)
    //    {
    //        await base.CreateAsync(appuser);
    //        await AddToUsedPasswordAsync(appuser, appuser.PasswordHash);
    //    }

    //    public Task AddToUsedPasswordAsync(ApplicationUser appuser, string userpassword)
    //    {
    //        appuser.UserUsedPassword.Add(new UsedPassword() { UserID = appuser.Id, HashPassword = userpassword });
    //        return UpdateAsync(appuser);
    //    }
    //}
}
