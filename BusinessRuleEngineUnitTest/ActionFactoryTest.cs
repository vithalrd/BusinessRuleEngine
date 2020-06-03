using System;
using BusinessRuleEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessRuleEngineUnitTest
{
    [TestClass]
    public class ActionFactoryTest
    {
        [TestMethod]
        public void ActionsForPhysicalProduct_Test()
        {
            PaymentDetailsDto paymentDetailsDto = new PaymentDetailsDto();
            paymentDetailsDto.ProductType = ProductEnum.PhysicalProduct;
            paymentDetailsDto.ProductDto = new ProductDto
            {
                Price = 1200,
                ProductId = 1
            };

            var actions = ActionFactory.CreateActions(paymentDetailsDto);
            Assert.IsTrue(actions.Count == 2); // one of packing slip for shipping and agent payment generation

            paymentDetailsDto.AgentDto = new AgentDto
            {
                AgentId = 200,
                AgentName = "John Miller"
            };
            foreach (var action in actions)
            {
                Assert.IsNotNull(action.DoProcess());
            }

        }
    }
}
