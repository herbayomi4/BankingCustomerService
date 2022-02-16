using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using BankingCustomerServiceModel.Models.Customer;
//using BankingCustomerServiceRepo.Interface;

namespace BankingCustomerServiceRepo
{
    public class CustomerServiceRepo
    {
        public Task<CreateAccountResponse> CheckAndCreateAccount(CreateAccountRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetLastAccountCreated()
        {
            string connString = ConfigurationManager.AppSettings["SQLConnection"];

            string lastAccount = string.Empty;
            SqlDataReader sqlData;
            //DataTable dt;
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand("GetLatestAccountNumber", conn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    sqlData = await cmd.ExecuteReaderAsync(CommandBehavior.CloseConnection);


                }
                if (sqlData.HasRows)
                {
                    sqlData.Read();
                    lastAccount = sqlData[0].ToString();
                }
            }
            catch (SqlException sql)
            {

                throw;
            }
            
            return lastAccount;
        }
    }
}
