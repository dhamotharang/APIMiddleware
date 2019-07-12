using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMIDDLEWARE.Triggers.Rest.ModelTemplates
{
    public class QueryGet
    {
        public class MainQuery
        {
            public QueryInfo QueryDefinition { get; set; }
            public QueryDataRow[] DataRows { get; set; }
            public int CurrentPage { get; set; }
            public int PageCount { get; set; }
            public int TotalCount { get; set; }
            public int ValueStructureType { get; set; }
            public QueryResource Resources { get; set; }
        }

        public class QueryInfo
        {
            public string QueryName { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public int PageSize { get; set; }
            public bool IsDataGrouped { get; set; }
            public int RefreshInterval { get; set; }
            public string ExpandClass { get; set; }
            public string ReportTemplate { get; set; }
            public string ExpandedReportTemplate { get; set; }
            public QueryDataAttribute[] DataAttributes { get; set; }
            public QueryCondition[] Conditions { get; set; }
            public string[] SortAttributes { get; set; }
            public string GroupByTitle { get; set; }
            public string Url { get; set; }
        }

        public class QueryDataAttribute
        {
            public string FullAttributePath { get; set; }
            public string Title { get; set; }
            public string DataType { get; set; }
            public bool Privileged { get; set; }
            public bool IsColour { get; set; }
            public bool IsSuccessFlag { get; set; }
        }

        public class QueryCondition
        {
            public string[] ChildConditions { get; set; }
            public string FullAttributePath { get; set; }
            public string Operator { get; set; }
            public string ConditionType { get; set; }
            public string Value { get; set; }
            public bool IsPrompt { get; set; }
            public string Title { get; set; }
        }

        public class QueryDataRow
        {
            public string ClassName { get; set; }
            public string Key { get; set; }
            public string ItemLaunchClassName { get; set; }
            public string ItemLaunchKey { get; set; }
            public QueryDataRowValue Values { get; set; }
        }

        public class QueryDataRowValue
        {
            public string Id { get; set; }
            public string Title { get; set; }
            public string _Title { get; set; }
        }

        public class QueryResource
        {
            public QueryResourceAction Actions { get; set; }
        }

        public class QueryResourceAction
        {
            public QueryBulkAction BulkAction { get; set; }
        }

        public class QueryBulkAction
        {
            public string Href { get; set; }
            public string Type { get; set; }
            public string[] Allowed { get; set; }
        }
    }
}
