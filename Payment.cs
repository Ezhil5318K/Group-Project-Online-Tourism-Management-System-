using System;
using System.Collections.Generic;
using System.Text;

namespace Tourism.Model
{
   public  class Payment
    {
       public int Id { get; set; }
        public int BookingId { get; set; }
        public Booking Booking { get; set; }
        public Decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public int ReferenceNumber { get; set; }


    }
}
