using HospitalDataBase.Core.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.UserIdentifile
{
    public class Role : BaseEntity
    {
        public virtual ICollection<UserRole>    UserRoles   { get; } = new HashSet<UserRole>();
    }
}
