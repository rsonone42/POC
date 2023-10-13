using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Services
{
    public interface IUserService
    {
        void CreateUser(User user);

        void AddUserAddress(UserAddress userAddress);

        void AddCardPaymentDetail(CardPaymentDetail cardPaymentDetail);
    }
}
