using BusinessRuleEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngineClient
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentProcessingService paymentProcessingService = null;

            // Physical Product
            paymentProcessingService = GetPaymentProcessingServiceForPhysicalProduct();
            paymentProcessingService.ProcessPayment();

            // Book Product
            paymentProcessingService = GetPaymentProcessingServiceForBook();
            paymentProcessingService.ProcessPayment();

            // Membership Activation
            paymentProcessingService = GetPaymentProcessingServiceForMembershipActivation();
            paymentProcessingService.ProcessPayment();

            // Membership Upgradation
            paymentProcessingService = GetPaymentProcessingServiceForMembershipUpgradation();
            paymentProcessingService.ProcessPayment();

            // Video Product
            paymentProcessingService = GetPaymentProcessingServiceForVideo();
            paymentProcessingService.ProcessPayment();

            Console.ReadKey();
        }

        public static PaymentProcessingService GetPaymentProcessingServiceForPhysicalProduct()
        {
            PaymentDetailsDto paymentDetailsDto = new PaymentDetailsDto();

            paymentDetailsDto.ProductType = ProductEnum.PhysicalProduct;
            paymentDetailsDto.ProductDto = new ProductDto
            {
                Price = 1200,
                ProductId = 1
            };
            paymentDetailsDto.AgentDto = new AgentDto
            {
                AgentId = 200,
                AgentName = "John Miller"
            };

            return new PaymentProcessingService(paymentDetailsDto);
        }

        public static PaymentProcessingService GetPaymentProcessingServiceForBook()
        {
            PaymentDetailsDto paymentDetailsDto = new PaymentDetailsDto();

            paymentDetailsDto.ProductType = ProductEnum.Book;
            paymentDetailsDto.ProductDto = new ProductDto
            {
                Price = 1200,
                ProductId = 1
            };
            paymentDetailsDto.AgentDto = new AgentDto
            {
                AgentId = 200,
                AgentName = "John Miller"
            };

            return new PaymentProcessingService(paymentDetailsDto);
        }

        public static PaymentProcessingService GetPaymentProcessingServiceForMembershipActivation()
        {
            PaymentDetailsDto paymentDetailsDto = new PaymentDetailsDto();

            paymentDetailsDto.ProductType = ProductEnum.ActivateMembership;
            paymentDetailsDto.MembershipDto = new MembershipDto
            {
                MembershipId = 10001,
                MembershipName = "Prime Membership"
            };
            paymentDetailsDto.CustomerDto = new CustomerDto
            {
                CustomerEmail = "vithalrd@gmail.com",
                CustomerId = 120,
                CustomerName = "Vithal Deshpande"
            };

            return new PaymentProcessingService(paymentDetailsDto);
        }

        public static PaymentProcessingService GetPaymentProcessingServiceForMembershipUpgradation()
        {
            PaymentDetailsDto paymentDetailsDto = new PaymentDetailsDto();

            paymentDetailsDto.ProductType = ProductEnum.UpgradeMembership;
            paymentDetailsDto.MembershipDto = new MembershipDto
            {
                MembershipId = 10001,
                MembershipName = "Prime Membership"
            };
            paymentDetailsDto.CustomerDto = new CustomerDto
            {
                CustomerEmail = "vithalrd@gmail.com",
                CustomerId = 120,
                CustomerName = "Vithal Deshpande"
            };

            return new PaymentProcessingService(paymentDetailsDto);
        }

        public static PaymentProcessingService GetPaymentProcessingServiceForVideo()
        {
            PaymentDetailsDto paymentDetailsDto = new PaymentDetailsDto();

            paymentDetailsDto.ProductType = ProductEnum.Video;
            paymentDetailsDto.ProductDto = new ProductDto
            {
                Price = 2345,
                ProductId = 55
            };


            return new PaymentProcessingService(paymentDetailsDto);
        }
    }
}
