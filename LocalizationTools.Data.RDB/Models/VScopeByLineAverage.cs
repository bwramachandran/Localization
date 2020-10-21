using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class VScopeByLineAverage
    {
        public DateTime DateUtc { get; set; }
        public string DataDirectory { get; set; }
        public string Build { get; set; }
        public string Group { get; set; }
        public double? AverageWordsPerLine { get; set; }
        public int? HeroWords { get; set; }
        public int? HeroLines { get; set; }
        public int? TotalLines { get; set; }
        public double? HeroLinesOfAssetLinesPercent { get; set; }
    }
}
