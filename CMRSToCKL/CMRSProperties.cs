using System.ComponentModel;
using System.Linq;
using CMRSUtil;

namespace CMRSToCKL
{
    internal class CMRSProperties: CMRSUtil.ICMRSInfo
    {
        public CMRSProperties(ICMRSInfo cMRSInfomation)
        {
            this.CMRSSource = cMRSInfomation.CMRSSource;
            this.AssetFQDN = cMRSInfomation.AssetFQDN;
            this.AssetIP = cMRSInfomation.AssetIP;
            this.AssetMAC = cMRSInfomation.AssetMAC;
            this.AssetName = cMRSInfomation.AssetName;
            this.STIGTargets = cMRSInfomation.STIGTargets;
        }

        [Category("System Info"), DisplayName("CMRS Source")]
        public string CMRSSource {get; set; }

        [Category("System Info"), DisplayName("Host Name")]
        public string AssetName { get; set; }

        [Category("System Info"), DisplayName("IP")]
        public string AssetIP { get; set; }

        [Category("System Info"), DisplayName("MAC")]
        public string AssetMAC { get; set; }

        [Category("System Info"), DisplayName("FQSN")]
        public string AssetFQDN { get; set; }

        [Browsable(false)]
        public System.Collections.Generic.IEnumerable<CMRSUtil.StigTarget> STIGTargets { get; set; }

        [Category("STIGS Targets"), DisplayName("STIGS")]
        public STIGInfo[] STIGTargets_Mod
        {
            get
            {
                return STIGTargets.Select(x => new STIGInfo() { Name = x.Id, Count = x.FindingCount } ).ToArray();
            }
        }

        public class STIGInfo : CustomTypeDescriptor
        {
            [DisplayName("Name")]
            public string Name { get; set; }

            [DisplayName("Finding Count")]
            public int Count { get; set; }

            public override string ToString()
            {
                return Name;
            }

        }
    }
}