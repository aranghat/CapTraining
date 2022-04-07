using MVCCommon;
using System;

namespace JioSmsSender
{
    public class JioSmsProvider : ISmsSender
    {
        public string SentSMS(long mobileNumber, string sms)
        {
            //Sent SMS 
            return $"JIO : SMS {sms} sent to {mobileNumber}";
        }
    }
}
