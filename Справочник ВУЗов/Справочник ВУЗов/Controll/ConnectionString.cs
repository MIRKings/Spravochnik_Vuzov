using System.Configuration;

namespace Справочник_ВУЗов.Controll
{
    class ConnectionString
    {
        public static string ConnStr
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["Справочник_ВУЗов.Properties.Settings.Database2ConnectionString"].ConnectionString;
            }
        }
    }
}
