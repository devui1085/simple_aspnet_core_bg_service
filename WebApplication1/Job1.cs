namespace WebApplication1
{
    public class Job1 : BackgroundService
    {
        private readonly ILogger<Job1> _logger;

        public Job1(ILogger<Job1> logger)
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
                
                await Task.Delay(5000, stoppingToken);
            }
        }
    }
}
