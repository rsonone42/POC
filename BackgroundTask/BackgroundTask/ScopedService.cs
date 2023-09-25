namespace BackgroundTask.BackgroundTask
{
    public class ScopedService : IScopedService
    {
        private readonly ILogger<ScopedService> _logger;
        private readonly Guid _id;

        public ScopedService(ILogger<ScopedService> logger)
        {
            this._logger = logger;
            this._id = Guid.NewGuid();
        }
        public void Write()
        {
            this._logger.LogInformation("from Scopped service {datetime}", this._id);
        }
    }
}
