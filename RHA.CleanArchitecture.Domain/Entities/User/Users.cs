using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using RHA.CleanArchitecture.Domain.Entities.BaseEntities;

namespace RHA.CleanArchitecture.Domain.Entities.User
{
    [Table("Users", Schema = "Sec")]
    public class User : IdentityUser<long>, IRootEntity
    {


        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public Guid Key { get; set; }
        public long CreateOn { get ; set ; }
        public long? UpdateOn { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid RowGuid { get; set; }

        public void Deleted()
        {
            IsActive = false;
            IsDeleted = true;
        }

    }





}
