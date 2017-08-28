using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMRSUtil;
using System.ComponentModel;

namespace CMRSToCKL
{
    class CKLProperties: CMRSUtil.IChecklistInfo
    {
        public CKLProperties(IChecklistInfo checkListInfo)
        {
            this.CKLSource = checkListInfo.CKLSource;
            this.Description = checkListInfo.Description;
            this.Filename = checkListInfo.Filename;
            this.Releaseinfo = checkListInfo.Releaseinfo;
            this.Source = checkListInfo.Source;
            this.STIGId = checkListInfo.STIGId;
            this.Title = checkListInfo.Title;
            this.Transfromed = checkListInfo.Transfromed;
            this.Version = checkListInfo.Version;
            this.VulnCount = checkListInfo.VulnCount;
        }

        [Category("Checklist"), DisplayName("CKL Source")]
        public string CKLSource { get; set; }

        [Category("Checklist"), DisplayName("STIG Id")]
        public string STIGId { get; set; }

        [Category("Checklist"), DisplayName("Version")]
        public string Version { get; set; }

        [Category("Checklist"), DisplayName("Description")]
        public string Description { get; set; }

        [Category("Checklist"), DisplayName("FileName")]
        public string Filename { get; set; }

        [Category("Checklist"), DisplayName("Relaseinfo")]
        public string Releaseinfo { get; set; }

        [Category("Checklist"), DisplayName("Title")]
        public string Title { get; set; }

        [Category("Checklist"), DisplayName("STIG Source")]
        public string Source { get; set; }

        [Category("Checklist"), DisplayName("Vulnerability Count")]
        public int VulnCount { get; set; }

        [Category("Status"), DisplayName("Converted")]
        public bool Transfromed { get; set; }

    }
}
