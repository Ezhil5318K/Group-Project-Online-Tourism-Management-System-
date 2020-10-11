using System;
using System.Collections.Generic;
using System.Text;

namespace Tourism.Model
{
   public  class Package
    {
        public List<Booking> Bookings { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public Decimal Amount { get; set; }
        public string Destination { get; set; }
        public int UserRoleId { get; set; }
        public UserRole userRole { get; set; }
        public int NoOfAdults { get; set; }
        public int NoOfChild { get; set; }

    }
}
