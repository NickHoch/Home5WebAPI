using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Home5WebAPI.Models.Entities
{
    public class UserProfile
    {
        [Key, ForeignKey("User")]
        public string Id { get; set; }
        public string Image { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}