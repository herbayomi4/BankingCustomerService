using System;
using System.Collections.Generic;
using System.Text;

namespace BankingCustomerServiceModel.Models.Customer
{
    public class CreateAccountResponse : GeneralResponse
    {
        public string fname { get; set; }
    }

    public class GetLastAccountResponse
    {
        public string AccountNumber { get; set; }
    }
}
