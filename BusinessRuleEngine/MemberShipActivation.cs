using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    /// <summary>
    /// Membership activate action
    /// </summary>
    public class MemberShipActivation : IAction
    {
        private PaymentDetailsDto paymentDetailsDto;
        public MemberShipActivation(PaymentDetailsDto paymentDetailsDto)
        {
            this.paymentDetailsDto = paymentDetailsDto;
        }
        public string DoProcess()
        {
            string result = string.Format("Memberships has been activated for Member Id {0}",
               paymentDetailsDto.MembershipDto.MembershipId);
            Console.WriteLine(result);
            return result;
        }
    }
}
