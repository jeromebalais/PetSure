using PetSureExam.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetSureExam.Repository.Interface
{
    public interface IRepository
    {
        IList<Customer> Data();

        bool Add(Customer value);

        bool Update(Customer viewModel);

        bool Delete(Customer viewModel);
    }
}
