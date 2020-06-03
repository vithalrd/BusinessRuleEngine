using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    public class ActionFactory
    {
        public static List<IAction> CreateActions(PaymentDetailsDto productDto)
        {
            List<IAction> Actions = new List<IAction>();
            switch (productDto.ProductType)
            {
                case ProductEnum.ActivateMembership:
                    Actions.Add(new ActivateMemberShip(productDto));
                    Actions.Add(new EmailService(productDto));
                    break;
                case ProductEnum.UpgradeMembership:
                    Actions.Add(new UpgradeMemberShip(productDto));
                    Actions.Add(new EmailService(productDto));
                    break;
                case ProductEnum.Book:
                    Actions.Add(new PackingSlipForRoyalty(productDto));
                    Actions.Add(new CommissionPayment(productDto));
                    break;
                case ProductEnum.PhysicalProduct:
                    Actions.Add(new PackingSlipForShipping(productDto));
                    Actions.Add(new CommissionPayment(productDto));
                    break;
                case ProductEnum.Video:
                    Actions.Add(new Video(productDto));
                    break;
            }

            return Actions;
        }
    }
}
