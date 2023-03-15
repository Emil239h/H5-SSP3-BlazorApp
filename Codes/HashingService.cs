namespace H5_SSP3_BlazorApp.Codes
{
    public class HashingService
    {
        public string BCryptString(string inputStr)
        {
            var salt = BCrypt.Net.BCrypt.GenerateSalt(5);
            return BCrypt.Net.BCrypt.HashPassword(inputStr, salt);
        }

        public bool BCryptCompare(string inputStr , string hash)
        {
            return BCrypt.Net.BCrypt.Verify(inputStr, hash);
        }
    }
}
