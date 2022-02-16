using BankingCustomerServiceHub.Services;
using BankingCustomerServiceModel.Models.Customer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingCustomerService.Controllers
{
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        [Route("api/CreateAccount")]
        public async Task<CreateAccountResponse> CreateAccount()
        {
            CreateAccountResponse response = new CreateAccountResponse();

            if (ModelState.IsValid)
            {
                //if (request == null)
                //{
                //    response.ResponseCode = 44;
                //    response.ResponseStatus = "Bad Request";
                //    response.ResponseDescription = ModelState.ValidationState.ToString();
                //}
                var res = await new CreateAccountService().GetAvailableAccountNumber();
            }

            return response;
        }
    }
}
