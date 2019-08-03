using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetSureExam.Repository.Interface;
using PetSureExam.Model;

namespace PetSureExam.Repository.Implementation
{
    public class Repository : IRepository
    {
        List<Customer> customer = new List<Customer>();
        List<CustomerAddressList> customerAddressList = new List<CustomerAddressList>();
        public Repository()
        {
            customerAddressList.Add(new CustomerAddressList { Id = 1, CustomerId = 1, AddressLine1 = "Taguig ", AddressLine2 = "Metro Manila", City = "Taguig", State = "Philippines" });
            customerAddressList.Add(new CustomerAddressList { Id = 2, CustomerId = 1, AddressLine1 = "Makati", AddressLine2 = "Metro Manila", City = "Makati", State = "Philippines" });
            customerAddressList.Add(new CustomerAddressList { Id = 3, CustomerId = 1, AddressLine1 = "Ortigas", AddressLine2 = "Metro Manila", City = "Ortigas", State = "Philippines" });
            customerAddressList.Add(new CustomerAddressList { Id = 4, CustomerId = 2, AddressLine1 = "Baguio", AddressLine2 = "Baguio", City = "Baguio", State = "Philippines" });
            customerAddressList.Add(new CustomerAddressList { Id = 5, CustomerId = 3, AddressLine1 = "Taguig", AddressLine2 = "Metro Manila", City = "Taguig", State = "Philippines" });
            customerAddressList.Add(new CustomerAddressList { Id = 6, CustomerId = 3, AddressLine1 = "Davao", AddressLine2 = "Davao", City = "Davao", State = "Philippines" });
            customerAddressList.Add(new CustomerAddressList { Id = 7, CustomerId = 4, AddressLine1 = "Cebu", AddressLine2 = "Cebu", City = "Cebu", State = "Philippines" });
            customerAddressList.Add(new CustomerAddressList { Id = 8, CustomerId = 5, AddressLine1 = "Baguio", AddressLine2 = "Baguio", City = "Baguio", State = "Philippines" });
            customerAddressList.Add(new CustomerAddressList { Id = 9, CustomerId = 6, AddressLine1 = "Taguig", AddressLine2 = "Metro Manila", City = "Taguig", State = "Philippines" });
            customerAddressList.Add(new CustomerAddressList { Id = 10, CustomerId = 6, AddressLine1 = "Davao", AddressLine2 = "Davao", City = "Davao", State = "Philippines" });
            customerAddressList.Add(new CustomerAddressList { Id = 11, CustomerId = 7, AddressLine1 = "Cebu", AddressLine2 = "Cebu", City = "Cebu", State = "Philippines" });
            customerAddressList.Add(new CustomerAddressList { Id = 12, CustomerId = 8, AddressLine1 = "Makati", AddressLine2 = "Metro Manila", City = "Makati", State = "Philippines" });
            customerAddressList.Add(new CustomerAddressList { Id = 13, CustomerId = 9, AddressLine1 = "Makati", AddressLine2 = "Metro Manila", City = "Makati", State = "Philippines" });

            customer.Add(new Customer
            {
                Id = 1,
                FullName = "Jerome Balais",
                DateOfBirth = Convert.ToDateTime("02/24/1991"),
                Age = 28,
                CustomerAddressLists = customerAddressList.Where(c => c.CustomerId == 1).Select(x => new CustomerAddressList
                {
                    Id = x.Id,
                    CustomerId = x.CustomerId,
                    AddressLine1 = x.AddressLine1,
                    AddressLine2 = x.AddressLine2,
                    City = x.City,
                    State = x.State
                }).ToList()
            });

            customer.Add(new Customer
            {
                Id = 2,
                FullName = "John Cruz",
                DateOfBirth = Convert.ToDateTime("01/24/2000"),
                Age = 28,
                CustomerAddressLists = customerAddressList.Where(c => c.CustomerId == 2).Select(x => new CustomerAddressList
                {
                    Id = x.Id,
                    CustomerId = x.CustomerId,
                    AddressLine1 = x.AddressLine1,
                    AddressLine2 = x.AddressLine2,
                    City = x.City,
                    State = x.State
                }).ToList()
            });

            customer.Add(new Customer
            {
                Id = 3,
                FullName = "Peter Cruz",
                DateOfBirth = Convert.ToDateTime("03/22/1998"),
                Age = 28,
                CustomerAddressLists = customerAddressList.Where(c => c.CustomerId == 3).Select(x => new CustomerAddressList
                {
                    Id = x.Id,
                    CustomerId = x.CustomerId,
                    AddressLine1 = x.AddressLine1,
                    AddressLine2 = x.AddressLine2,
                    City = x.City,
                    State = x.State
                }).ToList()
            });

            customer.Add(new Customer
            {
                Id = 4,
                FullName = "Mark Storm",
                DateOfBirth = Convert.ToDateTime("03/05/2001"),
                Age = 28,
                CustomerAddressLists = customerAddressList.Where(c => c.CustomerId == 4).Select(x => new CustomerAddressList
                {
                    Id = x.Id,
                    CustomerId = x.CustomerId,
                    AddressLine1 = x.AddressLine1,
                    AddressLine2 = x.AddressLine2,
                    City = x.City,
                    State = x.State
                }).ToList()
            });

            customer.Add(new Customer
            {
                Id = 5,
                FullName = "Mary Smith",
                DateOfBirth = Convert.ToDateTime("12/08/2006"),
                Age = 28,
                CustomerAddressLists = customerAddressList.Where(c => c.CustomerId == 5).Select(x => new CustomerAddressList
                {
                    Id = x.Id,
                    CustomerId = x.CustomerId,
                    AddressLine1 = x.AddressLine1,
                    AddressLine2 = x.AddressLine2,
                    City = x.City,
                    State = x.State
                }).ToList()
            });

            customer.Add(new Customer
            {
                Id = 6,
                FullName = "Jane Peng",
                DateOfBirth = Convert.ToDateTime("11/02/1995"),
                Age = 28,
                CustomerAddressLists = customerAddressList.Where(c => c.CustomerId == 6).Select(x => new CustomerAddressList
                {
                    Id = x.Id,
                    CustomerId = x.CustomerId,
                    AddressLine1 = x.AddressLine1,
                    AddressLine2 = x.AddressLine2,
                    City = x.City,
                    State = x.State
                }).ToList()
            });

            customer.Add(new Customer
            {
                Id = 7,
                FullName = "Peter Jake",
                DateOfBirth = Convert.ToDateTime("06/06/2001"),
                Age = 28,
                CustomerAddressLists = customerAddressList.Where(c => c.CustomerId == 7).Select(x => new CustomerAddressList
                {
                    Id = x.Id,
                    CustomerId = x.CustomerId,
                    AddressLine1 = x.AddressLine1,
                    AddressLine2 = x.AddressLine2,
                    City = x.City,
                    State = x.State
                }).ToList()
            });

            customer.Add(new Customer
            {
                Id = 8,
                FullName = "Jan Jan",
                DateOfBirth = Convert.ToDateTime("07/05/2015"),
                Age = 28,
                CustomerAddressLists = customerAddressList.Where(c => c.CustomerId == 8).Select(x => new CustomerAddressList
                {
                    Id = x.Id,
                    CustomerId = x.CustomerId,
                    AddressLine1 = x.AddressLine1,
                    AddressLine2 = x.AddressLine2,
                    City = x.City,
                    State = x.State
                }).ToList()
            });

            customer.Add(new Customer
            {
                Id = 9,
                FullName = "Buggy Buggies",
                DateOfBirth = Convert.ToDateTime("12/25/2000"),
                Age = 28,
                CustomerAddressLists = customerAddressList.Where(c => c.CustomerId == 9).Select(x => new CustomerAddressList
                {
                    Id = x.Id,
                    CustomerId = x.CustomerId,
                    AddressLine1 = x.AddressLine1,
                    AddressLine2 = x.AddressLine2,
                    City = x.City,
                    State = x.State
                }).ToList()
            });
        }

        public IList<Customer> Data()
        {
            return customer;
        }

        public bool Add(Customer viewModel)
        {
            try
            {
                customer.Add(viewModel);
                //customer.Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Customer viewModel)
        {
            try
            {
                //customer.Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(Customer viewModel)
        {
            try
            {
                customer.Remove(viewModel);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
