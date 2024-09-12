using StockMobile.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMobile.Repositories.SignUp
{
    public interface ISignUpRepository
    {
        Task<bool> CreateAsync(SignupRequest request);
    }
}
