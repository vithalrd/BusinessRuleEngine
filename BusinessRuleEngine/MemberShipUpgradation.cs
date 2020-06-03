using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    /// <summary>
    /// Membership upgrade action
    /// </summary>
    public class MemberShipUpgradation : IAction
    {
        private PaymentDetailsDto paymentDetailsDto;

        public MemberShipUpgradation(PaymentDetailsDto paymentDetailsDto)
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
