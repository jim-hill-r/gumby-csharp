using System;
using System.Collections.Generic;
using Microsoft.Azure.Documents;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Gumby.Graph.Mutation.Functions
{
    public static class MutationFunction
    {
        
        [FunctionName("Mutation")]
        public static void Run([CosmosDBTrigger(
            databaseName: "gumbydb",
            collectionName: "gumbyGraph",
            ConnectionStringSetting = "CosmosDBConnection",
            LeaseCollectionName = "leases")]IReadOnlyList<Document> documents, ILogger log)
        {
            if (documents != null && documents.Count > 0)
            {
                log.LogInformation("Documents modified " + documents.Count);
                log.LogInformation("First document Id " + documents[0].Id);
            }

            // TODO: Determine mutation and write to graph appropriately.
        }
        
    }
}
