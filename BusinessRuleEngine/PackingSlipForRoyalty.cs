using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    public class PackingSlipForRoyalty : IAction
    {
        private PaymentDetailsDto paymentDetailsDto;

        public PackingSlipForRoyalty(PaymentDetailsDto paymentDetailsDto)
        {
            this.paymentDetailsDto = paymentDetailsDto;
        }
        public string DoProcess()
        {
            string result = string.Format("Generated duplicate packing slip for Royalty Department of Product Id {0}",
                paymentDetailsDto.ProductDto.ProductId);
            Console.WriteLine(result);
            return result;
        }
    }
}
