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
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://checklists.nist.gov/xccdf/1.1")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://checklists.nist.gov/xccdf/1.1", IsNullable = false)]
        public partial class Benchmark
        {

            private BenchmarkStatus statusField;

            private string titleField;

            private string descriptionField;

            private BenchmarkNotice noticeField;

            private BenchmarkReference referenceField;

            private BenchmarkPlaintext plaintextField;

            private byte versionField;

            private BenchmarkProfile[] profileField;

            private BenchmarkGroup[] groupField;

            private string idField;

            private string langField;

            /// <remarks/>
            public BenchmarkStatus status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            public string title
            {
                get
                {
                    return this.titleField;
                }
                set
                {
                    this.titleField = value;
                }
            }

            /// <remarks/>
            public string description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            public BenchmarkNotice notice
            {
                get
                {
                    return this.noticeField;
                }
                set
                {
                    this.noticeField = value;
                }
            }

            /// <remarks/>
            public BenchmarkReference reference
            {
                get
                {
                    return this.referenceField;
                }
                set
                {
                    this.referenceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("plain-text")]
            public BenchmarkPlaintext plaintext
            {
                get
                {
                    return this.plaintextField;
                }
                set
                {
                    this.plaintextField = value;
                }
            }

            /// <remarks/>
            public byte version
            {
                get
                {
                    return this.versionField;
                }
                set
                {
                    this.versionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Profile")]
            public BenchmarkProfile[] Profile
            {
                get
                {
                    return this.profileField;
                }
                set
                {
                    this.profileField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Group")]
            public BenchmarkGroup[] Group
            {
                get
                {
                    return this.groupField;
                }
                set
                {
                    this.groupField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
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
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
            public string lang
            {
                get
                {
                    return this.langField;
                }
                set
                {
                    this.langField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://checklists.nist.gov/xccdf/1.1")]
        public partial class BenchmarkStatus
        {

            private System.DateTime dateField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
            public System.DateTime date
            {
                get
                {
                    return this.dateField;
                }
                set
                {
                    this.dateField = value;
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
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://checklists.nist.gov/xccdf/1.1")]
        public partial class BenchmarkNotice
        {

            private string idField;

            private string langField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
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
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
            public string lang
            {
                get
                {
                    return this.langField;
                }
                set
                {
                    this.langField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://checklists.nist.gov/xccdf/1.1")]
        public partial class BenchmarkReference
        {

            private string publisherField;

            private string sourceField;

            private string hrefField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://purl.org/dc/elements/1.1/")]
            public string publisher
            {
                get
                {
                    return this.publisherField;
                }
                set
                {
                    this.publisherField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://purl.org/dc/elements/1.1/")]
            public string source
            {
                get
                {
                    return this.sourceField;
                }
                set
                {
                    this.sourceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string href
            {
                get
                {
                    return this.hrefField;
                }
                set
                {
                    this.hrefField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://checklists.nist.gov/xccdf/1.1")]
        public partial class BenchmarkPlaintext
        {

            private string idField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
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
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://checklists.nist.gov/xccdf/1.1")]
        public partial class BenchmarkProfile
        {

            private string titleField;

            private string descriptionField;

            private BenchmarkProfileSelect[] selectField;

            private string idField;

            /// <remarks/>
            public string title
            {
                get
                {
                    return this.titleField;
                }
                set
                {
                    this.titleField = value;
                }
            }

            /// <remarks/>
            public string description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("select")]
            public BenchmarkProfileSelect[] select
            {
                get
                {
                    return this.selectField;
                }
                set
                {
                    this.selectField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://checklists.nist.gov/xccdf/1.1")]
        public partial class BenchmarkProfileSelect
        {

            private string idrefField;

            private bool selectedField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string idref
            {
                get
                {
                    return this.idrefField;
                }
                set
                {
                    this.idrefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool selected
            {
                get
                {
                    return this.selectedField;
                }
                set
                {
                    this.selectedField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://checklists.nist.gov/xccdf/1.1")]
        public partial class BenchmarkGroup
        {

            private string titleField;

            private string descriptionField;

            private BenchmarkGroupRule ruleField;

            private string idField;

            /// <remarks/>
            public string title
            {
                get
                {
                    return this.titleField;
                }
                set
                {
                    this.titleField = value;
                }
            }

            /// <remarks/>
            public string description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            public BenchmarkGroupRule Rule
            {
                get
                {
                    return this.ruleField;
                }
                set
                {
                    this.ruleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://checklists.nist.gov/xccdf/1.1")]
        public partial class BenchmarkGroupRule
        {

            private string versionField;

            private string titleField;

            private string descriptionField;

            private BenchmarkGroupRuleReference referenceField;

            private BenchmarkGroupRuleIdent identField;

            private BenchmarkGroupRuleFixtext fixtextField;

            private BenchmarkGroupRuleFix fixField;

            private BenchmarkGroupRuleCheck checkField;

            private string idField;

            private string severityField;

            private decimal weightField;

            /// <remarks/>
            public string version
            {
                get
                {
                    return this.versionField;
                }
                set
                {
                    this.versionField = value;
                }
            }

            /// <remarks/>
            public string title
            {
                get
                {
                    return this.titleField;
                }
                set
                {
                    this.titleField = value;
                }
            }

            /// <remarks/>
            public string description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            public BenchmarkGroupRuleReference reference
            {
                get
                {
                    return this.referenceField;
                }
                set
                {
                    this.referenceField = value;
                }
            }

            /// <remarks/>
            public BenchmarkGroupRuleIdent ident
            {
                get
                {
                    return this.identField;
                }
                set
                {
                    this.identField = value;
                }
            }

            /// <remarks/>
            public BenchmarkGroupRuleFixtext fixtext
            {
                get
                {
                    return this.fixtextField;
                }
                set
                {
                    this.fixtextField = value;
                }
            }

            /// <remarks/>
            public BenchmarkGroupRuleFix fix
            {
                get
                {
                    return this.fixField;
                }
                set
                {
                    this.fixField = value;
                }
            }

            /// <remarks/>
            public BenchmarkGroupRuleCheck check
            {
                get
                {
                    return this.checkField;
                }
                set
                {
                    this.checkField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
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
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string severity
            {
                get
                {
                    return this.severityField;
                }
                set
                {
                    this.severityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal weight
            {
                get
                {
                    return this.weightField;
                }
                set
                {
                    this.weightField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://checklists.nist.gov/xccdf/1.1")]
        public partial class BenchmarkGroupRuleReference
        {

            private string titleField;

            private string publisherField;

            private string typeField;

            private string subjectField;

            private ushort identifierField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://purl.org/dc/elements/1.1/")]
            public string title
            {
                get
                {
                    return this.titleField;
                }
                set
                {
                    this.titleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://purl.org/dc/elements/1.1/")]
            public string publisher
            {
                get
                {
                    return this.publisherField;
                }
                set
                {
                    this.publisherField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://purl.org/dc/elements/1.1/")]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://purl.org/dc/elements/1.1/")]
            public string subject
            {
                get
                {
                    return this.subjectField;
                }
                set
                {
                    this.subjectField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://purl.org/dc/elements/1.1/")]
            public ushort identifier
            {
                get
                {
                    return this.identifierField;
                }
                set
                {
                    this.identifierField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://checklists.nist.gov/xccdf/1.1")]
        public partial class BenchmarkGroupRuleIdent
        {

            private string systemField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string system
            {
                get
                {
                    return this.systemField;
                }
                set
                {
                    this.systemField = value;
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
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://checklists.nist.gov/xccdf/1.1")]
        public partial class BenchmarkGroupRuleFixtext
        {

            private string fixrefField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string fixref
            {
                get
                {
                    return this.fixrefField;
                }
                set
                {
                    this.fixrefField = value;
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
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://checklists.nist.gov/xccdf/1.1")]
        public partial class BenchmarkGroupRuleFix
        {

            private string idField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://checklists.nist.gov/xccdf/1.1")]
        public partial class BenchmarkGroupRuleCheck
        {

            private BenchmarkGroupRuleCheckCheckcontentref checkcontentrefField;

            private string checkcontentField;

            private string systemField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("check-content-ref")]
            public BenchmarkGroupRuleCheckCheckcontentref checkcontentref
            {
                get
                {
                    return this.checkcontentrefField;
                }
                set
                {
                    this.checkcontentrefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("check-content")]
            public string checkcontent
            {
                get
                {
                    return this.checkcontentField;
                }
                set
                {
                    this.checkcontentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string system
            {
                get
                {
                    return this.systemField;
                }
                set
                {
                    this.systemField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://checklists.nist.gov/xccdf/1.1")]
        public partial class BenchmarkGroupRuleCheckCheckcontentref
        {

            private string nameField;

            private string hrefField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string href
            {
                get
                {
                    return this.hrefField;
                }
                set
                {
                    this.hrefField = value;
                }
            }
        }
    }

}

