using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMRSUtil
{
    public partial class STIGObjects
    {


        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:FindingImport")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:FindingImport", IsNullable = false)]
        public partial class IMPORT_FILE
        {

            private IMPORT_FILEASSET aSSETField;

            /// <remarks/>
            public IMPORT_FILEASSET ASSET
            {
                get
                {
                    return this.aSSETField;
                }
                set
                {
                    this.aSSETField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:FindingImport")]
        public partial class IMPORT_FILEASSET
        {

            private System.DateTime aSSET_TSField;

            private IMPORT_FILEASSETASSET_ID[] aSSET_IDField;

            private IMPORT_FILEASSETASSET_TYPE aSSET_TYPEField;

            private IMPORT_FILEASSETELEMENT[] eLEMENTField;

            private IMPORT_FILEASSETTARGET[] tARGETField;

            /// <remarks/>
            public System.DateTime ASSET_TS
            {
                get
                {
                    return this.aSSET_TSField;
                }
                set
                {
                    this.aSSET_TSField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("ASSET_ID")]
            public IMPORT_FILEASSETASSET_ID[] ASSET_ID
            {
                get
                {
                    return this.aSSET_IDField;
                }
                set
                {
                    this.aSSET_IDField = value;
                }
            }

            /// <remarks/>
            public IMPORT_FILEASSETASSET_TYPE ASSET_TYPE
            {
                get
                {
                    return this.aSSET_TYPEField;
                }
                set
                {
                    this.aSSET_TYPEField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("ELEMENT")]
            public IMPORT_FILEASSETELEMENT[] ELEMENT
            {
                get
                {
                    return this.eLEMENTField;
                }
                set
                {
                    this.eLEMENTField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("TARGET")]
            public IMPORT_FILEASSETTARGET[] TARGET
            {
                get
                {
                    return this.tARGETField;
                }
                set
                {
                    this.tARGETField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:FindingImport")]
        public partial class IMPORT_FILEASSETASSET_ID
        {

            private string tYPEField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string TYPE
            {
                get
                {
                    return this.tYPEField;
                }
                set
                {
                    this.tYPEField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:FindingImport")]
        public partial class IMPORT_FILEASSETASSET_TYPE
        {

            private byte aSSET_TYPE_KEYField;

            /// <remarks/>
            public byte ASSET_TYPE_KEY
            {
                get
                {
                    return this.aSSET_TYPE_KEYField;
                }
                set
                {
                    this.aSSET_TYPE_KEYField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:FindingImport")]
        public partial class IMPORT_FILEASSETELEMENT
        {

            private ushort eLEMENT_KEYField;

            /// <remarks/>
            public ushort ELEMENT_KEY
            {
                get
                {
                    return this.eLEMENT_KEYField;
                }
                set
                {
                    this.eLEMENT_KEYField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:FindingImport")]
        public partial class IMPORT_FILEASSETTARGET
        {

            private string tARGET_IDField;

            private ushort tARGET_KEYField;

            private IMPORT_FILEASSETTARGETFINDING[] fINDINGField;

            /// <remarks/>
            public string TARGET_ID
            {
                get
                {
                    return this.tARGET_IDField;
                }
                set
                {
                    this.tARGET_IDField = value;
                }
            }

            /// <remarks/>
            public ushort TARGET_KEY
            {
                get
                {
                    return this.tARGET_KEYField;
                }
                set
                {
                    this.tARGET_KEYField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("FINDING")]
            public IMPORT_FILEASSETTARGETFINDING[] FINDING
            {
                get
                {
                    return this.fINDINGField;
                }
                set
                {
                    this.fINDINGField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:FindingImport")]
        public partial class IMPORT_FILEASSETTARGETFINDING
        {

            private IMPORT_FILEASSETTARGETFINDINGFINDING_ID fINDING_IDField;

            private string fINDING_STATUSField;

            private IMPORT_FILEASSETTARGETFINDINGFINDING_DETAILS fINDING_DETAILSField;

            private byte sEV_OVERRIDE_CODEField;

            private bool sEV_OVERRIDE_CODEFieldSpecified;

            private string sEV_OVERRIDE_TEXTField;

            private object sCRIPT_RESULTSField;

            private string cOMMENTField;

            private string tOOLField;

            private string tOOL_VERSIONField;

            private bool aUTHENTICATED_FINDINGField;

            /// <remarks/>
            public IMPORT_FILEASSETTARGETFINDINGFINDING_ID FINDING_ID
            {
                get
                {
                    return this.fINDING_IDField;
                }
                set
                {
                    this.fINDING_IDField = value;
                }
            }

            /// <remarks/>
            public string FINDING_STATUS
            {
                get
                {
                    return this.fINDING_STATUSField;
                }
                set
                {
                    this.fINDING_STATUSField = value;
                }
            }

            /// <remarks/>
            public IMPORT_FILEASSETTARGETFINDINGFINDING_DETAILS FINDING_DETAILS
            {
                get
                {
                    return this.fINDING_DETAILSField;
                }
                set
                {
                    this.fINDING_DETAILSField = value;
                }
            }

            /// <remarks/>
            public byte SEV_OVERRIDE_CODE
            {
                get
                {
                    return this.sEV_OVERRIDE_CODEField;
                }
                set
                {
                    this.sEV_OVERRIDE_CODEField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool SEV_OVERRIDE_CODESpecified
            {
                get
                {
                    return this.sEV_OVERRIDE_CODEFieldSpecified;
                }
                set
                {
                    this.sEV_OVERRIDE_CODEFieldSpecified = value;
                }
            }

            /// <remarks/>
            public string SEV_OVERRIDE_TEXT
            {
                get
                {
                    return this.sEV_OVERRIDE_TEXTField;
                }
                set
                {
                    this.sEV_OVERRIDE_TEXTField = value;
                }
            }

            /// <remarks/>
            public object SCRIPT_RESULTS
            {
                get
                {
                    return this.sCRIPT_RESULTSField;
                }
                set
                {
                    this.sCRIPT_RESULTSField = value;
                }
            }

            /// <remarks/>
            public string COMMENT
            {
                get
                {
                    return this.cOMMENTField;
                }
                set
                {
                    this.cOMMENTField = value;
                }
            }

            /// <remarks/>
            public string TOOL
            {
                get
                {
                    return this.tOOLField;
                }
                set
                {
                    this.tOOLField = value;
                }
            }

            /// <remarks/>
            public string TOOL_VERSION
            {
                get
                {
                    return this.tOOL_VERSIONField;
                }
                set
                {
                    this.tOOL_VERSIONField = value;
                }
            }

            /// <remarks/>
            public bool AUTHENTICATED_FINDING
            {
                get
                {
                    return this.aUTHENTICATED_FINDINGField;
                }
                set
                {
                    this.aUTHENTICATED_FINDINGField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:FindingImport")]
        public partial class IMPORT_FILEASSETTARGETFINDINGFINDING_ID
        {

            private string tYPEField;

            private string idField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string TYPE
            {
                get
                {
                    return this.tYPEField;
                }
                set
                {
                    this.tYPEField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:FindingImport")]
        public partial class IMPORT_FILEASSETTARGETFINDINGFINDING_DETAILS
        {

            private string oVERRIDEField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string OVERRIDE
            {
                get
                {
                    return this.oVERRIDEField;
                }
                set
                {
                    this.oVERRIDEField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }
    }
}
