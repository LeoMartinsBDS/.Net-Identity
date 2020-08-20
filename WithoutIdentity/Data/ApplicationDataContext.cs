using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using WithoutIdentity.Models;

namespace WithoutIdentity.Data
{
    public class ApplicationDataContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options)
            :base(options)
        {

        }
    }
}
