using BankingCustomerServiceHub.Interface;
using BankingCustomerServiceModel.Models.Customer;
using BankingCustomerServiceRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingCustomerServiceHub.Services
{
    public class CreateAccountService : ICreateAccountService
    {
        public async Task<CreateAccountResponse> CreateAccount(CreateAccountRequest createAccountRequest)
        {
            CreateAccountResponse response = new CreateAccountResponse();
            CustomerServiceRepo customerRepo = new CustomerServiceRepo();
            var res = await GetAvailableAccountNumber();

            return response;
        }

        public async Task<string> GetAvailableAccountNumber()
        {
            string availableAccountNum = string.Empty;

            availableAccountNum = await new CustomerServiceRepo().GetLastAccountCreated();

            if (string.IsNullOrEmpty(availableAccountNum))
            {
                availableAccountNum = "0000000001";
            }

            return availableAccountNum;
        }
    }
}
