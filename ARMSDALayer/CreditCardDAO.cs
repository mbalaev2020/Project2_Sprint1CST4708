using System;
using System.Data;
using System.Data.SqlClient;

namespace ARMSDALayer
{
    public class CreditCardDAO : ICreditCardDAO
    {
        
        private static string GetNullableString(IDataReader dr, int i)
        {
            return dr.IsDBNull(i) ? string.Empty : Convert.ToString(dr.GetValue(i)) ?? string.Empty;
        }

        private static bool GetBoolFromAny(IDataReader dr, int i)
        {
            if (dr.IsDBNull(i)) return false;
            object v = dr.GetValue(i);
            if (v is bool b) return b;
            if (v is byte by) return by != 0;
            if (v is short s) return s != 0;
            if (v is int n) return n != 0;
            if (v is long l) return l != 0;
            return Convert.ToBoolean(v);
        }

public CreditCardDTO GetRecordByID(string key)
        {
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());

            try
            {
                objConn.Open();

                string strSQL =
                    "SELECT CREDITCARD.CreditCardNumber, " +
                    "CREDITCARD.CreditCardOwnerName, " +
                    "CREDITCARD.CreditCardProcessingMerchantServiceCompanyCode, " +
                    "CREDITCARDPROCESSINGMERCHANTSERVICECOMPANY.CreditCardProcessingMerchantServiceCompanyName, " +
                    "CREDITCARD.CreditCardNetworkCompanyCode, CREDITCARDNETWORKCOMPANY.CreditCardNetworkCompanyName, " +
                    "CREDITCARD.CreditCardIssuingBankCode, CREDITCARDISSUINGBANK.CreditCardIssuingBankName, " +
                    "CREDITCARD.CreditCardCorporateMerchantBankCode, " +
                    "CREDITCARDCORPORATEMERCHANTBANK.CreditCardCorporateMerchantBankName, " +
                    "CREDITCARD.ExpDate, CREDITCARD.AddressLine1, CREDITCARD.AddressLine2, CREDITCARD.City, " +
                    "CREDITCARD.StateCode, CREDITCARD.Zipcode AS ZipCode, CREDITCARD.Country, " +
                    "CREDITCARD.CreditCardLimit, CREDITCARD.CreditCardAvailableCredit, CREDITCARD.ActivationStatus " +
                    "FROM CREDITCARD, CREDITCARDPROCESSINGMERCHANTSERVICECOMPANY, " +
                    "CREDITCARDNETWORKCOMPANY, CREDITCARDISSUINGBANK, CREDITCARDCORPORATEMERCHANTBANK " +
                    "WHERE CREDITCARD.CreditCardProcessingMerchantServiceCompanyCode = " +
                    "CREDITCARDPROCESSINGMERCHANTSERVICECOMPANY.CreditCardProcessingMerchantServiceCompanyCode AND " +
                    "CREDITCARD.CreditCardNetworkCompanyCode = CREDITCARDNETWORKCOMPANY.CreditCardNetworkCompanyCode AND " +
                    "CREDITCARD.CreditCardIssuingBankCode = CREDITCARDISSUINGBANK.CreditCardIssuingBankCode AND " +
                    "CREDITCARD.CreditCardCorporateMerchantBankCode = " +
                    "CREDITCARDCORPORATEMERCHANTBANK.CreditCardCorporateMerchantBankCode AND " +
                    "CREDITCARD.CreditCardNumber = @CreditCardNumber;";

                SqlCommand objCmd = new SqlCommand(strSQL, objConn);
                objCmd.CommandType = CommandType.Text;
                objCmd.Parameters.Add("@CreditCardNumber", SqlDbType.VarChar).Value = key;

                SqlDataReader objDR = objCmd.ExecuteReader();

                if (!objDR.HasRows)
                {
                    return null;
                }

                CreditCardDTO objDTO = new CreditCardDTO();
                objDR.Read();

                objDTO.CreditCardNumber = GetNullableString(objDR, 0);
                objDTO.CreditCardOwnerName = GetNullableString(objDR, 1);
                objDTO.CreditCardProcessingMerchantServiceCompanyCode = GetNullableString(objDR, 2);
                objDTO.CreditCardProcessingMerchantServiceCompanyName = GetNullableString(objDR, 3);
                objDTO.CreditCardNetworkCompanyCode = GetNullableString(objDR, 4);
                objDTO.CreditCardNetworkCompanyName = GetNullableString(objDR, 5);
                objDTO.CreditCardIssuingBankCode = GetNullableString(objDR, 6);
                objDTO.CreditCardIssuingBankName = GetNullableString(objDR, 7);
                objDTO.CreditCardCorporateMerchantBankCode = GetNullableString(objDR, 8);
                objDTO.CreditCardCorporateMerchantBankName = GetNullableString(objDR, 9);
                objDTO.ExpDate = objDR.GetDateTime(10);
                objDTO.AddressLine1 = GetNullableString(objDR, 11);
                objDTO.AddressLine2 = GetNullableString(objDR, 12);
                objDTO.City = GetNullableString(objDR, 13);
                objDTO.StateCode = GetNullableString(objDR, 14);
                objDTO.ZipCode = GetNullableString(objDR, 15);
                objDTO.Country = GetNullableString(objDR, 16);
                objDTO.CreditCardLimit = objDR.GetDecimal(17);
                objDTO.CreditCardAvailableCredit = objDR.GetDecimal(18);
                objDTO.CreditCardActivationStatus = GetBoolFromAny(objDR, 19);

                return objDTO;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (objConn.State != ConnectionState.Closed)
                    objConn.Close();
            }
        }
    }
}