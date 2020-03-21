using System;
using System.Collections.Generic;
using System.Text;

namespace WalletDeveloper.Library.Constants
{
    public class HtttpHelper
    {
        public static List<KeyValuePair<string, string>> GeneratedAuthorizationHeader(string bearer)
        {
            return new List<KeyValuePair<string, string>>{
               new KeyValuePair<string, string>("Authorization", $"Bearer {bearer}"),
            };
        }

        public static Dictionary<string, string> GeneratedAuthorizationHeader(string username, string password)
        {
            var base64Header = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{username}:{password}"));
            return new Dictionary<string, string>
                    {
                        {"Authorization", $"Basic {base64Header}"}
                    };
        }
    }
}
