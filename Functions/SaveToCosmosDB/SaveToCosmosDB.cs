
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

public static class SaveToCosmosDB
{
    [FunctionName("SaveToCosmosDB")]
    public static void Run([HttpTrigger] dynamic req, ILogger log)
    {
        log.LogInformation("SaveToCosmosDB function triggered.");
        // Logic to save to CosmosDB
    }
}
