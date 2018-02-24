using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using WebAPIService.Models;
using WebAPIService.Utilities;

namespace WebAPIService.Helper
{
    public class PaymentsHelper
    {
        /// <summary>
        /// SavePaymentDetails saves payment details.
        /// </summary>
        /// <param name="payment">Payment detail</param>
        internal void SavePaymentDetails(PaymentModel payment)
        {
            TextWriter writer = null;
            
            try
            {
                var contentsToWriteToFile = JsonConvert.SerializeObject(payment);
                writer = NotePadWriter.Instance;
                writer.Write(contentsToWriteToFile);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                
            }
        }
    }
}