
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

public static class ListRecords
{
    [FunctionName("ListRecords")]
    public static void Run([HttpTrigger] dynamic req, ILogger log)
    {
        log.LogInformation("ListRecords function triggered.");
        // Logic to list records
    }
}
