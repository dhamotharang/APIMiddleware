using System;
using System.Reflection;

namespace APIMIDDLEWARE._Functions.Models
{
    public enum RequestType
    {
        [RequestMetadata(Value = "GET")]
        GET,
        [RequestMetadata(Value = "POST")]
        POST,
        [RequestMetadata(Value = "PUT")]
        PUT,
        [RequestMetadata(Value = "PATCH")]
        PATCH,
        [RequestMetadata(Value = "DELETE")]
        DELETE
    }

    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    class RequestMetadata : Attribute
    {
        public RequestMetadata()
        {
            this.Value = "GET";
        }
        public string Value { get; set; }
    }


    public static class RequestTypeExtensions
    {
        private static object GetMetadata(RequestType rt)
        {
            var type = rt.GetType();
            MemberInfo[] info = type.GetMember(rt.ToString());
            if ((info != null) && (info.Length > 0))
            {
                object[] attrs = info[0].GetCustomAttributes(typeof(RequestMetadata), false);
                if ((attrs != null) && (attrs.Length > 0))
                {
                    return attrs[0];
                }
            }
            return null;
        }

        public static string ToValue(this RequestType rt)
        {
            var metadata = GetMetadata(rt);
            return (metadata != null) ? ((RequestMetadata)metadata).Value : rt.ToString();
        }
    }
}