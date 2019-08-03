using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetSureExam.Service.Interface;
using PetSureExam.ViewModel;
using PetSureExam.Repository.Interface;
using PetSureExam.Model;
using System.IO;

namespace PetSureExam.Service.Implementation
{
    public class CustomerService : ICustomerService
    {
        private IRepository _repository;
        public CustomerService(IRepository repository)
        {
            _repository = repository;
        }

        public IList<CustomerViewModel> GetCustomersList()
        {
            try
            {
                var viewModel = new List<CustomerViewModel>();

                var customerModel = _repository.Data();

                foreach (var customer in customerModel)
                {
                    var customers = new CustomerViewModel()
                    {
                        Id = customer.Id,
                        FullName = customer.FullName,
                        DateOfBirth = customer.DateOfBirth,
                        Age = customer.Age,
                        CustomerAddressLists = customer.CustomerAddressLists.Select(x => new CustomerAddressListViewModel
                        {
                            AddressLine1 = x.AddressLine1,
                            AddressLine2 = x.AddressLine2,
                            City = x.City,
                            State = x.State
                        }).ToList()
                    };
                    viewModel.Add(customers);
                }

                return viewModel;
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                return null;
            }
        }

        public CustomerViewModel GetCustomer(int id)
        {
            try
            {
                var model = _repository.Data().Where(x => x.Id == id).FirstOrDefault();

                var viewModel = new CustomerViewModel
                {
                    Id = model.Id,
                    FullName = model.FullName,
                    DateOfBirth = model.DateOfBirth,
                    Age = model.Age,
                    CustomerAddressLists = model.CustomerAddressLists.Select(x => new CustomerAddressListViewModel
                    {
                        AddressLine1 = x.AddressLine1,
                        AddressLine2 = x.AddressLine2,
                        City = x.City,
                        State = x.State
                    }).ToList()
                };

                return viewModel;
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                return null;
            }
        }

        public bool CreateCustomer(CustomerViewModel viewModel)
        {
            try
            {
                var customer = new Customer
                {
                    Id = viewModel.Id,
                    FullName = viewModel.FullName,
                    DateOfBirth = viewModel.DateOfBirth,
                    Age = viewModel.Age,
                    CustomerAddressLists = viewModel.CustomerAddressLists.Select(x => new CustomerAddressList
                    {
                        AddressLine1 = x.AddressLine1,
                        AddressLine2 = x.AddressLine2,
                        City = x.City,
                        State = x.State
                    }).ToList()
                };

                return _repository.Add(customer);
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                return false;
            }
        }

        public bool UpdateCustomer(CustomerViewModel viewModel)
        {
            try
            {
                IList<CustomerViewModel> itemToRemove = new List<CustomerViewModel>();
                var model = _repository.Data().Where(x => x.Id == viewModel.Id).FirstOrDefault();

                if (model != null)
                {
                    model.Id = viewModel.Id;
                    model.FullName = viewModel.FullName;
                    model.DateOfBirth = viewModel.DateOfBirth;
                    model.Age = viewModel.Age;
                    model.CustomerAddressLists = viewModel.CustomerAddressLists.Select(
                        x => new CustomerAddressList
                        {
                            AddressLine1 = x.AddressLine1,
                            AddressLine2 = x.AddressLine2,
                            City = x.City,
                            State = x.State
                        }).ToList();

                    return _repository.Update(model);
                }

                return true;
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                return false;
            }
        }

        public bool DeleteCustomer(int id)
        {
            try
            {
                var model = _repository.Data().Where(x => x.Id == id).FirstOrDefault();
                return _repository.Delete(model);
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                return false;
            }
        }

        public static void ErrorLogging(Exception ex)
        {
            string strPath = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, System.AppDomain.CurrentDomain.RelativeSearchPath ?? "");
            string filePath = strPath + "\\logfile.txt";
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Dispose();
            }
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine("=============Error Logging ===========");
                sw.WriteLine("===========Start============= " + DateTime.Now);
                sw.WriteLine("Error Message: " + ex.Message);
                sw.WriteLine("Stack Trace: " + ex.StackTrace);
                sw.WriteLine("============End============== " + DateTime.Now);
                sw.WriteLine("");

            }
        }
    }
}
