
using System;
using BusinessRuleEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessRuleEngineUnitTest
{
    [TestClass]
    public class PackingSlipForShippingTest
    {
        [TestMethod]
        public void GeneratePackingSlipForShipping_Test()
        {
            PaymentDetailsDto paymentDetailsDto = new PaymentDetailsDto();
            paymentDetailsDto.ProductType = ProductEnum.PhysicalProduct;
            paymentDetailsDto.ProductDto = new ProductDto
            {
                Price = 1200,
                ProductId = 1
            };

            PackingSlipForShipping packingSlip = new PackingSlipForShipping(paymentDetailsDto);
            string result = packingSlip.DoProcess();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GenerateCommissionPaymentToAgent_Test()
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

            CommissionPayment commissionPayment = new CommissionPayment(paymentDetailsDto);
            string result = commissionPayment.DoProcess();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GeneratePackingSlipForShippingAndCommissionPayment_Test()
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

            PackingSlipForShipping packingSlip = new PackingSlipForShipping(paymentDetailsDto);
            string packingSlipResult = packingSlip.DoProcess();
            Assert.IsNotNull(packingSlipResult);

            CommissionPayment commissionPayment = new CommissionPayment(paymentDetailsDto);
            string commissionPaymentResult = commissionPayment.DoProcess();
            Assert.IsNotNull(commissionPaymentResult);
        }
    }
}
