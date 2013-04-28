﻿using System;
using System.Collections.Generic;
using System.Linq;
using Gate.Adapters.AspNet.IntegrationTests.Internal;
using Xunit;

namespace Gate.Adapters.AspNet.IntegrationTests {
    public class BasicResponseTests {
        [Fact]
        public void Content_FromQueryString() {
            var result = HttpTestHelper.GetString("/Test/ContentFromQueryString?content=ABC");
            Assert.Equal("ABC", result);
        }

        [Fact]
        public void View_FromQueryString() {
            var result = HttpTestHelper.GetString("/Test/ViewFromQueryString?content=Unicorn");
            Assert.Contains("Unicorn", result);
        }
    }
}
