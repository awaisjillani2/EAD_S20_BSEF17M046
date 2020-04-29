namespace TokenGeneration
{
    internal class SigningCredentials
    {
        private SymmetricSecurityKey securityKey;
        private object hmacSha256;

        public SigningCredentials(SymmetricSecurityKey securityKey, object hmacSha256)
        {
            this.securityKey = securityKey;
            this.hmacSha256 = hmacSha256;
        }
    }
}