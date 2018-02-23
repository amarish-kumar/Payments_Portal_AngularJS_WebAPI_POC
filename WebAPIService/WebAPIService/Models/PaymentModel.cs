using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIService.Models
{
    /// <summary>
    /// Payment Model
    /// </summary>
    public class PaymentModel
    {
        private double bsbField;

        /// <summary>
        /// BSB
        /// </summary>
        public double BSB
        {
            get { return bsbField; }
            set { bsbField = value; }
        }

        private double accountNumberField;

        /// <summary>
        /// Account Number 
        /// </summary>
        public double AccountNumber
        {
            get { return accountNumberField; }
            set { accountNumberField = value; }
        }

        private string accountNameField;

        /// <summary>
        /// Account Name
        /// </summary>
        public string AccountName
        {
            get { return accountNameField; }
            set { accountNameField = value; }
        }

        private string referenceField;

        /// <summary>
        /// Reference
        /// </summary>
        public string Reference
        {
            get { return referenceField; }
            set { referenceField = value; }
        }

        private string currencyField;

        /// <summary>
        /// Currency
        /// </summary>
        public string Currency
        {
            get { return currencyField; }
            set { currencyField = value; }
        }

        private decimal amountField;

        /// <summary>
        /// Amount
        /// </summary>
        public decimal Amount
        {
            get { return amountField; }
            set { amountField = value; }
        }

    }
}