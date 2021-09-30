using System;

namespace CampaignMonitorTest
{   
    public static class StringExtensionFactory
    {
        public static bool IsNullOrEmpty(this String str)
        {
            return str == null || str == string.Empty;
        }
    }
}
