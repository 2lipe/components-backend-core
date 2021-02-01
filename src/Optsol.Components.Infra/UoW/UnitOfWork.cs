using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Optsol.Components.Infra.Data;
using System;
using System.Threading.Tasks;

namespace Optsol.Components.Infra.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool disposed = false;
        private ILogger _logger;

        public CoreContext Context { get; protected set; }

        public UnitOfWork(CoreContext context, ILogger<UnitOfWork> logger)
        {
            _logger = logger;
            _logger?.LogInformation("Inicializando UnitOfWork");

            Context = context;
        }

        public Task<bool> CommitAsync()
        {
            _logger?.LogInformation($"Método: { nameof(CommitAsync) }() Retorno: bool");

            return Task.FromResult(Context.SaveChanges() > 0);
        }

        private void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            _logger?.LogInformation($"Método: { nameof(Dispose) }()");

            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
