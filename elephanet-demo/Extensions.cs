using System;
using Nancy;
using System.Linq;

namespace elephanet_demo
{
    public static class Extensions
    {
        public static bool HasQuery(this NancyContext context, params string[] values)
        {
            var query = context.Request.Query;
            return values.All(value => query[value].HasValue);
        }
    }
}
