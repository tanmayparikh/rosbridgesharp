using System;
using System.Linq;

namespace Rosbridgenet
{
    public static class Utils
    {
        private const string VALID_CHARS = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        public static string GenerateRandomString(int length = 8)
        {
            var rand = new Random();

            return new string(
                Enumerable.Repeat(VALID_CHARS, length)
                .Select(s => s[rand.Next(s.Length)])
                .ToArray()
            );
        }

    }
}
