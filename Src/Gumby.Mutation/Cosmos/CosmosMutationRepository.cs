using Gremlin.Net.Driver;
using System.Text;
using System.Threading.Tasks;

namespace Gumby.Mutation.Cosmos
{
    public class CosmosMutationRepository : IMutationRepository
    {
        private static readonly string PARTITION_KEY = "partitionKey";
        private static readonly string ID_KEY = "id";
        private static readonly string MUTATION_LABEL = "mutation";
        private static readonly string MUTATION_PARTITION = "mutation";

        private IGremlinClient _gremlinClient;
        public CosmosMutationRepository(IGremlinClient gremlinClient)
        {
            _gremlinClient = gremlinClient;
        }

        public async Task Submit<T>(T mutation) where T : IMutation
        {
            var queryBuilder = new StringBuilder();
            queryBuilder.Append($"g");
            queryBuilder.Append($".addV('{MUTATION_LABEL}')");
            queryBuilder.Append($".property('{ID_KEY}','{mutation.Id}')");
            queryBuilder.Append($".property('{PARTITION_KEY}','{MUTATION_PARTITION}')");
            foreach (string key in mutation.Properties.Keys)
            {
                queryBuilder.Append($".property('{key}','{mutation.Properties[key]}')");
            }

            var result = await _gremlinClient.SubmitAsync<dynamic>(queryBuilder.ToString());
        }
    }
}
