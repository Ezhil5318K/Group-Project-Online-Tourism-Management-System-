using System;
using System.Collections.Generic;
using System.Text;

namespace Tourism.Model
{
  public  class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
         public string Mobile { get; set; }
         public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Password { get; set; }
        public int Pincode { get; set; }
        public List<UserRole> UserRoles { get; set; }

    }
}
