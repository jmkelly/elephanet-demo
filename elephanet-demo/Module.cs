using Nancy;
using Elephanet;
using System.Linq;
using System;

namespace elephanet_demo
{
    public class Module : NancyModule
    {
        public Module(IDocumentSession session)
        {
            Get["/"] = _ =>
                {
                    return View["Index"];
                };

            Get["/toilets"] = _ =>
                {
                    var toilets = session.GetAll<Toilet>().ToList();
                    return Response.AsJson(toilets);
                };

            Get["/toilets", ctx => ctx.HasQuery("name")] = param =>
            {
                var toilets = session.Query<Toilet>().Where(c => c.Name == "name");
                return Response.AsJson(toilets);
            };
        }
    }
}
