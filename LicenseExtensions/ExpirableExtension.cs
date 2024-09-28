using de.mydevtime.License.Model.Extensions;
using de.mydevtime.LicenseServer.Model.Enums;

namespace de.mydevtime.LicenseServer.Model.LicenseExtensions;

public class ExpirableExtension : ALicenseExtension
{
    public DateTime ExpirationDate { get; }

    public ExpirableExtension(DateTime expirationDate) : base(ELicenseExtensions.ExpirableExtension.ToString())
    {
        ExpirationDate = expirationDate;
    }

    public ExpirableExtension(HashSet<ALicenseExtension> extensions, DateTime expirationDate) : base(ELicenseExtensions.ExpirableExtension.ToString(), extensions)
    {
        ExpirationDate = expirationDate;
    }
}