using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMIDDLEWARE.Triggers.Rest.ModelTemplates
{
    public class ObjectGet
    {
        public class MainClass
        {
            public string ClassName { get; set; }
            public ClassAction[] Actions { get; set; }
        }

        public class ClassAction
        {
            public string FormClassName { get; set; }
            public string Name { get; set; }
            public string Title { get; set; }
            public string Type { get; set; }
        }
    }
}
