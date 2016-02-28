using ItAcademy.PropertyCenter.Repository.Caching;

namespace ItAcademy.PropertyCenter.Repository.Contracts
{
    public interface ICacheRepository
    {
        ICacheProvider CacheProvider { get; }
    }
}
