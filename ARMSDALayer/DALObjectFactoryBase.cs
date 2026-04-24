using System;

namespace ARMSDALayer
{
    public abstract class DALObjectFactoryBase
    {
        public const int SQLSERVER = 1;
        public const int ORACLE = 2;
        public const int MYSQL = 3;

        public static DALObjectFactoryBase GetDataSourceDAOFactory(int targetDataSourceFactory)
        {
            switch (targetDataSourceFactory)
            {
                case SQLSERVER:
                    return new SQLServerDAOFactory();
                case ORACLE:
                    throw new NotImplementedException();
                case MYSQL:
                    throw new NotImplementedException();
                default:
                    throw new NotImplementedException();
            }
        }

        public abstract ICreditCardDAO GetCreditCardDAO();
    }
}
