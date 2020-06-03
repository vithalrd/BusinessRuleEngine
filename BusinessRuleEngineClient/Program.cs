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

            paymentProcessingService = new PaymentProcessingService(paymentDetailsDto);
            paymentProcessingService.ProcessPayment();

            paymentDetailsDto.ProductType = ProductEnum.Book;
            paymentDetailsDto.ProductDto = new ProductDto
            {
                Price = 1200,
                ProductId = 1
            };

            paymentProcessingService = new PaymentProcessingService(paymentDetailsDto);
            paymentProcessingService.ProcessPayment();


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

            paymentDetailsDto.ProductType = ProductEnum.Video;
            paymentDetailsDto.ProductDto = new ProductDto
            {
                Price = 2345,
                ProductId = 55
            };

           
            Console.ReadKey();
        }
    }
}
