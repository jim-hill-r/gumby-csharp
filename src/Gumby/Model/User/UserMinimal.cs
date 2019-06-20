using Gumby.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gumby.Model.User
{
    public class UserMinimal : IUser
    {
        public Guid Id { get; set; }
        
        public string Username { get; set; }

        public static IUser Guest
        {
            get
            {
                return new UserMinimal()
                {
                    Id = Guid.Empty,
                    Username = "Guest"
                };
            }
        }
    }
}
