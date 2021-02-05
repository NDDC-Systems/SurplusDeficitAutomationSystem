using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public interface IContractRepository
    {
        Contract GetContract(int ContractId);
        IEnumerable<Contract> GetAllContracts();
        Contract Add(Contract contract);
        Contract Update(Contract contractChanges);
        Contract Delete(int ContractId);
    }
}
