using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMIDDLEWARE.Triggers.Rest.ModelTemplates
{
    public class FormPostPatch
    {
        public class InsertionItem
        {
            public InsertionItem() { FormValues = new List<FormItem>(); }
            public List<FormItem> FormValues { get; set; }
        }

        public class UpdationItem
        {
            public UpdationItem() { FormValues = new List<FormItem>(); OriginalValues = new List<FormItem>(); LockVersion = 1; }
            public List<FormItem> FormValues { get; set; }
            public List<FormItem> OriginalValues { get; set; }
            public int LockVersion { get; set; }
        }

        public class FormItem
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }

        public class FormResponse
        {
            public string ClassName { get; set; }
            public string Key { get; set; }
        }
    }
}
