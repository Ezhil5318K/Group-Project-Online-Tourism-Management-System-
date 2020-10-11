using System;
using System.Collections.Generic;
using System.Text;

namespace Tourism.Model
{
   public class Booking
    {
        public int Id { get; set; }
        public Decimal PackageAmount { get; set; }
        public string Duration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal BookingAmount { get; set; }
        public decimal Discount { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal GST { get; set; }
        public decimal NetAmount { get; set; }
        public decimal TotalPaid { get; set; }
        public decimal BalanceAmount { get; set; }
        public string Status { get; set; }
        public DateTime BookingLastDate { get; set; }
        public int PackageId { get; set; }
        public Package package { get; set; }
        public int UserRoleId { get; set; }
        public UserRole UserRole { get; set; }
        public List<Payment> Payments { get; set; }

    }
}
