using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    /// <summary>
    /// This services returns list of actions to executed on product payment
    /// </summary>
    public class PaymentProcessingService
    {
        List<IAction> actions = new List<IAction>();

        public PaymentProcessingService(PaymentDetailsDto productDto)
        {
            actions = ActionFactory.CreateActions(productDto);
        }

        public void ProcessPayment()
        {
            foreach (var action in actions)
            {
                action.DoProcess();
            }
        }
    }
}
