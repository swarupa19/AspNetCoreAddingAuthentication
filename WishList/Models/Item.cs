using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace WishList.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Description { get; set; }
        public virtual ApplicationUser User { get; set; }

        public class ApplicationUser : IdentityUser
        {
            public virtual ICollection<Item> Items { get; set; }
        }
    }
}
