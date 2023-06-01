﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.Domain.Entities.Identity;

namespace Talabat.Domain.Services
{
    public interface ITokenService
    {
        Task<string> GetTokenAsync(AppUser user,UserManager<AppUser> userManager);
    }
}
