using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PetSureExam.Service.Interface;
using PetSureExam.ViewModel;

namespace PetSureExam.API.Controllers
{
    /// <summary>
    /// This is where you can create, update, delete and get the records in customer
    /// </summary>
    public class CustomersController : ApiController
    {
        private ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        /// <summary>
        /// It will get all the data from the customer and address list
        /// </summary>
        /// <returns>list of customer and its address list</returns>
        [HttpGet]
        [Route("api/Customers/GetCustomersList")]
        public IList<CustomerViewModel> GetCustomersList()
        {
            var data = _customerService.GetCustomersList();
            return data;
        }

        /// <summary>
        /// It will get the customer data by id
        /// </summary>
        /// <param name="id">it is the Customer Id/Unique Key</param>
        /// <returns>returns the data of customer object</returns>
        [HttpGet]
        [Route("api/Customers/GetCustomer")]
        public CustomerViewModel GetCustomer(int id)
        {
            var data = _customerService.GetCustomer(id);
            return data;
        }

        /// <summary>
        /// It will save new record
        /// </summary>
        /// <param name="viewModel">customer object</param>
        /// <returns>It will return boolean result if it is successful/fail</returns>
        [HttpPost]
        [Route("api/Customers/CreateCustomer")]
        public bool CreateCustomer(CustomerViewModel viewModel)
        {
            return _customerService.CreateCustomer(viewModel);
        }

        /// <summary>
        /// It will update the data from the record
        /// </summary>
        /// <param name="viewModel">customer object that will be updated to the existing records</param>
        /// <returns>It will return boolean result if it is successful/fail</returns>
        [HttpPut]
        [Route("api/Customers/UpdateCustomer")]
        public bool UpdateCustomer(CustomerViewModel viewModel)
        {
            return _customerService.UpdateCustomer(viewModel);
        }

        /// <summary>
        /// It will delete the data of customer from the record
        /// </summary>
        /// <param name="id">It is the Customer Id/Unique Key</param>
        /// <returns>It will return boolean result if it is successful/fail</returns>
        [HttpDelete]
        [Route("api/Customers/DeleteCustomer")]
        public bool DeleteCustomer(int id)
        {
            return _customerService.DeleteCustomer(id);
        }
    }
}
