using Jemus.Service.Contract;
using System;

namespace Jemus.Service.Implementation
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}