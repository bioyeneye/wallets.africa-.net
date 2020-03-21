using System;
using System.Collections.Generic;
using System.Text;

namespace WalletDeveloper.Library.Models.Responses
{
    public class AccountBVNResolveReponse : APIResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string BVN { get; set; }
        public string DateOfBirth { get; set; }
        public object Picture { get; set; }
        public bool BVNResolvedSuccessful
        {
            get
            {
                return string.IsNullOrWhiteSpace(ResponseCode) ? false : (ResponseCode == "200" ? true : false);
            }
        }
    }
}
