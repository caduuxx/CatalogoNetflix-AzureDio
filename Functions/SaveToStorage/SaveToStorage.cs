
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

public static class SaveToStorage
{
    [FunctionName("SaveToStorage")]
    public static void Run([HttpTrigger] dynamic req, ILogger log)
    {
        log.LogInformation("SaveToStorage function triggered.");
        // Logic to save to Storage Account
    }
}
