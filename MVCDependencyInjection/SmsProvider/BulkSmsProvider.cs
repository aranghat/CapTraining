using MVCCommon;

namespace MVCDependencyInjection.SmsProvider
{
    public class BulkSmsProvider : ISmsSender
    {
        public string SentSMS(long mobileNumber, string sms)
        {
           new AirtelSmsLibrary.AirtelSmsSender().SentSMS(mobileNumber, sms);
           new JioSmsSender.JioSmsProvider().SentSMS(mobileNumber, sms);

           return $"BULK  : SMS {sms} sent to {mobileNumber}";
        }
    }
}
