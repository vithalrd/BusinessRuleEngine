using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    /// <summary>
    /// Process the payment and geneated packing slip for shipping
    /// </summary>
    public class PackingSlipForShipping : IAction
    {
        private PaymentDetailsDto paymentDetailsDto;

        public PackingSlipForShipping(PaymentDetailsDto paymentDetailsDto)
        {
            this.paymentDetailsDto = paymentDetailsDto;
        }
        public string DoProcess()
        {
            string result = string.Format("Generated packing slip for shipping of Product Id {0}",
                paymentDetailsDto.ProductDto.ProductId);
            Console.WriteLine(result);
            return result;
        }
    }
}
