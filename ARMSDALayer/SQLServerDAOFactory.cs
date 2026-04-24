namespace ARMSDALayer
{
    public class SQLServerDAOFactory : DALObjectFactoryBase
    {
        public static string ConnectionString()
        {
            return DbConfig.ConnectionString;
        }

        public override ICreditCardDAO GetCreditCardDAO()
        {
            return new CreditCardDAO();
        }
    }
}
