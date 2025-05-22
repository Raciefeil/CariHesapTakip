using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace CariHesapTakip.Data
{
    // EF6 burayı otomatik bulur ve kullanır
    public class MyDbConfiguration : DbConfiguration
    {
        public MyDbConfiguration()
        {
            // SQL Server sağlayıcısını set et
            SetProviderServices(
                SqlProviderServices.ProviderInvariantName,
                SqlProviderServices.Instance);

            // Aynı zamanda ADO.NET factory ayarı (gelişmiş senaryolar için)
            SetProviderFactory(
                SqlProviderServices.ProviderInvariantName,
                System.Data.SqlClient.SqlClientFactory.Instance);
        }
    }
}
