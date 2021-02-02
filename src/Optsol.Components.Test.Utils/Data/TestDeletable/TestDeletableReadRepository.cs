using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Optsol.Components.Infra.Data;

namespace Optsol.Components.Test.Utils.Entity
{
    public class TestDeletableReadRepository : Repository<TestDeletableEntity, Guid>, ITestDeletableReadRepository
    {
        public TestDeletableReadRepository(CoreContext context, ILogger<Repository<TestDeletableEntity, Guid>> logger) 
            : base(context, logger)
        {
        }
    }

    
}
