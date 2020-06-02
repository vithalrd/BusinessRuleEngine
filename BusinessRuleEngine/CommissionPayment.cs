using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    /// <summary>
    /// Generate commission payment for Agent
    /// </summary>
    public class CommissionPayment 
    {
        private PaymentDetailsDto paymentDetailsDto;

        public CommissionPayment(PaymentDetailsDto paymentDetailsDto)
        {
            this.paymentDetailsDto = paymentDetailsDto;
        }
        public string DoProcess()
        {
            string result = string.Format("Generated commission payment to the agent name {0}",
                paymentDetailsDto.AgentDto.AgentName);
            Console.WriteLine(result);
            return result;
        }
    }
}
