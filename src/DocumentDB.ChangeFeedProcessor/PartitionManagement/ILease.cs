﻿using System;

namespace DocumentDB.ChangeFeedProcessor.PartitionManagement
{
    public interface ILease
    {
        string PartitionId { get; }
        string Owner { get; set; }
        DateTime Timestamp { get; set; }
        string ContinuationToken { get; set; }
        string Id { get; }
        string ConcurrencyToken { get; }
    }
}