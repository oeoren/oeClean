using oeClean.Domain.Common;
using System.Threading.Tasks;

namespace oeClean.Application.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}
