namespace SomerenLogic
{
    // This code was acquired from here https://dotnetcodr.com/2016/10/17/how-to-hash-passwords-with-a-salt-in-net/
    // Author: "Andras Nemes"
    
    public class HashWithSaltResult
    {
        public string Salt { get; }
        public byte[] DigestHash { get; set; }
        public string Digest { get; set; }

        public HashWithSaltResult(string salt, string digest, byte[] digestHash)
        {
            Salt = salt;
            Digest = digest;
            DigestHash = digestHash;
        }
    }
}
