using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMRSUtil
{
    public class ChecklistInfo: IChecklistInfo
    {
        public string CKLSource { get; set; }
        public string STIGId { get; set; }
        public string Version { get; set; }
        public string Description { get; set; }
        public string Filename { get; set; }
        public string Releaseinfo { get; set; }
        public string Title { get; set; }
        public string Source { get; set; }
        public int VulnCount { get; set; }
        public bool Transfromed { get; set; }
    }
}
