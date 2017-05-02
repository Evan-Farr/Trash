using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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
        public int TruckId { get; set; }
        public string FirstName { get; set; } 
        public char MiddleInitial { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}