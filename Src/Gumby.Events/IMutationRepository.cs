using System;
using System.Threading.Tasks;

namespace Gumby.Mutation
{
    public interface IMutationRepository
    {
        Task Submit<T>(T mutation) where T : IMutation;
    }
}
