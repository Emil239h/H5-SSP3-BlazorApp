using Microsoft.AspNetCore.DataProtection;

namespace H5_SSP3_BlazorApp.Codes
{
    class EncryptionService
    {
        public IDataProtector _dataprotector { get; set; }
        public EncryptionService(IDataProtectionProvider dataprotector)
        {
            _dataprotector = dataprotector.CreateProtector("H5-SSP3-BlazorApp");

        }

        public byte[] Protect(byte[] val) => _dataprotector.Protect(val);
        public byte[] Unprotect(byte[] val) => _dataprotector.Unprotect(val);
    }


}