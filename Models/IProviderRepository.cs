using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public interface IProviderRepository
    {
        Provider GetProvider(int ProviderId);
        IEnumerable<Provider> GetAllProviders();
        Provider Add(Provider provider);
        Provider Update(Provider providerChanges);
        Provider Delete(int ProviderId);
    }
}
