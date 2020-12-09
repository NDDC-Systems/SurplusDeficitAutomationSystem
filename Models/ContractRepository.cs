using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class ContractRepository : IContractRepository
    {
        private readonly AppDbContext context;

        public ContractRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Contract Add(Contract contract)
        {
            context.Contracts.Add(contract);
            context.SaveChanges();
            return contract;
        }

        public Contract Delete(int ContractId)
        {
            Contract contract = context.Contracts.Find(ContractId);
            if (contract != null)
            {
                context.Contracts.Remove(contract);
                context.SaveChanges();
            }
            return contract;
        }

        public IEnumerable<Contract> GetAllContracts()
        {
            return context.Contracts;
        }

        public Contract GetContract(int ContractId)
        {
            return context.Contracts.Find(ContractId);
        }

        public Contract Update(Contract reportChanges)
        {
            var contract = context.Contracts.Attach(reportChanges);
            contract.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return reportChanges;
        }
    }
}
