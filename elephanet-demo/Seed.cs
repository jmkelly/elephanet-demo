using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ploeh.AutoFixture;
using Elephanet;
using System.IO;
using Newtonsoft.Json;


namespace elephanet_demo 
{
    public class Seed
    {
        public static void Run(string connectionString)
        {
            List<Toilet> toilets = new List<Toilet>();
            using (StreamReader r = new StreamReader("toilets.json"))
            {
                string json = r.ReadToEnd();
                toilets = JsonConvert.DeserializeObject<List<Toilet>>(json);
            }

            var store = new DocumentStore(connectionString);
            using (var session = store.OpenSession())
            {
                try
                {
                    session.DeleteAll<Toilet>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(string.Format("Delete Failed.  See Inner Exception for more details. {0}", ex));
                }

                foreach (var toilet in toilets)
                {
                    session.Store<Toilet>(toilet);
                }

                session.SaveChanges();
            }
        }
    }
}

