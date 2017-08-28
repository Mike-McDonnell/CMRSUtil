using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMRSUtil
{
    public class CMRSInfo: ICMRSInfo
    {
        public string CMRSSource { get; set; }
        public string AssetName { get; set; }
        public string AssetIP { get; set; }
        public string AssetMAC { get; set; }
        public string AssetFQDN { get; set; }
        public IEnumerable<StigTarget> STIGTargets { get; set; }
    }
}
