using System;
using System.Collections.Generic;
using System.Linq;
using Generics.Model;
using Generics.Repository.Repositories;

namespace Generics.ServiceLayer
{
    public interface ICustomerService<TResult> where TResult : Customer, new()
    {
        OperationResult<TResult> GetCustomers();

        List<TResult> InActiveCustomers { get; }
    }

    public class CustomerService : ICustomerService<Customer>
    {
        public List<Customer> InActiveCustomers { get; private set; }

        public OperationResult<Customer> GetCustomers()
        {
            var result = new OperationResult<Customer>();

            var customers = new List<Customer>();

            try
            {
                var customerRepo = new CustomerRepository();

                customers = customerRepo.Get();

                this.InActiveCustomers = customers.Where(cust => cust.Active == false).ToList();

                result = new OperationResult<Customer> { Result = customerRepo.Get(), Success = true };
            }
            catch (Exception ex)
            {

                result = new OperationResult<Customer> { Result = null, Success = false, ErrorMessage = ex.Message };
            }

            return result;
        }

        
    }
}
