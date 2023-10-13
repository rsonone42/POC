using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class CardPaymentDetail
    {
        public long Id { get; set; }

        public string CardNumber { get; set; }

        public string NameOnCard { get; set; }

        public DateTime ExpiryDate { get; set; }

        public string Provider { get; set; }

        public DateTime LastUsedDate { get; set; }

        public bool IsActive { get; set; }

        public DateTime? DeletedDate { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }

        public User User { get; set; }
    }
}
