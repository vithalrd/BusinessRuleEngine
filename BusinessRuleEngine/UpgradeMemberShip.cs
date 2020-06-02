using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    public class UpgradeMemberShip
    {
        private PaymentDetailsDto paymentDetailsDto;

        public UpgradeMemberShip(PaymentDetailsDto paymentDetailsDto)
        {
            this.paymentDetailsDto = paymentDetailsDto;
        }

        public string DoProcess()
        {
            string result = string.Format("Memberships has been upgraded for Member Id {0}",
              paymentDetailsDto.MembershipDto.MembershipId);
            Console.WriteLine(result);
            return result;
        }
    }
}
