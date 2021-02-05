using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class ProviderRepository :IProviderRepository
    {
        private readonly AppDbContext context;

        public ProviderRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Provider Add(Provider provider)
        {
            context.Providers.Add(provider);
            context.SaveChanges();
            return provider;
        }

        public Provider Delete(int ProviderId)
        {
            Provider provider = context.Providers.Find(ProviderId);
            if (provider != null)
            {
                context.Providers.Remove(provider);
                context.SaveChanges();
            }
            return provider;
        }

        public IEnumerable<Provider> GetAllProviders()
        {
            return context.Providers;
        }

        public Provider GetProvider(int ProviderId)
        {
            return context.Providers.Find(ProviderId);
        }

        public Provider Update(Provider providerChanges)
        {
            var provider = context.Providers.Attach(providerChanges);
            provider.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return providerChanges;
        }
    }
}
