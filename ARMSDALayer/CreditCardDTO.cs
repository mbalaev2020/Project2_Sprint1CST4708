using System;

namespace ARMSDALayer
{
    public class CreditCardDTO
    {
        public string CreditCardNumber { get; set; }
        public string CreditCardOwnerName { get; set; }

        public string CreditCardProcessingMerchantServiceCompanyCode { get; set; }
        public string CreditCardProcessingMerchantServiceCompanyName { get; set; }

        public string CreditCardNetworkCompanyCode { get; set; }
        public string CreditCardNetworkCompanyName { get; set; }

        public string CreditCardIssuingBankCode { get; set; }
        public string CreditCardIssuingBankName { get; set; }

        public string CreditCardCorporateMerchantBankCode { get; set; }
        public string CreditCardCorporateMerchantBankName { get; set; }

        public DateTime ExpDate { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }

        public decimal CreditCardLimit { get; set; }
        public decimal CreditCardAvailableCredit { get; set; }
        public bool CreditCardActivationStatus { get; set; }
    }
}
