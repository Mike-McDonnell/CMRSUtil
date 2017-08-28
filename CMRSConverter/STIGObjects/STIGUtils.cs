using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMRSUtil
{
    public partial class STIGObjects
    {
        public class Utils
        {
            internal static string ConvertCMRSFindingLabelToCKL(string fINDING_STATUS)
            {
                switch(fINDING_STATUS)
                {
                    case "NR":
                        return VulnStatus.Not_Reviewed.ToString();
                    case "NF":
                        return VulnStatus.NotAFinding.ToString();
                    case "O":
                        return VulnStatus.Open.ToString();
                    case "NA":
                        return VulnStatus.Not_Applicable.ToString();
                    default :
                        return VulnStatus.Not_Reviewed.ToString();
                }
            }

            internal static string ConvertCMRSSeverityToCKL(byte SEV_OVERRIDE_CODE)
            {
                switch (SEV_OVERRIDE_CODE)
                {
                    case 1:
                        return VulnSeverity.high.ToString();
                    case 2:
                        return VulnSeverity.medium.ToString();
                    case 3:
                        return VulnSeverity.low.ToString();
                    default:
                        return string.Empty;
                }
            }
        }

        public enum VulnStatus
        {
            Not_Reviewed,
            Open,
            NotAFinding,
            Not_Applicable
        }

        public enum VulnSeverity
        {
            high,
            medium,
            low
        }
    }
}
