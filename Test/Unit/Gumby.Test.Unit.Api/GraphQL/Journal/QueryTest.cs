using Gremlin.Net.Driver;
using Gumby.Api.GraphQL;
using HotChocolate;
using HotChocolate.Execution;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;
using System.Collections;
using System.Threading.Tasks;
using Xunit;
using System.Collections.Generic;

namespace Gumby.Test.Unit.Api
{
    public class QueryTest
    {
        private readonly IQueryExecutor _executor;
        private readonly IServiceProvider _serviceProvider;

        public QueryTest()
        {
            _executor = SchemaFactory.JournalSchema().Create().MakeExecutable();

            var gremlinClientMock = new Mock<IGremlinClient>();
            _serviceProvider = new ServiceCollection()
                .AddSingleton(gremlinClientMock.Object)
                .BuildServiceProvider();
        }

        [Fact]
        public async Task PostQueryTest()
        {
            string queryText =
                @"query GetPosts{
                    posts{
                        text       
                    }
                }";

            var queryRequest = QueryRequestBuilder.New().SetServices(_serviceProvider).SetQuery(queryText).Create();
            IExecutionResult result = await _executor.ExecuteAsync(queryRequest);
            Assert.NotNull(result);
            Assert.Equal(0, result.Errors.Count);

            var data = ((IReadOnlyQueryResult)result).Data;
            Assert.Equal(1, data.Count);
            Assert.True(data.ContainsKey("posts"));

            object postsObject = null;
            Assert.True(data.TryGetValue("posts", out postsObject));
            var posts = (IEnumerable)postsObject;
            foreach (var post in posts)
            {
                var postDictionary = (OrderedDictionary)post;
                Assert.Equal(1, postDictionary.Keys.Count);
                Assert.True(postDictionary.ContainsKey("text"));
            }
        }
    }
}
