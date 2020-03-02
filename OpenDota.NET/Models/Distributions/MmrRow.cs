﻿namespace OpenDotaDotNet.Models.Distributions
{
    using Newtonsoft.Json;

    public class MmrRow
    {
        [JsonProperty("bin")]
        public int Bin { get; set; }

        [JsonProperty("bin_name")]
        public int BinName { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("cumulative_sum")]
        public long CumulativeSum { get; set; }
    }
}
