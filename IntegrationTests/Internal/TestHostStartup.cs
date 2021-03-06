﻿using System.Collections.Generic;
using System.IO;
using Owin;

namespace Gate.Adapters.AspNet.IntegrationTests.Internal {
    public class TestHostStartup {
        public void Configuration(IAppBuilder app) {
            var webSitePath = Path.Combine(Path.GetDirectoryName(this.GetType().Assembly.Location), @"..\..\..\TestWebSite");
            webSitePath = Path.GetFullPath(webSitePath);

            var testApplicationData = new Dictionary<string, object> {
                { "Test.Data", TestHost.TestApplicationDataValue },
                { "Test.Data.Provider", new TestStringProvider(TestHost.TestApplicationDataProviderValue) }
            };
            app.Use(typeof(AspNetAdapter), new AspNetAdapterArguments(webSitePath, testApplicationData));
        }
    }
}