using Nancy;
using Elephanet;
using Nancy.TinyIoc;

namespace elephanet_demo
{
    public class Bootstrapper :  DefaultNancyBootstrapper
    {

        protected override void ApplicationStartup(TinyIoCContainer container, Nancy.Bootstrapper.IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);
            Nancy.Json.JsonSettings.MaxJsonLength = int.MaxValue;
        }
  
        protected override void ConfigureRequestContainer(TinyIoCContainer container, NancyContext context)
        {
            var store = new DocumentStore(Database.ConnectionString());
            container.Register<IDocumentSession>(store.OpenSession());
        }
    }
}
