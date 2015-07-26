﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet
{
    /// <summary>
    /// Contains some extra conversions for internal use.
    /// </summary>
    internal static class Conversions
    {
        private static DateTime epochReferenceDate = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        /// <summary>
        /// Converts a DateTime object into epoch milliseconds (in UTC).
        /// </summary>
        /// <param name="time">The DateTime object to convert.</param>
        /// <returns>Epoch milliseconds.</returns>
        internal static long DateTimeToEpochMilliseconds(DateTime time)
        {
            if (time.Kind == DateTimeKind.Local)
                time = time.ToUniversalTime();
            return Convert.ToInt64((time - epochReferenceDate).TotalMilliseconds);
        }

        /// <summary>
        /// Converts epoch milliseconds into a DateTime (in UTC).
        /// </summary>
        /// <param name="epochMilliseconds">The number of milliseconds since the epoch reference date.</param>
        /// <returns>A DateTime (in UTC).</returns>
        internal static DateTime EpochMillisecondsToDateTime(long epochMilliseconds)
        {
            return epochReferenceDate.AddMilliseconds(epochMilliseconds);
        }
    }
}
