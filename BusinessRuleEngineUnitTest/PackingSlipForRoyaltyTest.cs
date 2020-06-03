﻿
using System;
using BusinessRuleEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessRuleEngineUnitTest
{
    [TestClass]
    public class PackingSlipForRoyaltyTest
    {
        [TestMethod]
        public void GeneratePackingSlipForRoyalty_Test()
        {
            PaymentDetailsDto paymentDetailsDto = new PaymentDetailsDto();
            paymentDetailsDto.ProductType = ProductEnum.Book;
            paymentDetailsDto.ProductDto = new ProductDto
            {
                Price = 1200,
                ProductId = 1
            };

            IAction packingSlip = new PackingSlipForRoyalty(paymentDetailsDto);
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

            IAction commissionPayment = new CommissionPayment(paymentDetailsDto);
            string result = commissionPayment.DoProcess();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GeneratePackingSlipForRoyaltyAndCommissionPayment_Test()
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

            IAction packingSlip = new PackingSlipForRoyalty(paymentDetailsDto);
            string packingSlipResult = packingSlip.DoProcess();
            Assert.IsNotNull(packingSlipResult);

            IAction commissionPayment = new CommissionPayment(paymentDetailsDto);
            string commissionPaymentResult = commissionPayment.DoProcess();
            Assert.IsNotNull(commissionPaymentResult);
        }
    }
}
