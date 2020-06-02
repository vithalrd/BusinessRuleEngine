using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    public class EmailService 
    {
        private PaymentDetailsDto paymentDetailsDto;

        public EmailService(PaymentDetailsDto paymentDetailsDto)
        {
            this.paymentDetailsDto = paymentDetailsDto;
        }
        public string DoProcess()
        {
            string result = string.Format("Email has been sent to Email Id {0}",
              paymentDetailsDto.CustomerDto.CustomerEmail);
            Console.WriteLine(result);
            return result;
        }
    }
}
