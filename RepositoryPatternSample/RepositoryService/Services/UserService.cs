using Contracts;
using Contracts.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryService
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IUserAddressRepository userAddressRepository;
        private readonly ICardPaymentDetailRepository cardPaymentDetailRepository;

        public UserService(IUserRepository userRepository, IUserAddressRepository userAddressRepository, ICardPaymentDetailRepository cardPaymentDetailRepository)
        {
            this.userRepository = userRepository;
            this.userAddressRepository = userAddressRepository;
            this.cardPaymentDetailRepository = cardPaymentDetailRepository;
        }

        public void AddCardPaymentDetail(CardPaymentDetail cardPaymentDetail)
        {
            this.cardPaymentDetailRepository.Create(cardPaymentDetail);
        }

        public void AddUserAddress(UserAddress userAddress)
        {
            this.userAddressRepository.Create(userAddress);
        }

        public void CreateUser(User user)
        {
            userRepository.Create(user);
            userRepository.SaveChanges();
        }
    }
}
