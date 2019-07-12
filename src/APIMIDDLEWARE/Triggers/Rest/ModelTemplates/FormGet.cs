using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMIDDLEWARE.Triggers.Rest.ModelTemplates
{
    public class FormGet
    {
        public class MainForm
        {
            public string Key { get; set; }
            public string FormType { get; set; }
            public string LifeCycle { get; set; }
            public int LockVersion { get; set; }
            public bool IsConfirmationObject { get; set; }
            public int IsConfirmationOnLaunch { get; set; }
            public string ClassName { get; set; }
            public bool HasActions { get; set; }
            public bool HasHistories { get; set; }
            public string Title { get; set; }
            public string Url { get; set; }
            public bool HasCollections { get; set; }
            public string OkButtonText { get; set; }
            public string ApplyButtonText { get; set; }
            public string CancelButtonText { get; set; }
            public FormItemGroup[] FormItems { get; set; }
            public FormResource Resources { get; set; }
        }

        public class FormItemGroup
        {
            public string Label { get; set; }
            public string FullName { get; set; }
            public string DataType { get; set; }
            public bool IsTwoColumnGroup { get; set; }
            public SubFormItem[] FormItems { get; set; }
        }

        public class SubFormItem
        {
            public string FullName { get; set; }
            public string DataType { get; set; }
            public string Value { get; set; }
            public string ClassName { get; set; }
            public string DisplayText { get; set; }
            public string Linkable { get; set; }
            public string LinkableInfo { get; set; }
            public string Label { get; set; }
            public SubFormItemOption Options { get; set; }
        }

        public class SubFormItemOption
        {
            public bool? IsTriggerValueChanged { get; set; }
            public bool? IsMandatory { get; set; }
            public bool? IsReadOnly { get; set; }
            public bool? HasFilter { get; set; }
            public bool? IsMultiline { get; set; }
            public bool? MinimumRows { get; set; }
            public bool? IsCategory { get; set; }
            public bool? IsHidden { get; set; }
            public bool? ShortDateFormat { get; set; }
            public bool? IsTimeOnly { get; set; }
            public bool? IsDateOnly { get; set; }
            public int? MaxLength { get; set; }
            public string[] CustomValidators { get; set; }
        }

        public class FormResource
        {
            public FormResourceAction Actions { get; set; }
        }

        public class FormResourceAction
        {
            public FormImpactDiagram ImpactDiagram { get; set; }
        }

        public class FormImpactDiagram
        {
            public string Href { get; set; }
            public string Type { get; set; }
            public string[] Allowed { get; set; }
        }
    }
}
