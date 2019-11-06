namespace Gumby.App
{
    public class EndpointProvider : IEndpointProvider
    {
        public string GraphQLAPI { get => "http://localhost:7071/api/gql"; }
    }
}
