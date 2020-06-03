using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    public class Video : IAction
    {
        private PaymentDetailsDto paymentDetailsDto;
        public Video(PaymentDetailsDto paymentDetailsDto)
        {
            this.paymentDetailsDto = paymentDetailsDto;
        }
        public string DoProcess()
        {
            string result = string.Format("Added First Aid Video of Product Id {0}",
               paymentDetailsDto.ProductDto.ProductId);
            Console.WriteLine(result);
            return result;
        }
    }
}
