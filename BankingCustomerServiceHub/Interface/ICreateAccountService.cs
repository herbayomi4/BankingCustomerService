using BankingCustomerServiceModel.Models.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingCustomerServiceHub.Interface
{
    public interface ICreateAccountService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="createAccountRequest"></param>
        /// <returns></returns>
        Task<CreateAccountResponse> CreateAccount(CreateAccountRequest createAccountRequest);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<string> GetAvailableAccountNumber();
    }
}
