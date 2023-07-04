namespace WebInacap.Models
{
    public class EnvioNotificaciones : IHostedService
    {
        private readonly AppDbContext _context;
        public EnvioNotificaciones(AppDbContext context)
        {
            _context = context;
        }
        public Task StartAsync(CancellationToken cancellationToken)
        {
            // timer repeates call to RemoveScheduledAccounts every 24 hours.
            var _timer = new Timer(
                EnviarNoti,
                null,
                TimeSpan.Zero,
                TimeSpan.FromHours(24)
            );
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }


        private void EnviarNoti(object state)
        {
            //Envio de notificacionesrec
        }
    }
}
