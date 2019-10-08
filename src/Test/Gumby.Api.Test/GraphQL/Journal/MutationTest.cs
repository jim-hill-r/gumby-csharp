using Gremlin.Net.Driver;
using Gumby.Api.GraphQL;
using HotChocolate;
using HotChocolate.Execution;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Gumby.Api.Test
{
    public class MutationTest
    {
        private readonly IQueryExecutor _executor;
        private readonly IServiceProvider _serviceProvider;

        public MutationTest()
        {
            _executor = SchemaFactory.JournalSchema().Create().MakeExecutable();

            var gremlinClientMock = new Mock<IGremlinClient>();
            _serviceProvider = new ServiceCollection()
                .AddSingleton(gremlinClientMock.Object)
                .BuildServiceProvider();
        }

        [Fact]
        public async Task NewPostMutationTest()
        {
            string mutationText =
                @"mutation CreatePost {
                    createPost {
                        id
                        text
                    }
                }";

            var queryRequest = QueryRequestBuilder.New().SetServices(_serviceProvider).SetQuery(mutationText).Create();
            IExecutionResult result = await _executor.ExecuteAsync(queryRequest);
            Assert.NotNull(result);
            Assert.Equal(0, result.Errors.Count);

            var data = ((IReadOnlyQueryResult)result).Data;
            Assert.Equal(1, data.Count);
            Assert.True(data.ContainsKey("createPost"));

            object postObject = null;
            Assert.True(data.TryGetValue("createPost", out postObject));
            var post = (OrderedDictionary)postObject;
            Assert.Equal(2, post.Keys.Count);
            Assert.True(post.ContainsKey("id"));
            Assert.True(post.ContainsKey("text"));
        }
    }
}
