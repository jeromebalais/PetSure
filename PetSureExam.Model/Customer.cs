using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetSureExam.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }

        private List<CustomerAddressList> _customerAddressLists = new List<CustomerAddressList>();
        public virtual List<CustomerAddressList> CustomerAddressLists
        {
            get { return _customerAddressLists; }
            set { _customerAddressLists = value; }
        }
    }
}
