using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAutomation.Models.Configuration
{
    public static class ResponseCacheProfile
    {
        private const int MINUTE = 60;

        public const string ShortTimeCache = nameof(ShortTimeCache);
        public const string LongTimeCache = nameof(LongTimeCache);

        public const int ShortTimeCacheDuration = 5 * MINUTE;
        public const int LongTimeCacheDuration = 30 * MINUTE;
    }
}
