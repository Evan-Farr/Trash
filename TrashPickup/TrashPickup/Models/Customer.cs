using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TrashPickup.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }

        [StringLength(1)]
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }

        [Required]
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        [Required, StringLength(5)]
        public string ZipCode { get; set; }

        [StringLength(10)]
        public string Phone { get; set; }
        public string Email { get; set; }
        public string MoneyOwed { get; set; }

        [DataType(DataType.Date)]
        public DateTime? NextScheduledPickUp { get; set; }

        public virtual Employee TrashMan { get; set; }
        public virtual ApplicationUser userId { get; set; }
    }
}