using Gumby.Api.GraphQL;
using Gumby.Graph;
using HotChocolate;
using HotChocolate.Execution;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Gumby.Test.Unit.Api
{
    public class MutationTest
    {
        private readonly IQueryExecutor _executor;
        private readonly IServiceProvider _serviceProvider;

        public MutationTest()
        {
            _executor = SchemaFactory.JournalSchema().Create().MakeExecutable();

            var gumbyGraphMock = new Mock<IGumbyGraph>();
            _serviceProvider = new ServiceCollection()
                .AddSingleton(gumbyGraphMock.Object)
                .BuildServiceProvider();
        }

        [Fact]
        public async Task NewPostMutationTest()
        {
            string mutationText =
                @"mutation CreatePost {
                    createPost
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
            Assert.True(postObject is Guid);
        }
    }
}
