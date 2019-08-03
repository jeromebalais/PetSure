using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetSureExam.ViewModel
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }

        private List<CustomerAddressListViewModel> _customerAddressLists = new List<CustomerAddressListViewModel>();
        public virtual List<CustomerAddressListViewModel> CustomerAddressLists
        {
            get { return _customerAddressLists; }
            set { _customerAddressLists = value; }
        }
    }

    public class CustomerAddressListViewModel
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }


}
