using System;
using System.Collections.Generic;
using System.Text;

namespace BankingCustomerServiceModel.Models
{
    public class GeneralResponse
    {
        public int ResponseCode { get; set; }
        public string ResponseStatus { get; set; }
        public string ResponseDescription { get; set; }
    }
}
