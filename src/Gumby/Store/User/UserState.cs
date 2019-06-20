using Gumby.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gumby.Store.User
{
    public class UserState
    {
        public IUser User { get; private set; }

        public UserState(IUser user)
        {
            User = user;
        }
    }
}
