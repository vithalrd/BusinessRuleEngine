﻿using System;
using BusinessRuleEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessRuleEngineUnitTest
{
    [TestClass]
    public class MembershipTest
    {
        [TestMethod]
        public void ActivateMembership_Test()
        {
            PaymentDetailsDto paymentDetailsDto = new PaymentDetailsDto();
            paymentDetailsDto.ProductType = ProductEnum.ActivateMembership;
            paymentDetailsDto.MembershipDto = new MembershipDto
            {
               MembershipId = 10001,
               MembershipName = "Prime Membership"
            };

            IAction activateMemberShip = new MemberShipActivation(paymentDetailsDto);
            string result = activateMemberShip.DoProcess();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void UpgradeMembership_Test()
        {
            PaymentDetailsDto paymentDetailsDto = new PaymentDetailsDto();
            paymentDetailsDto.ProductType = ProductEnum.UpgradeMembership;
            paymentDetailsDto.MembershipDto = new MembershipDto
            {
                MembershipId = 10001,
                MembershipName = "Prime Membership"
            };

            IAction upgradeMemberShip = new MemberShipUpgradation(paymentDetailsDto);
            string result = upgradeMemberShip.DoProcess();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ActivateMembershipAndSendEmail_Test()
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

            IAction activateMemberShip = new MemberShipActivation(paymentDetailsDto);
            string result = activateMemberShip.DoProcess();
            Assert.IsNotNull(result);

            IAction emailService = new EmailService(paymentDetailsDto);
            string emailServiceResult = emailService.DoProcess();
            Assert.IsNotNull(emailServiceResult);
        }
        [TestMethod]
        public void UpgradeMembershipAndSendEmail_Test()
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
            IAction upgradeMemberShip = new MemberShipUpgradation(paymentDetailsDto);
            string result = upgradeMemberShip.DoProcess();
            Assert.IsNotNull(result);

            IAction emailService = new EmailService(paymentDetailsDto);
            string emailServiceResult = emailService.DoProcess();
            Assert.IsNotNull(emailServiceResult);
        }
    }
}
