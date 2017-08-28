using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMRSUtil
{
    public class Transformer
    {
        public CMRSInfo CMRSInfomation { get; private set; }
        public ChecklistInfo ChecklistInformation { get; private set; }

        private STIGObjects.CHECKLIST CheckList { get; set; }
        private STIGObjects.IMPORT_FILE CMRS { get; set; }

        internal void LoadCMRS(string iMPORT_FILE_Source)
        {
            this.CMRS = this.ParseCMRS(iMPORT_FILE_Source);
            CMRSInfomation = new CMRSInfo();

            CMRSInfomation.CMRSSource = iMPORT_FILE_Source;
            CMRSInfomation.AssetName = this.CMRS.ASSET.ASSET_ID[0].Value;
            CMRSInfomation.AssetIP = this.CMRS.ASSET.ASSET_ID[1].Value;
            CMRSInfomation.AssetMAC = this.CMRS.ASSET.ASSET_ID[2].Value;
            CMRSInfomation.AssetFQDN = this.CMRS.ASSET.ASSET_ID[3].Value;
            CMRSInfomation.STIGTargets = this.CMRS.ASSET.TARGET.Select(x => new StigTarget() { Id = x.TARGET_ID, Key = x.TARGET_KEY, FindingCount = x.FINDING.Length });

        }

        internal void ImportCKL(string CKL_FILE_Source)
        {
            this.CheckList = ParseChecklist(CKL_FILE_Source);

            ChecklistInformation = new ChecklistInfo();
            ChecklistInformation.Version = this.CheckList.STIGS.iSTIG.STIG_INFO[0].SID_DATA;
            ChecklistInformation.STIGId = this.CheckList.STIGS.iSTIG.STIG_INFO[3].SID_DATA;
            ChecklistInformation.Description = this.CheckList.STIGS.iSTIG.STIG_INFO[4].SID_DATA;
            ChecklistInformation.Filename = this.CheckList.STIGS.iSTIG.STIG_INFO[5].SID_DATA;
            ChecklistInformation.Releaseinfo = this.CheckList.STIGS.iSTIG.STIG_INFO[6].SID_DATA;
            ChecklistInformation.Title = this.CheckList.STIGS.iSTIG.STIG_INFO[7].SID_DATA;
            ChecklistInformation.Source = this.CheckList.STIGS.iSTIG.STIG_INFO[10].SID_DATA;
            ChecklistInformation.VulnCount = this.CheckList.STIGS.iSTIG.VULN.Length;
            ChecklistInformation.CKLSource = CKL_FILE_Source;

            if(!CMRSInfomation.STIGTargets.Any(x=>x.Id.Contains(ChecklistInformation.STIGId)))
            {
                throw new Exception(string.Format("CMRS does not contain a Target STIG of type {0}", this.ChecklistInformation.STIGId));
            }
        }

        internal void ImportBenchmark(string XCCDF_FILE_Source)
        {

            try
            {

                var classification = XCCDF_FILE_Source.Contains("STIG_unclass.xsl") ? "UNCLASSIFIED" : "";
                var shortclass = XCCDF_FILE_Source.Contains("STIG_unclass.xsl") ? "Unclass" : "";

                var xccdfsource = this.ParseBenchmark(XCCDF_FILE_Source);

                this.CheckList = new STIGObjects.CHECKLIST();
                this.CheckList.ASSET = new STIGObjects.CHECKLISTASSET();
                this.CheckList.ASSET.ASSET_TYPE = "Computing";
                this.CheckList.ASSET.HOST_FQDN = new object();
                this.CheckList.ASSET.HOST_GUID = new object();
                this.CheckList.ASSET.HOST_IP = new object();
                this.CheckList.ASSET.HOST_MAC = new object();
                this.CheckList.ASSET.HOST_NAME = new object();
                this.CheckList.ASSET.TARGET_KEY = new object();
                this.CheckList.ASSET.TECH_AREA = new object();

                this.CheckList.STIGS = new STIGObjects.CHECKLISTSTIGS();
                this.CheckList.STIGS.iSTIG = new STIGObjects.CHECKLISTSTIGSISTIG();
                this.CheckList.STIGS.iSTIG.STIG_INFO = new STIGObjects.CHECKLISTSTIGSISTIGSI_DATA[11];

                this.CheckList.STIGS.iSTIG.STIG_INFO[0] = new STIGObjects.CHECKLISTSTIGSISTIGSI_DATA() { SID_NAME = "version", SID_DATA = xccdfsource.version.ToString() };
                this.CheckList.STIGS.iSTIG.STIG_INFO[1] = new STIGObjects.CHECKLISTSTIGSISTIGSI_DATA() { SID_NAME = "classification", SID_DATA = "classification" };
                this.CheckList.STIGS.iSTIG.STIG_INFO[2] = new STIGObjects.CHECKLISTSTIGSISTIGSI_DATA() { SID_NAME = "customname", SID_DATA = "" };
                this.CheckList.STIGS.iSTIG.STIG_INFO[3] = new STIGObjects.CHECKLISTSTIGSISTIGSI_DATA() { SID_NAME = "stigid", SID_DATA = xccdfsource.id };
                this.CheckList.STIGS.iSTIG.STIG_INFO[4] = new STIGObjects.CHECKLISTSTIGSISTIGSI_DATA() { SID_NAME = "description", SID_DATA = xccdfsource.description };
                this.CheckList.STIGS.iSTIG.STIG_INFO[5] = new STIGObjects.CHECKLISTSTIGSISTIGSI_DATA() { SID_NAME = "filename", SID_DATA = "" };
                this.CheckList.STIGS.iSTIG.STIG_INFO[6] = new STIGObjects.CHECKLISTSTIGSISTIGSI_DATA() { SID_NAME = "releaseinfo", SID_DATA = xccdfsource.plaintext.Value };
                this.CheckList.STIGS.iSTIG.STIG_INFO[7] = new STIGObjects.CHECKLISTSTIGSISTIGSI_DATA() { SID_NAME = "title", SID_DATA = xccdfsource.title };
                this.CheckList.STIGS.iSTIG.STIG_INFO[8] = new STIGObjects.CHECKLISTSTIGSISTIGSI_DATA() { SID_NAME = "uuid", SID_DATA = Guid.NewGuid().ToString() };
                this.CheckList.STIGS.iSTIG.STIG_INFO[9] = new STIGObjects.CHECKLISTSTIGSISTIGSI_DATA() { SID_NAME = "notice", SID_DATA = xccdfsource.notice.id };
                this.CheckList.STIGS.iSTIG.STIG_INFO[10] = new STIGObjects.CHECKLISTSTIGSISTIGSI_DATA() { SID_NAME = "source", SID_DATA = xccdfsource.reference.source };

                this.CheckList.STIGS.iSTIG.VULN = new STIGObjects.CHECKLISTSTIGSISTIGVULN[xccdfsource.Group.Length];

                for (var x = 0; x < xccdfsource.Group.Length; x++)
                {
                    BenchmarkGroupRuleEx.Description ruleDescriptionEx = xccdfsource.Group[x].Rule.ExpandGroupRuleDescription();

                    var stig_data = new STIGObjects.CHECKLISTSTIGSISTIGVULNSTIG_DATA[24];
                    stig_data[0] = new STIGObjects.CHECKLISTSTIGSISTIGVULNSTIG_DATA() { VULN_ATTRIBUTE = "Vuln_Num", ATTRIBUTE_DATA = xccdfsource.Group[x].id };
                    stig_data[1] = new STIGObjects.CHECKLISTSTIGSISTIGVULNSTIG_DATA() { VULN_ATTRIBUTE = "Severity", ATTRIBUTE_DATA = xccdfsource.Group[x].Rule.severity };
                    stig_data[2] = new STIGObjects.CHECKLISTSTIGSISTIGVULNSTIG_DATA() { VULN_ATTRIBUTE = "Group_Title", ATTRIBUTE_DATA = xccdfsource.Group[x].title };
                    stig_data[3] = new STIGObjects.CHECKLISTSTIGSISTIGVULNSTIG_DATA() { VULN_ATTRIBUTE = "Rule_ID", ATTRIBUTE_DATA = xccdfsource.Group[x].Rule.id };
                    stig_data[4] = new STIGObjects.CHECKLISTSTIGSISTIGVULNSTIG_DATA() { VULN_ATTRIBUTE = "Rule_Ver", ATTRIBUTE_DATA = xccdfsource.Group[x].Rule.version };
                    stig_data[5] = new STIGObjects.CHECKLISTSTIGSISTIGVULNSTIG_DATA() { VULN_ATTRIBUTE = "Rule_Title", ATTRIBUTE_DATA = xccdfsource.Group[x].Rule.title };
                    stig_data[6] = new STIGObjects.CHECKLISTSTIGSISTIGVULNSTIG_DATA() { VULN_ATTRIBUTE = "Vuln_Discuss", ATTRIBUTE_DATA = ruleDescriptionEx.VulnDiscussion };
                    stig_data[7] = new STIGObjects.CHECKLISTSTIGSISTIGVULNSTIG_DATA() { VULN_ATTRIBUTE = "IA_Controls", ATTRIBUTE_DATA = ruleDescriptionEx.IAControls.ToString() };
                    stig_data[8] = new STIGObjects.CHECKLISTSTIGSISTIGVULNSTIG_DATA() { VULN_ATTRIBUTE = "Check_Content", ATTRIBUTE_DATA = xccdfsource.Group[x].Rule.check.checkcontent };
                    stig_data[9] = new STIGObjects.CHECKLISTSTIGSISTIGVULNSTIG_DATA() { VULN_ATTRIBUTE = "Fix_Text", ATTRIBUTE_DATA = xccdfsource.Group[x].Rule.fixtext.Value };
                    stig_data[10] = new STIGObjects.CHECKLISTSTIGSISTIGVULNSTIG_DATA() { VULN_ATTRIBUTE = "False_Positives", ATTRIBUTE_DATA = ruleDescriptionEx.FalsePositives.ToString() };
                    stig_data[11] = new STIGObjects.CHECKLISTSTIGSISTIGVULNSTIG_DATA() { VULN_ATTRIBUTE = "False_Negatives", ATTRIBUTE_DATA = ruleDescriptionEx.FalseNegatives.ToString() };
                    stig_data[12] = new STIGObjects.CHECKLISTSTIGSISTIGVULNSTIG_DATA() { VULN_ATTRIBUTE = "Documentable", ATTRIBUTE_DATA = ruleDescriptionEx.Documentable.ToString() };
                    stig_data[13] = new STIGObjects.CHECKLISTSTIGSISTIGVULNSTIG_DATA() { VULN_ATTRIBUTE = "Mitigations", ATTRIBUTE_DATA = ruleDescriptionEx.Mitigations.ToString() };
                    stig_data[13] = new STIGObjects.CHECKLISTSTIGSISTIGVULNSTIG_DATA() { VULN_ATTRIBUTE = "Potential_Impact", ATTRIBUTE_DATA = ruleDescriptionEx.PotentialImpacts.ToString() };
                    stig_data[14] = new STIGObjects.CHECKLISTSTIGSISTIGVULNSTIG_DATA() { VULN_ATTRIBUTE = "Third_Party_Tools", ATTRIBUTE_DATA = ruleDescriptionEx.ThirdPartyTools.ToString() };
                    stig_data[15] = new STIGObjects.CHECKLISTSTIGSISTIGVULNSTIG_DATA() { VULN_ATTRIBUTE = "Mitigation_Control", ATTRIBUTE_DATA = ruleDescriptionEx.MitigationControl.ToString() };
                    stig_data[16] = new STIGObjects.CHECKLISTSTIGSISTIGVULNSTIG_DATA() { VULN_ATTRIBUTE = "Responsibility", ATTRIBUTE_DATA = ruleDescriptionEx.Responsibility.ToString() };
                    stig_data[17] = new STIGObjects.CHECKLISTSTIGSISTIGVULNSTIG_DATA() { VULN_ATTRIBUTE = "Security_Override_Guidance", ATTRIBUTE_DATA = ruleDescriptionEx.SeverityOverrideGuidance.ToString() };
                    stig_data[18] = new STIGObjects.CHECKLISTSTIGSISTIGVULNSTIG_DATA() { VULN_ATTRIBUTE = "Check_Content_Ref", ATTRIBUTE_DATA = xccdfsource.Group[x].Rule.check.checkcontentref.name };
                    stig_data[19] = new STIGObjects.CHECKLISTSTIGSISTIGVULNSTIG_DATA() { VULN_ATTRIBUTE = "Class", ATTRIBUTE_DATA = shortclass };
                    stig_data[20] = new STIGObjects.CHECKLISTSTIGSISTIGVULNSTIG_DATA() { VULN_ATTRIBUTE = "STIGRef", ATTRIBUTE_DATA = xccdfsource.Group[x].Rule.id };
                    stig_data[21] = new STIGObjects.CHECKLISTSTIGSISTIGVULNSTIG_DATA() { VULN_ATTRIBUTE = "TargetKey", ATTRIBUTE_DATA = xccdfsource.Group[x].Rule.reference.identifier.ToString() };
                    stig_data[22] = new STIGObjects.CHECKLISTSTIGSISTIGVULNSTIG_DATA() { VULN_ATTRIBUTE = "CCI_REF", ATTRIBUTE_DATA = xccdfsource.Group[x].Rule.ident.Value };

                    this.CheckList.STIGS.iSTIG.VULN[x] = new STIGObjects.CHECKLISTSTIGSISTIGVULN() { STATUS = "Not_Reviewed", SEVERITY_OVERRIDE = new object(), FINDING_DETAILS = new object(), COMMENTS = new object(), SEVERITY_JUSTIFICATION = new object(), STIG_DATA = stig_data };   
                }

                this.ImportCKL(Serialize_Checklist());
            }
            catch(Exception ex)
            {
                throw new Exception("Unable to import XCCDF file", ex);
            }
        }

        internal void Transform()
        {
            if(this.CheckList == null)
                throw new Exception(string.Format("No STIG has been defined, import Checklist or Benchmark!"));

            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();

            //get ckl target
            var target = this.CMRS.ASSET.TARGET.FirstOrDefault(x => x.TARGET_ID == ChecklistInformation.STIGId);

            foreach (var vuln in this.CheckList.STIGS.iSTIG.VULN)
            {
                var finding = target.FINDING.FirstOrDefault(x => x.FINDING_ID.ID == vuln.STIG_DATA[3].ATTRIBUTE_DATA);
                if (finding != null)
                {
                  
                    if (vuln.COMMENTS as System.Xml.XmlNode[] != null)
                    {
                        ((System.Xml.XmlNode[])vuln.COMMENTS)[0].InnerText = finding.COMMENT as string;
                    }
                    else
                    {
                        System.Xml.XmlNode[] FindingNodes = new System.Xml.XmlNode[1];
                        FindingNodes[0] = doc.CreateTextNode(finding.COMMENT);

                        vuln.COMMENTS = FindingNodes;
                    }

                    if (vuln.FINDING_DETAILS as System.Xml.XmlNode[] != null)
                    {
                        ((System.Xml.XmlNode[])vuln.FINDING_DETAILS)[0].InnerText = finding.FINDING_DETAILS.Value;
                    }
                    else
                    {
                        System.Xml.XmlNode[] FindingNodes = new System.Xml.XmlNode[1];
                        FindingNodes[0] = doc.CreateTextNode(finding.FINDING_DETAILS.Value);

                        vuln.FINDING_DETAILS = FindingNodes;
                    }

                    vuln.STATUS = STIGObjects.Utils.ConvertCMRSFindingLabelToCKL(finding.FINDING_STATUS);

                    if (finding.SEV_OVERRIDE_CODE != 0)
                    {
                        vuln.SEVERITY_OVERRIDE = STIGObjects.Utils.ConvertCMRSSeverityToCKL(finding.SEV_OVERRIDE_CODE);
                        vuln.SEVERITY_JUSTIFICATION = finding.SEV_OVERRIDE_TEXT;
                    }
                }

            }

            this.ImportCKL(Serialize_Checklist());
            this.ChecklistInformation.Transfromed = true;


        }

        private string Serialize_Checklist()
        {
            try
            {
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(STIGObjects.CHECKLIST));

                using (Utf8StringWriter stringwriter = new Utf8StringWriter())
                {
                    
                    serializer.Serialize(stringwriter, this.CheckList);

                    return stringwriter.GetStringBuilder().ToString();
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Unable to serilize checklist to text", ex);
            }
        }

        private STIGObjects.Benchmark ParseBenchmark(string XMLContent)
        {
            try
            {
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(STIGObjects.Benchmark));

                using (System.IO.StringReader stringreader = new System.IO.StringReader(XMLContent))
                {
                    return (STIGObjects.Benchmark)serializer.Deserialize(stringreader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to Parse XML to benchmark", ex);
            }
        }

        private STIGObjects.IMPORT_FILE ParseCMRS(string XMLContent)
        {
            try
            {
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(STIGObjects.IMPORT_FILE));

                using (System.IO.StringReader stringreader = new System.IO.StringReader(XMLContent))
                {
                    return (STIGObjects.IMPORT_FILE)serializer.Deserialize(stringreader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to Parse XML to CMRS", ex);
            }
        }

        private STIGObjects.CHECKLIST ParseChecklist(string XMLContent)
        {
            try
            {
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(STIGObjects.CHECKLIST));

                using (System.IO.StringReader stringreader = new System.IO.StringReader(XMLContent))
                {
                    return (STIGObjects.CHECKLIST)serializer.Deserialize(stringreader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to Parse XML to Checklist", ex);
            }
        }

    }
}
