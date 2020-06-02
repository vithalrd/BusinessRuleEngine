using System;
using BusinessRuleEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessRuleEngineUnitTest
{
    [TestClass]
    public class SendEmailTest
    {
        [TestMethod]
        public void SendEmail_Test()
        {
            PaymentDetailsDto paymentDetailsDto = new PaymentDetailsDto();
            paymentDetailsDto.CustomerDto = new CustomerDto
            {
                CustomerEmail = "vithalrd@gmail.com",
                CustomerId = 120,
                CustomerName = "Vithal Deshpande"
            };

            IAction emailService = new EmailService(paymentDetailsDto);
            string emailServiceResult = emailService.DoProcess();
            Assert.IsNotNull(emailService);
        }
    }
}
