using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using AdventureWorksSample.Models;
using Microsoft.Restier.EntityFramework;
using Microsoft.Restier.WebApi;

namespace AdventureWorksSample
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapRestierRoute<DbApi<AdventureWorksContext>>("AdventureWorks", "AdventureWorks").Wait();
        }
    }
}
