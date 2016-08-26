using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ADYD.Domain.Entities
{
    public class User : IdentityUser, Interfaces.IAuditable
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<AccountsReceivable> AccountsReceivable { get; set; }
        public virtual ICollection<DetailAccountsReceivable> DetailAccountsReceivable { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<ProductMeasure> ProductProductMeasures { get; set; }
        public virtual ICollection<ProductRegistry> ProductRegistries { get; set; }

        public Enums.Status StatusEntity { get; set; }

        //Auditoria
        public int CreatedById { get; set; }

        public int ModifiedById { get; set; }
        public virtual User CreatedBy { get; set; }
        public virtual User ModifiedBy { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}