using PetSureExam.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetSureExam.Service.Interface
{
    public interface ICustomerService
    {
        IList<CustomerViewModel> GetCustomersList();
        CustomerViewModel GetCustomer(int id);
        bool CreateCustomer(CustomerViewModel viewModel);
        bool UpdateCustomer(CustomerViewModel viewModel);
        bool DeleteCustomer(int id);
    }
}
