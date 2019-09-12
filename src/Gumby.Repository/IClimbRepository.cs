using Gumby.Repository.Models;
using System;
using System.Collections.Generic;

namespace Gumby.Repository
{
    public interface IClimbRepository
    {
        IReadOnlyList<Post> GetPosts();
    }
}
