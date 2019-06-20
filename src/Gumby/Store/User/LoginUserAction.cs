using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor.Fluxor;
using Gumby.Contract;
using Gumby.Model.Route;

namespace Gumby.Store.User
{
    public class LoginUserAction : IAction
    {
        public string Username { get; }

        public LoginUserAction(string username)
        {
            Username = username;
        }
    }
}
