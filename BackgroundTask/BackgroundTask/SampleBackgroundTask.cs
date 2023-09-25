namespace BackgroundTask.BackgroundTask
{
    public class SampleBackgroundTask : BackgroundService
    {
        private readonly ILogger<SampleBackgroundTask> _logger;
        private readonly IServiceProvider _serviceProvider;
        private IScopedService _scopedService;

        public SampleBackgroundTask(ILogger<SampleBackgroundTask> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            this._serviceProvider = serviceProvider;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                while (!stoppingToken.IsCancellationRequested)
                {
                    //using (var scope = _serviceProvider.CreateScope()) // if we uncomment this statement since scope will created in every loop guild will be different.
                    {
                        _logger.LogInformation("Background task executed at {daratime}", DateTime.Now);
                        _scopedService = scope.ServiceProvider.GetRequiredService<IScopedService>();
                        _scopedService.Write();
                        await Task.Delay(TimeSpan.FromSeconds(3), stoppingToken);
                    }
                }
            }
        }
    }
}
