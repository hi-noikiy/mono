//
// System.Web.ProcessShutdownReason.cs
//
// Author:
//   Bob Smith <bob@thestuff.net>
//
// (C) Bob Smith
//

namespace System.Web
{
        public enum ProcessShutdownReason
        {
                IdleTimeout,
                MemoryLimitExceeded,
                None,
                PingFailed,
                RequestQueueLimit,
                RequestsLimit,
                Timeout,
                Unexpected
        }
}