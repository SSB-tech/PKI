using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace PKI__Public_Key_Infrastructure_.BusinessLogic
{
    public class CertificateValidation
    {
        public bool ValidateCertificate(X509Certificate2 clientCertificate)
        {
            string[] allowedThumbprints = {
                "633F864A722EBC46CFC8D8B3B996F0B63463725D"
            };
            if (allowedThumbprints.Contains(clientCertificate.Thumbprint))
            {
                return true;
            }
            return false;
        }
    }
}