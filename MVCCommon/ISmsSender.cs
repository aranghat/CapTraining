using System;

namespace MVCCommon
{
    public interface ISmsSender
    {
        string SentSMS(long mobileNumber
            , string sms);
    }
}
