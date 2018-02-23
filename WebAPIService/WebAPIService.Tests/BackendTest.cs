using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using WebAPIService.Models;
using Newtonsoft.Json;
using WebAPIService.Controllers;
using System.Net.Http;

namespace WebAPIService.Tests
{
    [TestClass]
    public class BackendTest
    {
        string filePath = "c:\\logs\\payments_details.txt";

        [TestMethod]
        public void TestPaymentDetailsSaved()
        {
            // We do not need to do this step if the payment was saved in database with a identity or primary key.
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            PaymentModel model = new PaymentModel
            {
                AccountName = "Test",
                AccountNumber = 12345678,
                Amount = 200.00M,
                BSB = 123456,
                Currency = "AUD",
                Reference = "None"
            };

            PaymentsController pc = new PaymentsController();
            pc.Request = new HttpRequestMessage();
            pc.Configuration = new System.Web.Http.HttpConfiguration();
            HttpResponseMessage response = pc.Post(model);
            Assert.IsTrue(response.IsSuccessStatusCode);

            var savedPayment = ReadContentFromFile();
            Assert.AreEqual(model.AccountNumber, savedPayment.AccountNumber);
        }

        private PaymentModel ReadContentFromFile()
        {
            TextReader reader = null;
            try
            {
                reader = new StreamReader(filePath);
                var fileContents = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<PaymentModel>(fileContents);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
    }
}
