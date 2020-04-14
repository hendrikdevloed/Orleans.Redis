﻿namespace Orleans.Persistence
{
    /// <summary>
    /// Redis grain storage options.
    /// </summary>
    public class RedisStorageOptions
    {
        /// <summary>
        /// The connection string.
        /// </summary>
        public string DataConnectionString { get; set; } = "localhost:6379";

        /// <summary>
        /// Whether or not to use JSON for serialization.
        /// </summary>
        public bool UseJson { get; set; }

        /// <summary>
        /// Whether or not to delete state during a clear operation.
        /// </summary>
        public bool DeleteOnClear { get; set; }

        /// <summary>
        /// The database number.
        /// </summary>
        public int? DatabaseNumber { get; set; }

        /// <summary>
        /// Stage of silo lifecycle where storage should be initialized.  Storage must be initialzed prior to use.
        /// </summary>
        public int InitStage { get; set; } = ServiceLifecycleStage.ApplicationServices;
    }
}