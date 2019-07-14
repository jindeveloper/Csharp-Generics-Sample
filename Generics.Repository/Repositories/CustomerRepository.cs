using System.Collections.Generic;
using Generics.Model;
using System;

namespace Generics.Repository.Repositories
{
    public interface IRepository<TResult> where TResult : class, new()
    {
        List<TResult> Get();

    }

    public class CustomerRepository : IRepository<Customer>
    {
        public List<Customer> Get()
        {
            return new List<Customer> {
                new Customer {Id = "35798DFKSDF" ,BirthDate = DateTime.Now.AddYears(-20), FirstName = "Pipoy", LastName = "Suarez" },
                new Customer {Id = "357DFKSDF"   ,BirthDate = DateTime.Now.AddYears(-25), FirstName = "Jimmy", LastName = "Cortez" }
            };
        }


    }
}
