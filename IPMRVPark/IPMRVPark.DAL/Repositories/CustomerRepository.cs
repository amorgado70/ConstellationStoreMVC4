using IPMRVPark.Contracts.Data;

using IPMRVPark.Models;
using System;
using System.Linq;

namespace IPMRVPark.Contracts.Repositories
{
    public class CustomerRepository:RepositoryBase<Customer>
    {
        public CustomerRepository(DataContext context):base(context)
        {
            if (context==null)
            {
                throw new ArgumentNullException();
            }
        }
    }
}
