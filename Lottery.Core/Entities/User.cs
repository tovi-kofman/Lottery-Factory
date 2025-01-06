
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace LotteryFactory.Core.Entities
{
    [Table("User")]
    public class User
    {

        // public int index { get; set; }

        //public int UserId { get; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string Tz { get; set; }

        //public string Email { get; set; }
        //public string Password { get; set; }

        //public string PhoneNumber { get; set; }
        //public string Address { get; set; }
        //public bool IsActive { get; set; }
        //public AccountType AccountType { get; set; }
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tz { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
        public string AccountType { get; set; }
        public List<Ticket> Tickets { get; set; }

        public User(int userId,string firstName, string lastName, string tz, string email, string password, string phoneNumber, string address, bool isActive, string accountType)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            Address = address;
            IsActive = isActive;
            AccountType = accountType;
            TzValid tzValid = new TzValid();
            ErrorTZ error;
            if (tzValid.ISOK(tz, out error))
            {
                Tz = tz;
            }
            else 
            { 
                throw new Exception($"{error}");
            }
        }

        //public User()
        //{
        //    UserId = id++;
        //}
    }
}
