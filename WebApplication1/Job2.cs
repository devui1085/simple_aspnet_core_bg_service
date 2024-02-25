namespace WebApplication1
{
    public class Job2 : BackgroundService
    {
        private readonly ILogger<Job2> _logger;

        public Job2(ILogger<Job2> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    _logger.LogInformation("Job2 completed at: " + DateTime.Now);
                }
                catch (Exception ex)
                {
                    _logger.LogError("Error at: {time}", DateTimeOffset.Now);
                }
                await Task.Delay(12000, stoppingToken);
            }
        }
    }
}
