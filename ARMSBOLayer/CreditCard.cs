using System;
using System.IO;
using ARMSDALayer;

namespace ARMSBOLayer
{
    public class CreditCard
    {
        public string CreditCardNumber { get; private set; }
        public string CreditCardOwnerName { get; private set; }

        public string CreditCardProcessingMerchantServiceCompanyCode { get; private set; }
        public string CreditCardProcessingMerchantServiceCompanyName { get; private set; }

        public string CreditCardNetworkCompanyCode { get; private set; }
        public string CreditCardNetworkCompanyName { get; private set; }

        public string CreditCardIssuingBankCode { get; private set; }
        public string CreditCardIssuingBankName { get; private set; }

        public string CreditCardCorporateMerchantBankCode { get; private set; }
        public string CreditCardCorporateMerchantBankName { get; private set; }

        public DateTime ExpDate { get; private set; }
        public string AddressLine1 { get; private set; }
        public string AddressLine2 { get; private set; }
        public string City { get; private set; }
        public string StateCode { get; private set; }
        public string ZipCode { get; private set; }
        public string Country { get; private set; }

        public decimal CreditCardLimit { get; private set; }
        public decimal CreditCardAvailableCredit { get; private set; }
        public bool CreditCardActivationStatus { get; private set; }

        public bool Load(string key)
        {
            return DALayer_Load(key);
        }

        public void Print(string outputFileName = "Network_Printer.txt")
        {
            string text =
                "Credit Card Record" + Environment.NewLine +
                "------------------" + Environment.NewLine +
                "Credit Card Number: " + CreditCardNumber + Environment.NewLine +
                "Owner Name: " + CreditCardOwnerName + Environment.NewLine +
                "Processing Merchant Service Company: " + CreditCardProcessingMerchantServiceCompanyName + Environment.NewLine +
                "Network Company: " + CreditCardNetworkCompanyName + Environment.NewLine +
                "Issuing Bank: " + CreditCardIssuingBankName + Environment.NewLine +
                "Corporate Merchant Bank: " + CreditCardCorporateMerchantBankName + Environment.NewLine +
                "Expiration Date: " + ExpDate.ToShortDateString() + Environment.NewLine +
                "Address Line 1: " + AddressLine1 + Environment.NewLine +
                "Address Line 2: " + AddressLine2 + Environment.NewLine +
                "City: " + City + Environment.NewLine +
                "State: " + StateCode + Environment.NewLine +
                "Zip Code: " + ZipCode + Environment.NewLine +
                "Country: " + Country + Environment.NewLine +
                "Credit Card Limit: " + CreditCardLimit.ToString("0.00") + Environment.NewLine +
                "Available Credit: " + CreditCardAvailableCredit.ToString("0.00") + Environment.NewLine +
                "Activation Status: " + (CreditCardActivationStatus ? "Active" : "Inactive") + Environment.NewLine;

            File.WriteAllText(outputFileName, text);
        }

        protected bool DALayer_Load(string key)
        {
            DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

            ICreditCardDAO objCreditCardDAO = objDAOFactory.GetCreditCardDAO();

            CreditCardDTO objDTO = objCreditCardDAO.GetRecordByID(key);

            if (objDTO == null) return false;

            this.CreditCardNumber = objDTO.CreditCardNumber;
            this.CreditCardOwnerName = objDTO.CreditCardOwnerName;

            this.CreditCardProcessingMerchantServiceCompanyCode = objDTO.CreditCardProcessingMerchantServiceCompanyCode;
            this.CreditCardProcessingMerchantServiceCompanyName = objDTO.CreditCardProcessingMerchantServiceCompanyName;

            this.CreditCardNetworkCompanyCode = objDTO.CreditCardNetworkCompanyCode;
            this.CreditCardNetworkCompanyName = objDTO.CreditCardNetworkCompanyName;

            this.CreditCardIssuingBankCode = objDTO.CreditCardIssuingBankCode;
            this.CreditCardIssuingBankName = objDTO.CreditCardIssuingBankName;

            this.CreditCardCorporateMerchantBankCode = objDTO.CreditCardCorporateMerchantBankCode;
            this.CreditCardCorporateMerchantBankName = objDTO.CreditCardCorporateMerchantBankName;

            this.ExpDate = objDTO.ExpDate;
            this.AddressLine1 = objDTO.AddressLine1;
            this.AddressLine2 = objDTO.AddressLine2;
            this.City = objDTO.City;
            this.StateCode = objDTO.StateCode;
            this.ZipCode = objDTO.ZipCode;
            this.Country = objDTO.Country;

            this.CreditCardLimit = objDTO.CreditCardLimit;
            this.CreditCardAvailableCredit = objDTO.CreditCardAvailableCredit;
            this.CreditCardActivationStatus = objDTO.CreditCardActivationStatus;

            return true;
        }
    }
}
