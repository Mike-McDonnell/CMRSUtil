using System;
using System.Collections.Generic;
using System.Linq;

namespace CMRSUtil
{
    public class CMRSConverter : ICMRSConverter
    {
        private Transformer CMRSTransformer = new Transformer();

        public CMRSConverter(string Source)
        {
            CMRSTransformer.LoadCMRS(Source);
        }

        public IChecklistInfo CheckListInfo { get { return CMRSTransformer.ChecklistInformation; } }

        public ICMRSInfo CMRSInfomation { get { return CMRSTransformer.CMRSInfomation; } }

        public void Transform()
        {
            CMRSTransformer.Transform();
        }

        public string Export()
        {
            try 
            {

                if(CMRSTransformer.ChecklistInformation.Transfromed)
                {
                    return CMRSTransformer.ChecklistInformation.CKLSource;
                }

                throw new Exception("Faild to Convert CMRS to Checklist");
            }
            catch(Exception ex)
            {
                throw new Exception("Unable to convert CMRS to Checklist", ex);
            }
        }

        public void LoadCKL(string CKLXMLContent)
        {
            CMRSTransformer.ImportCKL(CKLXMLContent);
        }

        public void LoadBenchmark(string XCCDFXMLContent)
        {
            CMRSTransformer.ImportBenchmark(XCCDFXMLContent);
        }
    }
}