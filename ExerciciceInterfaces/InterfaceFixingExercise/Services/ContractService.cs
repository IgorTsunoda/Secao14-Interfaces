using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceFixingExercise.Entities;

namespace InterfaceFixingExercise.Services
{
    class ContractService
    {
        private IOnlinePaymentsService _onlinePaymentService;

        public ContractService(IOnlinePaymentsService onlinePaymentsService)
        {
            _onlinePaymentService = onlinePaymentsService;
        }
        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.ContractDate.AddMonths(i);
                double updatedQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
