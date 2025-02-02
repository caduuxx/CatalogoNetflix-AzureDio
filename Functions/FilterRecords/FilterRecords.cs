
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

public static class FilterRecords
{
    [FunctionName("FilterRecords")]
    public static void Run([HttpTrigger] dynamic req, ILogger log)
    {
        log.LogInformation("FilterRecords function triggered.");
        
    }
}
