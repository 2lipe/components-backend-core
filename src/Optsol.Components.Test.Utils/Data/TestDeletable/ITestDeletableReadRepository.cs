using System;
using Optsol.Components.Infra.Data;

namespace Optsol.Components.Test.Utils.Entity
{
    public interface ITestDeletableReadRepository: IReadRepository<TestDeletableEntity, Guid>
    {
    }
}
