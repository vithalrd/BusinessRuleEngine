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

        [TestMethod]
        public void ActionsForBook_Test()
        {
            PaymentDetailsDto paymentDetailsDto = new PaymentDetailsDto();
            paymentDetailsDto.ProductType = ProductEnum.Book;
            paymentDetailsDto.ProductDto = new ProductDto
            {
                Price = 1000,
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


        [TestMethod]
        public void ActionsForMembershipActivation_Test()
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

            var actions = ActionFactory.CreateActions(paymentDetailsDto);
            Assert.IsTrue(actions.Count == 2); // membership activation and sending email

            foreach (var action in actions)
            {
                Assert.IsNotNull(action.DoProcess());
            }

        }

        [TestMethod]
        public void ActionsForMembershipUpgrade_Test()
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

            var actions = ActionFactory.CreateActions(paymentDetailsDto);
            Assert.IsTrue(actions.Count == 2); // membership upgrade and sending email

            foreach (var action in actions)
            {
                Assert.IsNotNull(action.DoProcess());
            }

        }

        [TestMethod]
        public void ActionsForVideoPayment_Test()
        {
            PaymentDetailsDto paymentDetailsDto = new PaymentDetailsDto();
            paymentDetailsDto.ProductType = ProductEnum.Video;
            paymentDetailsDto.ProductDto = new ProductDto();
            paymentDetailsDto.ProductDto.ProductId = 101;
            paymentDetailsDto.ProductDto.Price = 200;

            var actions = ActionFactory.CreateActions(paymentDetailsDto);
            Assert.IsTrue(actions.Count == 1); // sending free video

       
            foreach (var action in actions)
            {
                Assert.IsNotNull(action.DoProcess());
            }

        }
    }
}
