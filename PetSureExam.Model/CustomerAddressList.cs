using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetSureExam.Model
{
    public class CustomerAddressList
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
