namespace Allors
{
    using System;
    using System.Linq;
    using System.Numerics;
    using System.Text;

    public static class GuidExtensions
    {
        /// <summary>
        /// Converts to a url friendly base58 encoded string
        /// </summary>
        /// <param name="this"></param>
        /// <returns>tag</returns>
        public static string ToBase58(this Guid @this)
        {
            const string alphabet = "123456789ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz";
            var bytes = @this.ToByteArray();

            // Convert to BigInteger (append 0 to ensure unsigned)
            var value = new BigInteger(bytes.Concat(new byte[] { 0 }).ToArray());

            // Build result by repeatedly dividing by 58
            var result = new StringBuilder();
            while (value > 0)
            {
                var remainder = (int)(value % 58);
                value /= 58;
                result.Insert(0, alphabet[remainder]);
            }

            // Handle leading zero bytes (encode as '1')
            foreach (var b in bytes)
            {
                if (b != 0)
                {
                    break;
                }

                result.Insert(0, alphabet[0]);
            }

            return result.ToString();
        }
    }
}
