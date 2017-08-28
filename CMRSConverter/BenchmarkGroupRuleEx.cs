using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMRSUtil
{

    public class BenchmarkGroupRuleEx
    {
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class Description
        {

            private string vulnDiscussionField;

            private string falsePositivesField;

            private string falseNegativesField;

            private bool documentableField;

            private string mitigationsField;

            private string severityOverrideGuidanceField;

            private string potentialImpactsField;

            private string thirdPartyToolsField;

            private string mitigationControlField;

            private string responsibilityField;

            private string iAControlsField;

            /// <remarks/>
            public string VulnDiscussion
            {
                get
                {
                    return this.vulnDiscussionField;
                }
                set
                {
                    this.vulnDiscussionField = value;
                }
            }

            /// <remarks/>
            public string FalsePositives
            {
                get
                {
                    return this.falsePositivesField;
                }
                set
                {
                    this.falsePositivesField = value;
                }
            }

            /// <remarks/>
            public string FalseNegatives
            {
                get
                {
                    return this.falseNegativesField;
                }
                set
                {
                    this.falseNegativesField = value;
                }
            }

            /// <remarks/>
            public bool Documentable
            {
                get
                {
                    return this.documentableField;
                }
                set
                {
                    this.documentableField = value;
                }
            }

            /// <remarks/>
            public string Mitigations
            {
                get
                {
                    return this.mitigationsField;
                }
                set
                {
                    this.mitigationsField = value;
                }
            }

            /// <remarks/>
            public string SeverityOverrideGuidance
            {
                get
                {
                    return this.severityOverrideGuidanceField;
                }
                set
                {
                    this.severityOverrideGuidanceField = value;
                }
            }

            /// <remarks/>
            public string PotentialImpacts
            {
                get
                {
                    return this.potentialImpactsField;
                }
                set
                {
                    this.potentialImpactsField = value;
                }
            }

            /// <remarks/>
            public string ThirdPartyTools
            {
                get
                {
                    return this.thirdPartyToolsField;
                }
                set
                {
                    this.thirdPartyToolsField = value;
                }
            }

            /// <remarks/>
            public string MitigationControl
            {
                get
                {
                    return this.mitigationControlField;
                }
                set
                {
                    this.mitigationControlField = value;
                }
            }

            /// <remarks/>
            public string Responsibility
            {
                get
                {
                    return this.responsibilityField;
                }
                set
                {
                    this.responsibilityField = value;
                }
            }

            /// <remarks/>
            public string IAControls
            {
                get
                {
                    return this.iAControlsField;
                }
                set
                {
                    this.iAControlsField = value;
                }
            }
        }

       
    }

    static class BenchmarkGroupRuleExMethods
    {
        public static BenchmarkGroupRuleEx.Description ExpandGroupRuleDescription(this STIGObjects.BenchmarkGroupRule benchmarkgrouprule)
        {
            try
            {
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(BenchmarkGroupRuleEx.Description));

                using (System.IO.StringReader stringreader = new System.IO.StringReader("<Description>" + benchmarkgrouprule.description + "</Description>"))
                {
                    return (BenchmarkGroupRuleEx.Description)serializer.Deserialize(stringreader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to desirilize description field", ex);
            }
        }
    }
}
