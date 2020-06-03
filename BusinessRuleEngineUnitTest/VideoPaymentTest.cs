using System;
using BusinessRuleEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessRuleEngineUnitTest
{
    [TestClass]
    public class VideoPaymentTest
    {
        [TestMethod]
        public void VideoPayment_Test()
        {
            PaymentDetailsDto paymentDetailsDto = new PaymentDetailsDto();
            paymentDetailsDto.ProductType = ProductEnum.Video;
            paymentDetailsDto.ProductDto = new ProductDto();
            paymentDetailsDto.ProductDto.ProductId = 101;
            paymentDetailsDto.ProductDto.Price = 200;

            IAction videoPayment = new Video(paymentDetailsDto);
            string result = videoPayment.DoProcess();
            Assert.IsNotNull(result);
        }

      
    }
}
