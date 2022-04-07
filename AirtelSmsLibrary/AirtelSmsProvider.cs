using MVCCommon;
using System;

namespace AirtelSmsLibrary
{
    public class AirtelSmsSender : ISmsSender
    {
        public string SentSMS(long mobileNumber, string sms)
        {
            //Sent SMS 
            return $"AIRTEL : SMS {sms} sent to {mobileNumber}";
        }
    }
}
