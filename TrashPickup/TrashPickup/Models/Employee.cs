using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TrashPickup.Models
{
    public class Employee
    {
        public Employee()
        {
            Customers = new List<Customer>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public int TruckId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [StringLength(1)]
        public string MiddleInitial { get; set; }

        [Required]
        public string LastName { get; set; }
        public int? Age { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        [Required, StringLength(5)]
        public string ZipCode { get; set; }

        [Required, StringLength(10)]
        public string Phone { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ApplicationUser userId { get; set; }
    }
}