using oeClean.Application.Common.Interfaces;
using System;

namespace oeClean.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
