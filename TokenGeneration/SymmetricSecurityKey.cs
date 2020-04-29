namespace TokenGeneration
{
    internal class SymmetricSecurityKey
    {
        private byte[] v;

        public SymmetricSecurityKey(byte[] v)
        {
            this.v = v;
        }
    }
}