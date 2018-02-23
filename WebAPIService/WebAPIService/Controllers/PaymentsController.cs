using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIService.Helper;
using WebAPIService.Models;

namespace WebAPIService.Controllers
{
    public class PaymentsController : ApiController
    {
        private PaymentsHelper helper;
        private log4net.ILog logger;
        public PaymentsController()
        {
            helper = new PaymentsHelper();
            logger = log4net.LogManager.GetLogger(typeof(PaymentsController));
    }

        // GET: api/Payments
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Payments/5
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// REST Api method to save payment details.
        /// </summary>
        /// <param name="payment">Payment details</param>
        /// <returns></returns>
        // POST: api/Payments
        public HttpResponseMessage Post(PaymentModel payment)
        {
            logger.Info("Request recieved from Client. Details: " + Request.Headers.ToString());

            try
            {
                helper.SavePaymentDetails(payment);
                logger.Info("Request processed successfully.");
                return Request.CreateResponse(HttpStatusCode.OK, "Success");
            }
            catch(Exception ex)
            {
                logger.Info("Request failed.", ex);
                return Request.CreateErrorResponse(HttpStatusCode.Forbidden, ex.Message);
            }
        }

        // PUT: api/Payments/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Payments/5
        public void Delete(int id)
        {
        }
    }
}
