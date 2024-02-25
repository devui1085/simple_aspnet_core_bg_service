namespace WebApplication1
{
    public class Job3 : BackgroundService
    {
        private readonly ILogger<Job3> _logger;

        public Job3(ILogger<Job3> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    _logger.LogInformation("Job1 completed at: " + DateTime.Now);
                }
                catch (Exception ex)
                {
                    _logger.LogError("Error at: {time}", DateTimeOffset.Now);
                }

                await Task.Delay(17000, stoppingToken);
            }
        }
    }
}
